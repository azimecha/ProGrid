using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProGrid.Common.Interop {
    [Flags]
    public enum StartupInfoFlags : uint {
        ForceOnFeedback = 0x0000_0040,
        ForceOffFeedback = 0x0000_0080,
        PreventPinning = 0x0000_2000,
        FullscreenConsole = 0x0000_0020,
        TitleIsAppUserModelID = 0x0000_1000,
        TitleIsShortcutPath = 0x0000_0800,
        UntrustedCommandLine = 0x0000_8000,
        UseConsoleSize = 0x0000_0008,
        UseConsoleColor = 0x0000_0010,
        UseHotkey = 0x0000_0200,
        UseWindowPosition = 0x0000_0004,
        UseWindowMode = 0x0000_0001,
        UseWindowSize = 0x0000_0002,
        UseProvidedStdHandles = 0x0000_0100
    }

    public enum WindowMode : ushort {
        Hide = 0,
        ShowNormal = 1,
        Normal = 1,
        ShowMinimized = 2,
        ShowMaximized = 3,
        ShowNormalWithoutActivation = 4,
        Show = 5,
        Minimize = 6,
        ShowMinimizedWithoutActivation = 7,
        ShowWithoutActivation = 8,
        Restore = 9,
        UseDefault = 10,
        ForceMinimize = 11
    }

    [Flags]
    public enum ProcessAccess : uint {
        CreateChild = 0x0080,
        CreateThread = 0x0002,
        DuplicateHandle = 0x0040,
        QueryAllInformation = 0x0400,
        QueryLimitedInformation = 0x1000,
        SetInformation = 0x0200,
        SetMemoryQuota = 0x0100,
        SuspendResume = 0x0800,
        Terminate = 0x0001,
        MemoryOperations = 0x0008,
        ReadMemory = 0x0010,
        WriteMemory = 0x0020,

        Synchronize = 0x0010_0000,
        StandardRights = 0x000F_0000,

        AllAccess = Synchronize | StandardRights | 0xFFFF
    }

    [Flags]
    public enum HandleDuplicationFlags : uint {
        CloseOriginal = 1,
        SameAccess = 2
    }

    [Flags]
    public enum ToolhelpSnapshotFlags : uint {
        SnapHeaps = 0x0001,
        SnapProcesses = 0x0002,
        SnapThreads = 0x0004,
        SnapModules = 0x0008,
        SnapModules32From64 = 0x0010,
        Inheritable = 0x8000_0000U
    }
}
