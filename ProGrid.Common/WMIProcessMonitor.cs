using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace ProGrid.Common {
    public class WMIProcessMonitor : ManagementEventWatcher, IProcessCreationMonitor {
        private HashSet<int> _setListenTo = new HashSet<int>();

        public event Action<IProcessCreationMonitor, BasicProcessInfo> ProcessCreated;
        public event Action<IProcessCreationMonitor, BasicProcessInfo> ProcessTerminated;

        private const string QUERY = "SELECT * FROM __InstanceOperationEvent WITHIN 1 WHERE TargetInstance ISA 'Win32_Process'";

        public WMIProcessMonitor() {
            Query.QueryLanguage = "WQL";
            Query.QueryString = QUERY;
            EventArrived += WMIProcessMonitor_EventArrived;
            Start();
        }

        private void WMIProcessMonitor_EventArrived(object sender, EventArrivedEventArgs e) {
            string strEvtType = e.NewEvent.ClassPath.ClassName;
            Interop.Win32_Process proEvented = new Interop.Win32_Process(e.NewEvent["TargetInstance"] as ManagementBaseObject);

            if (proEvented is null)
                return;

            lock (_setListenTo)
                if (!_setListenTo.Contains((int)proEvented.ParentProcessId))
                    return;

            BasicProcessInfo infProcess = new BasicProcessInfo() {
                CommandLine = proEvented.CommandLine,
                ExecutablePath = proEvented.ExecutablePath,
                ID = (int)proEvented.ProcessId,
                ParentProcessObject = SystemProcess.TryOpenByID((int)proEvented.ParentProcessId),
                ProcessObject = SystemProcess.TryOpenByID((int)proEvented.ProcessId)
            };

            switch (strEvtType) {
                case "__InstanceCreationEvent":
                    Task.Run(() => ProcessCreated?.Invoke(this, infProcess));
                    break;

                case "__InstanceDeletionEvent":
                    _setListenTo.Remove(infProcess.ID);
                    Task.Run(() => ProcessTerminated?.Invoke(this, infProcess));
                    break;
            }
        }

        public void MonitorProcess(SystemProcess pro) {
            lock (_setListenTo)
                _setListenTo.Add(pro.ID);
        }
    }
}
