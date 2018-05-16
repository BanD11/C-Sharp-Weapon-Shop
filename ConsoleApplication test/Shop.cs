using System;
using System.IO;
using System.Collections.Generic;



//namespace System
//{
    namespace Intro
    {
        class Shop
        {
            class ShopShowWeapons
            {
                public void SSWMain(List<string[]> targetList, bool lIn, string cat, int idUser)
                {
                    Data data1 = new Data();
                    int x = 0;
                    while (true)
                    {
                        Console.WriteLine("n - show next 10, p - show previous 10, b - buy item, e - go back");

                        while (x % 10 != 9)
                        {
                            Console.WriteLine((targetList[x])[0] + " " + (targetList[x])[1]);
                            x++;
                        }
                        char k = Console.ReadKey(true).KeyChar;


                        if (k.Equals('e')) { Console.WriteLine("Going back to main menu..."); return; }
                        //if (k.Equals('b'))
                        if (k == 'b')
                        {
                            if (lIn == false) { Console.WriteLine("You can't buy weapons, you're not logged in"); return; }
                            Console.WriteLine("Enter ID of gun you want to buy");
                            //string s = Console.ReadLine();
                            //int id = Convert.ToInt32(s, 10);
                            int id = Convert.ToInt32(Console.ReadLine(), 10);
                            if (id > targetList.Count) { Console.WriteLine("This ID doesn't exist"); return; }


                            Console.WriteLine("this will cost you {0}, wanna buy? y/n", targetList[id + 1][6]);
                            //s = Console.ReadLine();
                            //if(s=="y")
                            if (Console.ReadLine() == "y")
                            {
                                int price = Convert.ToInt32(targetList[id + 1][6], 10);
                                string item = ";" + cat + id;
                                data1.dataMain();//И опять та же хрень. Что-то тут не так.
                                data1.Buing(/*int*/idUser, /*string*/ item, price);
                            }
                        }
                        if (k.Equals('n')) x++;
                        else
                            if (k.Equals('p'))
                                if (x >= 19)
                                    x -= 19;
                    }
                    //Console.WriteLine(targetList[x]);
                }
            }
            public void shopMain(bool isLoggedIn, int idUser)
            {
                //Console.WriteLine("Not supported yet.");
                Data data2 = new Data();
                Console.WriteLine("Welcome to the BBC Weapon Shop.");
                if (!isLoggedIn)
                {
                    Console.WriteLine("Attention! You not logged in, so you can only view our weapons.");
                }
                ShopShowWeapons ShowWeapons1 = new ShopShowWeapons();
                //ShowWeapons1.SSWMain(PistolsList);
                data2.dataMain();  //Тут он заново загружает все данные из файлов. Не очень. Найти альтернативу, либо просто передавать данные из Welcome, где они уже загружены.
                //Console.WriteLine(data2.PistolsList[0]);
                Console.WriteLine(@"Choose one of categories:
1 - Pistols
2 - Sub-machine guns
3 - Assault rifles
e - go back");
                string s;
                string cat;
                s = Console.ReadLine();
                switch (s)
                {
                    case "1":
                        cat = "A";
                        ShowWeapons1.SSWMain(data2.PistolsList, isLoggedIn, cat, idUser);
                        break;
                    case "2":
                        cat = "B";
                        ShowWeapons1.SSWMain(data2.SmgsList, isLoggedIn, cat, idUser);
                        break;
                    case "3":
                        cat = "C";
                        ShowWeapons1.SSWMain(data2.RiflesList, isLoggedIn, cat, idUser);
                        break;
                    case "e":
                        return;
                }



                return;
            }
        }
    }
//}