using System;
using StrukturaStos;


namespace Program
{
    class Program
    {
        static void Test00()
        {
            var s = new Stos<string>();

            s.Push("Ala");
            s.Push("ma");
            s.Push("kota");
            //s.

            foreach (var element in s.ToArray())
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();


            while (!s.IsEmpty)
            {
                var element = s.Pop();
                Console.WriteLine(element);
            }
        }

        static void Test01()
        {
            var s = new Stos<string>();
            s.Push("aaa");
            s.Push("bbb");
            s.Push("ccc");
            foreach (var x in s.ToArray())
            {
                Console.WriteLine(x);
            }
            Console.WriteLine($"na szczycie jest: {s.Peek}");
            Console.WriteLine($"liczba elementów na stosie: {s.Count}");
            while (!s.IsEmpty)
            {
                Console.WriteLine($"zdejmuje: {s.Pop()}");
            }
            if (s.IsEmpty)
                Console.WriteLine("stos jest pusty");
        }

        static void Test02()
        {
            /* weryfikacja, czy implementowany jest interfejs IStos
*/
            var stos = new Stos<char>();
            if (stos is StrukturaStos.IStos<char>)
                Console.WriteLine("Stos<T> implemented");
            else
                Console.WriteLine("Stos<T> not implemented");
        }

        static void Test03()
        {
            /* Po utworzeniu stos jest pusty
            s.create ====> s.IsEmpty==true */
            var s = new Stos<string>();
            Console.WriteLine(s.IsEmpty);
        }

        static void Test04()
        {
            /* Dodanie elementu powoduje, że stos nie jest pusty
            s.create.Push(e) ====> s.IsEmpty==false */
            var s = new Stos<int>();
            s.Push(5);
            Console.WriteLine(!s.IsEmpty);
        }

        static void Test05()
        {
            /* Push, a potem Pop - stos się nie zmienia
            s.Pop( s.Push(e) ) == s */
            var s = new Stos<int>();
            s.Push(1);
            s.Push(2);
            int[] tabPrzed = s.ToArray();
            s.Push(3);
            s.Pop();
            int[] tabPo = s.ToArray();
            Console.WriteLine(tabPrzed.SequenceEqual(tabPo));
        }


        static void Test06()
        {
            /* Peek zwraca ostatnio wstawiony element
            s.Peek( s.Push(e) ) == e */
            var s = new Stos<string>();
            s.Push("aaa");
            Console.WriteLine(s.Peek, "aaa");
        }


        static void Test07()
        {
            /* Peek dla pustego stosu zwraca wyjątek
            s.create.Peek ====> throw StosEmptyException */
            var s = new Stos<double>();
            Console.WriteLine(s.IsEmpty);
            try
            {
                var x = s.Peek;
            }
            catch (StosEmptyException)
            {
                Console.WriteLine("StosEmptyException");
            }
        }

            static void Test08()
            {

                /* Pop dla pustego stosu zwraca wyjątek
                s.create.Pop() ====> throw StosEmptyException */
                var s = new Stos<bool>();
                Console.WriteLine(s.IsEmpty);
                try
                {
                    var x = s.Pop();
                    Console.WriteLine(x);
                }
                catch (StosEmptyException)
                {
                    Console.WriteLine("StosEmptyException");
                }
            }

            static void Test09()
            {

                var s = new Stos<string>();
                s.Push("aaa");
                s.Push("bbb");
                s.Push("ccc");
                foreach (var x in s.ToArray())
                {
                    Console.WriteLine(x);
                }
                Console.WriteLine($"na szczycie jest: {s.Peek}");
                Console.WriteLine($"liczba elementów na stosie: {s.Count}");
                while (!s.IsEmpty)
                {
                    Console.WriteLine($"zdejmuje: {s.Pop()}");
                }
                if (s.IsEmpty)
                    Console.WriteLine("stos jest pusty");
            }
        



        public static void Main(string[] args)
        {
            //Test00();
            //Test01();
            Test02();
            Test03();
            Test04();
            Test05();
            Test06();
            Test07();
            Test08();
            Test09();

        }
    }
}

