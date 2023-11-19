﻿using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AutoClicker.Components
{

    class MouseCoords
    {

        public int positionX = 0;
        public int positionY = 0;


        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool SetCursorPos(int x, int y);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);
        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;
        //This simulates a left mouse click
        public static void LeftMouseClick(int xpos, int ypos)
        {
            SetCursorPos(xpos, ypos);
            mouse_event(MOUSEEVENTF_LEFTDOWN, xpos, ypos, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, xpos, ypos, 0, 0);
        }


        public void clickByCoords()
        {
            LeftMouseClick(positionX, positionY);
        }

        public void writeCurrentCoords()
        {
            positionX = Cursor.Position.X;
            positionY = Cursor.Position.Y;
        }
    }
}
