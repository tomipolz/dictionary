﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace dictionaryConsole
{
    class Program
    {
        // console visibility copied from:
        // http://stackoverflow.com/questions/3571627/show-hide-the-console-window-of-a-c-sharp-console-application
        //==================================================================================================================
        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        const int SW_HIDE = 0;
        const int SW_SHOW = 5;
        //==================================================================================================================

        [STAThread]
        static void Main(string[] args)
        {
            //==============================================================================================================
            var handle = GetConsoleWindow();
            //==============================================================================================================

            // formy lepiej wygladaja
            Application.EnableVisualStyles();

            //ShowWindow(handle, SW_HIDE);

            // create new form
            Application.Run(new Dictionary());
            //ShowWindow(handle, SW_SHOW);

            // exiting console
            Console.WriteLine("Goodbye");
        }
    }
}
