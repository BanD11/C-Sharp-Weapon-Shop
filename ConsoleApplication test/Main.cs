using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;




    namespace Intro
    {
        class MainClass
        {
            [STAThread]
            static void Main(string[] args)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1()); 
            }
        }

    }
