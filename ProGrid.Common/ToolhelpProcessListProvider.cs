using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProGrid.Common {
    public class ToolhelpProcessListProvider : IProcessListProvider {
        public BasicProcessInfo[] CaptureProcessList() {
            IntPtr hSnapshot = IntPtr.Zero;
            List<BasicProcessInfo> lstProcesses = new List<BasicProcessInfo>();
            Interop.ProcessEntry32_Managed entryCur = new Interop.ProcessEntry32_Managed() 
                { Size = Marshal.SizeOf<Interop.ProcessEntry32_Managed>() };
            int nLastError = 0;

            try {
                hSnapshot = Interop.Functions.CreateToolhelp32Snapshot(Interop.ToolhelpSnapshotFlags.SnapProcesses, 0);
                if (hSnapshot == IntPtr.Zero)
                    throw new System.ComponentModel.Win32Exception();

                if (!Interop.Functions.Process32First_Managed(hSnapshot, ref entryCur)) {
                    nLastError = Marshal.GetLastWin32Error();
                    if (nLastError == Interop.Constants.ERROR_NO_MORE_FILES)
                        return Array.Empty<BasicProcessInfo>();
                    else
                        throw new System.ComponentModel.Win32Exception(nLastError);
                }

                do {
                    BasicProcessInfo infProcess = new BasicProcessInfo() {
                        ExecutablePath = entryCur.ExecutablePath,
                        ID = entryCur.ProcessID,
                        ParentProcessObject = SystemProcess.TryOpenByID(entryCur.ParentProcessID),
                        ProcessObject = SystemProcess.TryOpenByID(entryCur.ProcessID)
                    };

                    lstProcesses.Add(infProcess);
                } while (Interop.Functions.Process32Next_Managed(hSnapshot, ref entryCur));

                nLastError = Marshal.GetLastWin32Error();
                if (nLastError != Interop.Constants.ERROR_NO_MORE_FILES)
                    throw new System.ComponentModel.Win32Exception(nLastError);
            } finally {
                if (hSnapshot != IntPtr.Zero)
                    Interop.Functions.CloseHandle(hSnapshot);
            }

            return lstProcesses.ToArray();
        }
    }
}
