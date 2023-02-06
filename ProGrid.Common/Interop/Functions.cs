using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProGrid.Common.Interop {
    public static class Functions {
        [DllImport("kernel32", SetLastError = true)]
        public static extern bool CreateProcess(string strAppName, string strCmdLine, IntPtr pProcessAttr, IntPtr pThreadAttr,
            bool bInheritHandles, uint flagsCreation, [In] byte[] arrEnvironment, string strWorkingDir, in StartupInfo infStartup,
            out ProcessInformation infProcess);

        [DllImport("user32", SetLastError = true)]
        public static extern bool PostMessage(IntPtr hWndTarget, uint nMessage, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32")]
        public static extern bool CloseHandle(IntPtr hObject);

        [DllImport("kernel32", SetLastError = true)]
        public static extern IntPtr OpenProcess(ProcessAccess flagsAccess, bool bInheritHandle, int nProcessID);

        [DllImport("kernel32", SetLastError = true)]
        public static extern bool GetExitCodeProcess(IntPtr hProcess, out int nExitCode);

        [DllImport("kernel32", SetLastError = true)]
        public static extern uint WaitForSingleObject(IntPtr hProcess, int nTimeoutMillis);

        [DllImport("kernel32", SetLastError = true)]
        public static extern bool QueryFullProcessImageName(IntPtr hProcess, bool bUseNTFormat, [Out] char[] arrNameBuffer,
            ref int nBufferSize);

        [DllImport("kernel32", SetLastError = true)]
        public static extern bool DuplicateHandle(IntPtr hSourceProcess, IntPtr hOriginal, IntPtr hDestProcess,
            out IntPtr hDuplicated, uint flagsAccess, bool bInheritHandle, HandleDuplicationFlags flagsDuplication);

        [DllImport("kernel32", SetLastError = true)]
        public static extern int GetProcessId(IntPtr hProcess);

        [DllImport("kernel32", SetLastError = true)]
        public static extern bool TerminateProcess(IntPtr hProcess, int nExitCode);

        [DllImport("kernel32", SetLastError = true)]
        public static extern IntPtr CreateToolhelp32Snapshot(ToolhelpSnapshotFlags flags, int nProcessID);

        [DllImport("kernel32", SetLastError = true, EntryPoint = "Process32FirstW", CharSet = CharSet.Unicode)]
        public static extern bool Process32First_Managed(IntPtr hSnapshot, ref ProcessEntry32_Managed entry);

        [DllImport("kernel32", SetLastError = true, EntryPoint = "Process32FirstW", CharSet = CharSet.Unicode)]
        public static extern bool Process32First_Unmanaged(IntPtr hSnapshot, ref ProcessEntry32_Unmanaged entry);

        [DllImport("kernel32", SetLastError = true, EntryPoint = "Process32NextW", CharSet = CharSet.Unicode)]
        public static extern bool Process32Next_Managed(IntPtr hSnapshot, ref ProcessEntry32_Managed entry);

        [DllImport("kernel32", SetLastError = true, EntryPoint = "Process32NextW", CharSet = CharSet.Unicode)]
        public static extern bool Process32Next_Unmanaged(IntPtr hSnapshot, ref ProcessEntry32_Unmanaged entry);

        [DllImport("ntdll")]
        public static extern int NtSuspendProcess(IntPtr hProcess);

        [DllImport("ntdll")]
        public static extern int NtResumeProcess(IntPtr hProcess);
    }
}
