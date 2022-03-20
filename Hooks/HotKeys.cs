using System;

namespace Hooks
{
    class HotKeys
    {
        readonly int _id          = 0;
        readonly int _key         = 0;
        readonly int _modifiers   = 0;
        readonly IntPtr _hWnd     = IntPtr.Zero;

        public HotKeys(IntPtr handle, int modifiers, int key)
        {
            _hWnd       = handle;
            _modifiers  = modifiers;
            _key        = key;
            _id         = _key ^ _modifiers ^ (int)_hWnd;
        }

        public bool Register()
        {
            return NativeMethods.RegisterHotKey(_hWnd, _id, _modifiers, _key);
        }

        public bool Unregister()
        {
            return NativeMethods.UnregisterHotKey(_hWnd, _id);
        }
    }
}