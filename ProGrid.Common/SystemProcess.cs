using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProGrid.Common {
    public class SystemProcess : IDisposable {
        private IntPtr _hProcess = IntPtr.Zero;

        public static SystemProcess Current => new SystemProcess() { Handle = CURRENT_PROCESS };

        public IntPtr Handle {
            get {
                IntPtr hProcess = _hProcess;
                if (hProcess == IntPtr.Zero)
                    throw new InvalidOperationException("Process object not initialized");
                return hProcess;
            }
            set {
                if (Interlocked.CompareExchange(ref _hProcess, value, IntPtr.Zero) != IntPtr.Zero)
                    throw new InvalidOperationException("Process object already initialized");
            }
        }

        public static SystemProcess OpenByID(int nProcessID, Interop.ProcessAccess flagsAccess
            = Interop.ProcessAccess.QueryLimitedInformation | Interop.ProcessAccess.Synchronize)
        {
            SystemProcess proOpened = new SystemProcess();

            proOpened.Handle = Interop.Functions.OpenProcess(flagsAccess, false, nProcessID);
            if (proOpened._hProcess == IntPtr.Zero)
                throw new System.ComponentModel.Win32Exception();

            return proOpened;
        }

        public static SystemProcess TryOpenByID(int nProcessID, Interop.ProcessAccess flagsAccess
            = Interop.ProcessAccess.QueryLimitedInformation | Interop.ProcessAccess.Synchronize)
        {
            SystemProcess proOpened = new SystemProcess();

            proOpened.Handle = Interop.Functions.OpenProcess(flagsAccess, false, nProcessID);
            if (proOpened._hProcess == IntPtr.Zero)
                return null;

            return proOpened;
        }

        public static SystemProcess Create(string strExecutablePath, string strArguments, string strWorkingDir = null)
            => Create(strExecutablePath, $"\"{strExecutablePath}\" {strArguments}", IntPtr.Zero, IntPtr.Zero, 
                false, Interop.Constants.CREATE_SUSPENDED, null, strWorkingDir, 
                new Interop.StartupInfo() { Size = Marshal.SizeOf<Interop.StartupInfo>() });

        private static SystemProcess Create(string strAppName, string strCmdLine, IntPtr pProcessAttr, IntPtr pThreadAttr,
            bool bInheritHandles, uint flagsCreation, [In] byte[] arrEnvironment, string strWorkingDir, in Interop.StartupInfo infStartup)
        {
            Interop.ProcessInformation infNewProcess = new Interop.ProcessInformation();
            SystemProcess proCreated = new SystemProcess();

            if (string.IsNullOrWhiteSpace(strWorkingDir))
                strWorkingDir = null;

            try {
                if (!Interop.Functions.CreateProcess(strAppName, strCmdLine, pProcessAttr, pThreadAttr, bInheritHandles, flagsCreation,
                    arrEnvironment, strWorkingDir, infStartup, out infNewProcess))
                    throw new System.ComponentModel.Win32Exception();
            } finally {
                if (infNewProcess.ProcessHandle != IntPtr.Zero) {
                    proCreated.Handle = infNewProcess.ProcessHandle;
                    Interop.Functions.CloseHandle(infNewProcess.ThreadHandle);
                }
            }

            return proCreated;
        }

        private static readonly IntPtr CURRENT_PROCESS = (IntPtr)(-1);

        private const int STILL_ACTIVE = 259;
        private const uint WAIT_OBJECT_0 = 0;
        private const uint WAIT_TIMEOUT = 0x0102;
        private const uint WAIT_FAILED = 0xFFFF_FFFFU;
        private const uint WAIT_ABANDONED = 0x0080;

        public bool HasExited {
            get {
                switch (Interop.Functions.WaitForSingleObject(Handle, 0)) {
                    case WAIT_OBJECT_0:
                        return true;

                    case WAIT_TIMEOUT:
                        return false;

                    default:
                        throw new System.ComponentModel.Win32Exception();
                }
            }
        }

        public int ExitCode {
            get {
                if (!Interop.Functions.GetExitCodeProcess(Handle, out int nExitCode))
                    throw new System.ComponentModel.Win32Exception();

                if ((nExitCode == STILL_ACTIVE) && !HasExited)
                    throw new InvalidOperationException("The process is still running");

                return nExitCode;
            }
        }

        public string FilePath {
            get {
                char[] arrBuffer = new char[4096];
                int nBufferSize = arrBuffer.Length;

                if (!Interop.Functions.QueryFullProcessImageName(Handle, false, arrBuffer, ref nBufferSize))
                    throw new System.ComponentModel.Win32Exception();

                return new string(arrBuffer, 0, nBufferSize);
            }
        }

        public int ID {
            get {
                int nID = Interop.Functions.GetProcessId(Handle);
                if (nID == 0)
                    throw new System.ComponentModel.Win32Exception();
                return nID;
            }
        }

        public void Terminate(int nExitCode) {
            if (!Interop.Functions.TerminateProcess(Handle, nExitCode))
                throw new System.ComponentModel.Win32Exception();
        }

        private static void CheckNTStatus(int nStatus) {
            if (nStatus < 0)
                Marshal.ThrowExceptionForHR(nStatus | Interop.Constants.HRESULT_NTSTATUS_BIT);
        }

        public void Suspend()
            => CheckNTStatus(Interop.Functions.NtSuspendProcess(Handle));

        public void Resume()
            => CheckNTStatus(Interop.Functions.NtResumeProcess(Handle));

        protected virtual void Dispose(bool bDisposing) {
            IntPtr hProcess = Interlocked.Exchange(ref _hProcess, IntPtr.Zero);

            if ((hProcess != IntPtr.Zero) && (hProcess != (IntPtr)(-1)))
                Interop.Functions.CloseHandle(_hProcess);
        }

        ~SystemProcess()
            => Dispose(false);

        public void Dispose() {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
