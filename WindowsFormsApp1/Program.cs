﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Console.WriteLine("Dakovic promjena");
            Console.WriteLine("Ovo je moja promjena");
            Console.WriteLine("Ovo je DUMP internship");
            Console.WriteLine("Ovo je promjena u branchu");
            Console.WriteLine("Linija za rebase");
            Console.WriteLine("Linija za rebase 2");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
