﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamblingProblem
{
    static class Program
    {
        internal static Properties.Settings Settings
        {
            get => default(Properties.Settings);
            set
            {
            }
        }

        internal static Properties.Resources Resources
        {
            get => default(Properties.Resources);
            set
            {
            }
        }

        public static Form1 Form1
        {
            get => default(Form1);
            set
            {
            }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Form1 window = new Form1();
            Application.Run(new Form1());
        }
    }
}
