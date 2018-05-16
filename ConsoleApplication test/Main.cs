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
                //Form1 form1 = new Form1();
                //form1.Form01();
                //Form2 form2= new Form2();
                //form2.Activate;
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
                
            }
        }

    }
