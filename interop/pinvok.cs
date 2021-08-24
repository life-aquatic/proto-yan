using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace interop
{
    static class pinvok
    {
        
       
        [DllImport("user32.dll")]
        public static extern int MessageBox(IntPtr hWnd, string text, string caption, int type);

        [DllImport("kernel32.dll")]
        public static extern void GetSystemTime(out SystemTime t);

    }
}



