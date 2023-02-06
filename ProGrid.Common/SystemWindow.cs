using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ProGrid.Common {
    public struct SystemWindow {
        public readonly IntPtr Handle;

        public SystemWindow(IntPtr hWnd) {
            Handle = hWnd;
        }

        private const uint WM_COPYDATA = 0x004A;

        public void PostMessage(uint nMessage, IntPtr wParam, IntPtr lParam) {
            if (!Interop.Functions.PostMessage(Handle, nMessage, wParam, lParam))
                throw new System.ComponentModel.Win32Exception();
        }

        public unsafe void PostData(int nDataType, ReadOnlySpan<byte> spanData, SystemWindow? wndSender = null) {
            fixed (byte* pData = spanData) {
                Interop.CopyDataStruct cds = new Interop.CopyDataStruct() {
                    DataType = (IntPtr)nDataType,
                    DataSize = (uint)spanData.Length,
                    DataPointer = (IntPtr)pData
                };

                PostMessage(WM_COPYDATA, wndSender?.Handle ?? IntPtr.Zero, (IntPtr)(&cds));
            }
        }

        public void PostCLRObject(int nDataType, object obj, SystemWindow? wndSender = null) {
            BinaryFormatter bf = new BinaryFormatter();
            using (System.IO.MemoryStream stm = new System.IO.MemoryStream()) {
                bf.Serialize(stm, obj);
                PostData(nDataType, stm.ToArray(), wndSender);
            }
        }

        public unsafe void PostUnmanagedStruct<T>(int nDataType, T val, SystemWindow? wndSender = null) where T : unmanaged
            => PostData(nDataType, new ReadOnlySpan<byte>(&val, sizeof(T)), wndSender);
    }
}
