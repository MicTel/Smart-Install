﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_install
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        ///[STAThreadAttribute] 
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new UserMenu());

        }
    }
}
