using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace P_As_AutoClicker
{
    public class MouseHandler
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetCursorPos(out Point lpPoint);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;

        public static void DoLeftClick(Point pos)
        {
            // Move the cursor to the desired position
            Cursor.Position = new Point(pos.X, pos.Y);

            // Perform the left mouse click
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, (uint)pos.X, (uint)pos.Y, 0, 0);
        }

        public static void PickCursorPosition(out Point newPos)
        {
            newPos = Point.Empty;
            CursorLocationPicker locationPicker = new CursorLocationPicker();
            Point capturedPos = newPos;
            locationPicker.FormClosing += (s, args) => { capturedPos = Cursor.Position; };
            locationPicker.ShowDialog();
            newPos = capturedPos;
        }

        public static Point GetCursorPos() { return Cursor.Position; }
    }
}
