using System;
using System.IO;
using System.Collections.Generic;

//namespace System
//{
    namespace Intro
    {
        public class LoginLogout
        {
            public string currentUser = "";
            public int idUser = -1;
            public bool isLoggedIn = false;
            public void logIn1(string lIn, string pIn)
            {
                //Data data1 = new Data();
                //data1.dataMain();
                int x = 0;
                while (Global.data1.LoginsList.Count != x)
                {
                    if (Global.data1.LoginsList[x] == lIn)
                    {
                        if (Global.data1.PasswordsList[x] == pIn)
                        {
                            isLoggedIn = true;
                            currentUser = Global.data1.LoginsList[x];
                            idUser = x;
                        }
                    }
                    x++;
                }
            }
            public void logOut()
            {
                isLoggedIn = false;
            }
        }
    }
//}