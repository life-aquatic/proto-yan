using System;
using System.Runtime.InteropServices;

namespace interop
{
    [StructLayout(LayoutKind.Sequential)]
    struct SystemTime
    {
        public ushort Year;
        public ushort Month;
        public ushort DayOfWeek;
        public ushort Day;
        public ushort Hour;
        public ushort Minute;
        public ushort Second;
        public ushort Milliseconds;
    }
    class Program
    {
        static void Main(string[] args)
        {
            SystemTime t = new SystemTime();
            pinvok.GetSystemTime(out t);
            Console.WriteLine(t.Year);

            //pinvok.MessageBox(IntPtr.Zero, "Please do not press this again.", "Attention", 0);



            unsafe
            {
                EnumWindows(&PrintWindow, IntPtr.Zero);
                [DllImport("user32.dll")]
                static extern int EnumWindows(
                delegate*<IntPtr, IntPtr, bool> hWnd, IntPtr lParam);
                static bool PrintWindow(IntPtr hWnd, IntPtr lParam)
                {
                    Console.WriteLine(hWnd.ToInt64());
                    return true;
                }
            }
        }
    }
}
