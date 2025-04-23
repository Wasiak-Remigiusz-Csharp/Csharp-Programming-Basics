using System;
using System.Collections.Generic;
using System.Numerics;


namespace ConsoleApp1
{
    class Program
    {



        static void Test00()
        {
            // Test: poprawne tworzenie obiektu Student, dane poprawne
            //       typowe czynności poprawne
            Student p = new Student(login: "molenda",
                                    haslo: "128934");
            //p.ZarejestrujWynik(22);
            //p.ZarejestrujWynik(41);
            Console.WriteLine(p);
            p.Login = "kmol9";
            //p.ZmienHaslo(stare: "128934",
            //             nowe: "001122");
            //Console.WriteLine(p.ProbujZarejestrowacWynik(32));
            Console.WriteLine(p);
        }


        //static void Test01()
        //{
        //    // Test: poprawne tworzenie obiektu Student, dane poprawne
        //    //       typowe czynności poprawne
        //    Student p = new Student(login: "molenda",
        //                            haslo: "128934");
        //    p.ZarejestrujWynik(22);
        //    p.ZarejestrujWynik(41);
        //    Console.WriteLine(p);
        //    p.Login = "kmol9";
        //    p.ZmienHaslo(stare: "128934",
        //                 nowe: "001122");
        //    Console.WriteLine(p.ProbujZarejestrowacWynik(32));
        //    Console.WriteLine(p);
        //}



        public static void Main()
        {

            // Tests
            Test00();
            //Test01();




        }
    }

}

