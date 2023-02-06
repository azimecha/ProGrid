using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProGrid.Common.Interop {
    [StructLayout(LayoutKind.Sequential)]
    public struct StartupInfo {
        public int Size;
        private string _strReserved;
        public string DesktopName;
        public string WindowTitle;
        public int WindowXPos;
        public int WindowYPos;
        public int WindowWidth;
        public int WindowHeight;
        public int ConsoleWidth;
        public int ConsoleHeight;
        public uint ConsoleFillColor;
        public StartupInfoFlags Flags;
        public WindowMode DefaultShowWindowMode;
        private uint _nReserved;
        private IntPtr _pReserved;
        public IntPtr StandardInputHandle;
        public IntPtr StandardOutpuHandle;
        public IntPtr StandardErrorHandle;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ProcessInformation {
        public IntPtr ProcessHandle;
        public IntPtr ThreadHandle;
        public uint ProcessID;
        public uint ThreadID;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CopyDataStruct {
        public IntPtr DataType;
        public uint DataSize;
        public IntPtr DataPointer;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct ProcessEntry32_Unmanaged {
        public int Size;
        private int _nIgnore1;
        public int ProcessID;
        private int _nIgnore2;
        private int _nIgnore3;
        public int ThreadCount;
        public int ParentProcessID;
        public int BasePriority;
        private int _nIgnore4;
        public fixed char ExecutablePath[Constants.MAX_PATH];
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct ProcessEntry32_Managed {
        public int Size;
        private int _nIgnore1; // cntUsage
        public int ProcessID;
        private int _nIgnore2; // th32DefaultHeapID
        private int _nIgnore3; // th32ModuleID
        public int ThreadCount;
        public int ParentProcessID;
        public int BasePriority;
        private int _nIgnore4; // dwFlags
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constants.MAX_PATH)]
        public string ExecutablePath;
    }
}
