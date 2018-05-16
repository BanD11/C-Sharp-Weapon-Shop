using System;
using System.IO;
using System.Collections.Generic;
//using "data.cs"
//namespace System
//{
    //А помимо void используется int, string и т.д.
    //Ключевое слово ref! Решение проблемы с вызовом Data три раза. А ещё есть out. private static void Add(int i, ref int result)
    namespace Intro
    {
        class Help
        {
            public void helpText()
            {
                System.Console.WriteLine(
                @"help - show this screen
login - go to login/logout screen
account - show your account
shop - go to screen of BBC Weapon Shop
exit - exit BBC Wepon Shop");
            }
        }

        


        
        class Welcome
        {
            static void OldMain()
            {
                Help help1 = new Help();
                
                Account account1 = new Account();
                LoginLogout login1 = new LoginLogout();
                Shop shop1 = new Shop();
                Data data1 = new Data();
                string hello1 = "Hello. Welcome to the MVS Console.";
                string enterCom = "Enter your command, or enter HELP for list of command.";
                string inputerror = "There is no such command.";
                string timeis = "Current date and time is " + DateTime.Now;
                int cbcolor = 0;
                int cfcolor = 2;
                Console.BackgroundColor = (ConsoleColor)(cbcolor); //Значения из перечислений по номеру значения вызаваются так.
                Console.ForegroundColor = (ConsoleColor)(cfcolor);
                Console.WriteLine(hello1);
                Console.WriteLine(enterCom);
                Console.WriteLine(timeis);
                Console.Beep(432, 1000);//Частота (герцы), длительность (милисекунды).



                string s;


                //Form1 form1 = new Form1();
                //form1.Form01();
                data1.dataMain();
                //Console.WriteLine(data1.PistolsList[23]);
                while (true)
                {
                    s = Console.ReadLine();
                    switch (s)
                    {
                        case "help":
                            help1.helpText();
                            break;
                        case "login":
                            //login1.logIn1(data1.LoginsList, data1.PasswordsList);
                            break;
                        case "test":
                            //char k = Console.ReadKey(true).KeyChar; //Если не true - в консоли будет печататься введённый символ.
                                //if (k.Equals('l') == true) Console.WriteLine("Left");
                            data1.Buing(/*int*/0, /*string*/ "A21", 436);
                            
                            break;
                        case "account":
                            //Console.WriteLine(login1.currentUser);
                            //account1.accountMain(login1.currentUser, login1.idUser);//, data1.MoneysList, data1.OwnershipList);
                            break;
                        //case "exit":
                            //exit1.exitMain(s);
                            //break;
                        case "shop":
                            shop1.shopMain(login1.isLoggedIn, login1.idUser);
                            break;
                        default:
                            Console.WriteLine(inputerror);
                            break;
                    }
                }
            }
        }
    }
//}