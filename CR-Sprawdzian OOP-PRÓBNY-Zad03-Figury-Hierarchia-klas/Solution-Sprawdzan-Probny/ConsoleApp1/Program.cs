using System;
using FiguryLib;


namespace Program
{
    class Program
    {
        static void Test00()
        {

            // klasa Okrag, modyfikacje
            Okrag o;
            try
            {
                o = new Okrag(null, -1);
                Console.WriteLine(o);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            o = new Okrag(new Punkt(1, 1), 1);
            Console.WriteLine(o);
            o.Srodek = new Punkt(0, 0);
            o.Promien = 5;
            o.Rysuj();
            o.Promien = -1;
            o.Rysuj();
        }

        static void Test01()
        {
            // klasa Kolo, modyfikacje
            Kolo k;
            try
            {
                k = new Kolo(null, -1);
                Console.WriteLine(k);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            k = new Kolo(new Punkt(1, 1), 1);
            Console.WriteLine(k);
            k.Srodek = new Punkt(0, 0);
            k.Promien = 5;
            k.Rysuj();
            k.Promien = -1;
            k.Rysuj();
        }

        static void Test02()
        {

            // klasa Okrag, dziedziczenie z Figura,
            // implementacja IMierzalna1D
            var o = new Okrag();
            Console.WriteLine(o is FiguryLib.Figura);
            Console.WriteLine(o is FiguryLib.IMierzalna1D);
        }

        static void Test03()
        {
            // klasa Okrag, konstruktor domyślny
            Okrag o = new Okrag();
            Console.WriteLine(o);
            o.Rysuj();

        }

        static void Test04()
        {
            // klasa Okrag, konstruktor dwuargumentowy
            Okrag o = new Okrag(new Punkt(1, 2), 2);
            Console.WriteLine(o);
            o.Rysuj();

        }

        static void Test05()
        {
            // klasa Okrag, modyfikacje
            Okrag o;
            try
            {
                o = new Okrag(null, -1);
                Console.WriteLine(o);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            o = new Okrag(new Punkt(1, 1), 1);
            Console.WriteLine(o);
            o.Srodek = new Punkt(0, 0);
            o.Promien = 5;
            o.Rysuj();
            o.Promien = -1;
            o.Rysuj();

        }

        static void Test06()
        {

            // klasa Kolo, dziedziczenie z Figura,
            // implementacja IMierzalna2D
            var k = new Kolo();
            Console.WriteLine(k is FiguryLib.Figura);
            Console.WriteLine(k is FiguryLib.IMierzalna2D);
        }

        static void Test07()
        {

            // klasa Kolo, konstruktor domyślny
            Kolo k = new Kolo();
            Console.WriteLine(k);
            k.Rysuj();

        }

        static void Test08()
        {


            // klasa Kolo, konstruktor dwuargumentowy
            Kolo k = new Kolo(new Punkt(1, 2), 2);
            Console.WriteLine(k);
            k.Rysuj();
        }

        static void Test09()
        {
            // klasa Kolo, modyfikacje
            Kolo k;
            try
            {
                k = new Kolo(null, -1);
                Console.WriteLine(k);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            k = new Kolo(new Punkt(1, 1), 1);
            Console.WriteLine(k);
            k.Srodek = new Punkt(0, 0);
            k.Promien = 5;
            k.Rysuj();
            k.Promien = -1;
            k.Rysuj();

        }

        static void Test10()
        {
            // Ekran, sumaryczna długość
            Ekran ekran = new Ekran();
            ekran.Dodaj(new Punkt(1, 2));
            ekran.Dodaj(new Odcinek(new Punkt(), new Punkt(1, 1)));
            ekran.Dodaj(new Okrag(new Punkt(1, 1), 2));
            ekran.Dodaj(new Kolo(new Punkt(-1, -1), 3));
            Console.WriteLine("sumaryczna dlugosc = " + ekran.SumarycznaDlugosc());

        }

        static void Test11()
        {
            // Ekran, sumaryczne pole
            Ekran ekran = new Ekran();
            ekran.Dodaj(new Punkt(1, 2));
            ekran.Dodaj(new Odcinek(new Punkt(), new Punkt(1, 1)));
            ekran.Dodaj(new Okrag(new Punkt(1, 1), 2));
            ekran.Dodaj(new Kolo(new Punkt(-1, -1), 3));
            Console.WriteLine("sumaryczne pole= " + ekran.SumarycznePole());

        }





        public static void Main(string[] args)
        {
            Test00();
            Test01();
            Test02();
            Test03();
            Test04();
            Test05();
            Test06();
            Test07();
            Test08();
            Test09();
            Test10();
            Test11();

        }
    }
}