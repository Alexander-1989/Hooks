using System;
using System.Runtime.InteropServices;

namespace Hooks
{
    static class NativeMethods
    {
        [DllImport("user32.dll", EntryPoint = "RegisterHotKey")]
        internal static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

        [DllImport("user32.dll", EntryPoint = "UnregisterHotKey")]
        internal static extern bool UnregisterHotKey(IntPtr hWnd, int id);
    }
}
