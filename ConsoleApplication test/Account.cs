using System;
using System.IO;
using System.Collections.Generic;



//namespace System
//{
    namespace Intro
    {
        class Account
        {
            public List<string[]> ownedList = new List<string[]>(10);
            public /*List<string[]>*/ void accountMain()//int idUser)//, List<string> MoneysArray, List<string> OwnershipArray)
            {

                //Data data1 = new Data();
                //data1.dataMain();
                //using data1 = Global.data1();
                //Global.data1 data1 = new Global.data1;
                int idUser = Global.login1.idUser;
                int x = 0;
                
                string[] l = Global.data1.OwnershipList[idUser].Split(';');
                string[] error = new string[] { "error", "error", "error", "error", "error", "error", "error" };
                while (l.Length != (x))
                {
                    switch (l[x][0])
                    {
                        case 'A':
                            ownedList.Insert(x, (Global.data1.PistolsList[(Convert.ToInt32(l[x].Substring(1), 10) -1)]));// ownedList[x] = (Global.data1.PistolsList[(Convert.ToInt32(l[x].Substring(1), 10) -1)]);
                            break;
                        case 'B':
                            ownedList.Insert(x, (Global.data1.SmgsList[(Convert.ToInt32(l[x].Substring(1), 10) -1)]));
                            break;
                        case 'C':
                            ownedList.Insert(x, (Global.data1.RiflesList[(Convert.ToInt32(l[x].Substring(1), 10) -1)]));
                            break;
                        default:
                            ownedList[x] = error;
                            break;
                    }
                    x++;
                }
                //string s = "";
                //foreach (string z in l) s += z + "; ";
                //s = s.Substring(0, s.Length - 2);

                //Console.WriteLine("Welcome, {0}.\n\rYou have {1} $.\n\rYou own {2}.", cUser, Global.data1.MoneysList[idUser], s/*OwnershipArray[idUser]*/);//Показывает устаревшие данные, инициализированные ещё в начале.


                return;// ownedList;
            }
        }
    }
//}