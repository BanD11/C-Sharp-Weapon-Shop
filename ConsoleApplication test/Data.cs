using System;
using System.IO;
using System.Collections.Generic;



//namespace System
//{
    namespace Intro
    {
        public class Data
        {

            public List<string> LoginsList = new List<string>();
            public List<string> PasswordsList = new List<string>();
            public List<string> OwnershipList = new List<string>();
            public List<string> MoneysList = new List<string>();

            public List<string[]> PistolsList = new List<string[]>();
            public List<string[]> SmgsList = new List<string[]>();
            public List<string[]> RiflesList = new List<string[]>();


            class FileToList
            {
                public void FTLMain(string targetPath, List<string> targetList)
                {
                    int x = 0;



                    /*using (StreamReader sr = File.OpenText(targetPath))
                    {
                        string s = "";
                        x = 0;
                        while ((s = sr.ReadLine()) != null)
                        {
                            x++;
                        }
                        Console.WriteLine(x);
                        //Array.Resize(ref targetArray, x);
                        //Console.WriteLine(targetArray.Length);
                    }
                    Array.Resize(ref targetArray, x);
                    Console.WriteLine(targetArray.Length);*/


                    using (StreamReader sr = File.OpenText(targetPath))
                    {
                        string s = "";
                        x = 0;
                        /*while ((s = sr.ReadLine()) != null)
                        {
                            x++;
                        }

                        Array.Resize (ref targetArray, x);
                        Console.WriteLine(targetArray.Length);

                        //StreamReader sr2 = File.OpenText(targetPath);
                        //string s = "";
                        s = "";
                        x = 0;*/
                        while ((s = sr.ReadLine()) != null)
                        {
                            targetList.Insert(x, s);// = s;
                            x++;
                        }
                    }
                }





                public void FTLWeapons(string targetPath, List<string[]> targetList)
                {
                    int x = 0;
                    using (StreamReader sr = File.OpenText(targetPath))
                    {
                        string s = "";
                        x = 0;
                        //char c;
                        while ((s = sr.ReadLine()) != null)
                        {
                            string[] l = s.Split(';');
                            //while ((c = sr.Read()) != ';')

                            targetList.Insert(x, l);
                            x++;
                        }
                    }
                }








            }

            public void Buing(int idUser, string item, int price)
            {
                //Console.WriteLine(MoneysList[idUser]);
                MoneysList[idUser] = Convert.ToString(Convert.ToInt32(MoneysList[idUser], 10) - price);
                OwnershipList[idUser] = OwnershipList[idUser] + item;
                //Console.WriteLine(MoneysList[idUser]);
                using (StreamWriter sw = new StreamWriter("data/moneys.txt"))
                {
                    foreach (string line in MoneysList)
                        sw.WriteLine(line);
                }

                using (StreamWriter sw = new StreamWriter("data/ownership.txt"))
                {
                    foreach (string line in OwnershipList)
                        sw.WriteLine(line);
                }

            }

            public void dataMain()
            {
                string loginsPath = "data/logins.txt";
                string passwordsPath = "data/passwords.txt";
                string ownershipPath = "data/ownership.txt";
                string moneysPath = "data/moneys.txt";

                string pistolsPath = "data/weapons/pistols.csv";
                string smgsPath = "data/weapons/smgs.csv";
                string riflesPath = "data/weapons/rifles.csv";

                FileToList ftl1 = new FileToList();

                ftl1.FTLMain(loginsPath, LoginsList);
                ftl1.FTLMain(passwordsPath, PasswordsList);
                ftl1.FTLMain(ownershipPath, OwnershipList);
                ftl1.FTLMain(moneysPath, MoneysList);

                ftl1.FTLWeapons(pistolsPath, PistolsList);
                ftl1.FTLWeapons(smgsPath, SmgsList);
                ftl1.FTLWeapons(riflesPath, RiflesList);
            }

        }
    }
//}