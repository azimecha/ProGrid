using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProGrid.Common {
    public interface IProcessCreationMonitor {
        event Action<IProcessCreationMonitor, BasicProcessInfo> ProcessCreated;
        event Action<IProcessCreationMonitor, BasicProcessInfo> ProcessTerminated;
        void MonitorProcess(SystemProcess pro);
    }

    public struct BasicProcessInfo {
        public SystemProcess ProcessObject;
        public SystemProcess ParentProcessObject;
        public string CommandLine;
        public string ExecutablePath;
        public int ID;
    }
}
