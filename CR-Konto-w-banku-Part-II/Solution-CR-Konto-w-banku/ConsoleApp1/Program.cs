using System;
using System.Reflection;
using Bank;

namespace Program
{
    class Program
    {
        static void Test00()
        {
            /* wypłaty
*/
            var account = new Account("John");
            account.Deposit(100.00m);
            Console.WriteLine(account.Withdrawal(10.00m));
            Console.WriteLine(account);
            Console.WriteLine(account.Withdrawal(100.00m));
            Console.WriteLine(account);
            Console.WriteLine(account.Withdrawal(0.00m));
            Console.WriteLine(account);
            Console.WriteLine(account.Withdrawal(-10.00m));
            Console.WriteLine(account);
            account.Block();
            Console.WriteLine(account.Withdrawal(10.4999m));
            Console.WriteLine(account);


        }

        static void Test01()
        {
            /* weryfikacja, czy implementowany jest interfejs IAccount
*/
            var account = new Account("AAA", 100.00m);
            if (account is Bank.IAccount)
                Console.WriteLine("IAccount implemented");
            else
                Console.WriteLine("IAccount not implemented");
        }


        static void Test02()
        {
            /* weryfikacja, czy Name jest read-only
*/
            Type MyType = typeof(Account);
            PropertyInfo propertyNameInfo = MyType.GetProperty("Name");
            Console.WriteLine(propertyNameInfo.CanWrite);
        }

        static void Test03()
        {

            /* Utworzenie konta dla dwóch poprawnie podanych argumentów
            */
            var account = new Account(" John   ", 100.23m);
            Console.WriteLine(account.Balance == 100.23m);
            Console.WriteLine(account.Name == "John");
            Console.WriteLine(!account.IsBlocked);
            Console.WriteLine(account);
        }

        static void Test04()
        {
            /* Utworzenie konta dla dwóch poprawnie podanych argumentów
                zaokrąglenie kwoty w Balance */
            var account = new Account(" John   ", 100.23156m);
            Console.WriteLine(account.Balance == 100.2316m);
            Console.WriteLine(account.Name == "John");
            Console.WriteLine(!account.IsBlocked);
            Console.WriteLine(account);
        }

        static void Test05()
        {
            /* Utworzenie konta dla dwóch poprawnie podanych argumentów
                zaokrąglenie kwoty w Balance */
            var account = new Account(" John   ", 100.23511m);
            Console.WriteLine(account.Balance == 100.2351m);
            Console.WriteLine(account.Name == "John");
            Console.WriteLine(!account.IsBlocked);
            Console.WriteLine(account);
        }


        static void Test06()
        {
            /* Utworzenie konta dla jednego poprawnie podanego argumentu
            */
            var account = new Account(" Adam ");
            Console.WriteLine(account.Balance == 0.0m);
            Console.WriteLine(account.Name == "Adam");
            Console.WriteLine(!account.IsBlocked);
            Console.WriteLine(account);
        }


        static void Test07()
        {

            /* Utworzenie konta dla dwóch argumentów, ujemne saldo początkowe
            */
            try
            {
                var account = new Account("Jim", -100.01m);
                Console.WriteLine(account);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("negative argument");
            }
        }

        static void Test08()
        {
            /* Utworzenie konta dla dwóch argumentów, nazwa jest null
            */
            try
            {
                var account = new Account(null, 100.0m);
                Console.WriteLine(account);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Name is null");
            }

        }

        static void Test09()
        {

            /* Utworzenie konta dla dwóch argumentów,
            nazwa jest zbyt krótka */
            try
            {
                var account = new Account("   Jo   ", 100.0m);
                Console.WriteLine(account);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Name is to short");
            }
        }

        static void Test10()
        {
            /* Utworzenie konta dla jednego argumentu,
                nazwa jest null */
            try
            {
                var account = new Account(null);
                Console.WriteLine(account);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Name is null");
            }

        }

        static void Test11()
        {

            /* Utworzenie konta dla jednego argumentu,
                nazwa jest za krótka */
            try
            {
                var account = new Account("   An ");
                Console.WriteLine(account);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Name is to short");
            }

        }

        static void Test12()
        {
            /* zablokowanie - odblokowanie konta
            */
            var account = new Account("John");
            account.Block();
            Console.WriteLine(account.IsBlocked);
            account.Unblock();
            Console.WriteLine(account.IsBlocked);

        }

        static void Test13()
        {
            /*  wpłata, kwota dodatnia, konto nie zablokowane,
                zmiana salda */
            var account = new Account("John");
            account.Deposit(100.2345m);
            account.Deposit(10.2345m);
            Console.WriteLine(account);

        }

        static void Test14()
        {

            /* wpłata, kwota ujemna, konto zablokowane,
            saldo nie zmienione */
            var account = new Account("John");
            account.Block();
            Console.WriteLine(account.Deposit(-100.2345m));

        }


        static void Test15()
        {

            /* wpłata, kwota zerowa, konto zablokowane,
            saldo nie zmienione */
            var account = new Account("John");
            account.Block();
            Console.WriteLine(account.Deposit(0.0m));

        }

        static void Test16()
        {

            /* wypłaty
            */
            var account = new Account("John");
            account.Deposit(100.00m);
            Console.WriteLine(account.Withdrawal(10.00m));
            Console.WriteLine(account);
            Console.WriteLine(account.Withdrawal(100.00m));
            Console.WriteLine(account);
            Console.WriteLine(account.Withdrawal(0.00m));
            Console.WriteLine(account);
            Console.WriteLine(account.Withdrawal(-10.00m));
            Console.WriteLine(account);
            account.Block();
            Console.WriteLine(account.Withdrawal(10.4999m));
            Console.WriteLine(account);

        }

        static void TestPartII_01()
        {
            // tworzenie konta, zmiana limitu
            // utworzenie konta plus z domyslnym limitem 100
            var john = new AccountPlus("John");
            Console.WriteLine(john);

            // utworzenie konta plus z ustawionym limitem na 200 i bilansem początkowym 99
            var eve = new AccountPlus("Eve", initialLimit: 200.0m, initialBalance: 99.0m);
            Console.WriteLine(eve);

            // zmiana limitu, konto nie zablokowane
            eve.OneTimeDebetLimit = 120.0m;
            Console.WriteLine(eve);

            // próba zmiany limitu, konto zablokowane
            eve.Block();
            eve.OneTimeDebetLimit = 500.0m;
            Console.WriteLine(eve);

            // próba utworzenia konta z limitem ujemnym
            var stan = new AccountPlus(name: "Stan", initialLimit: -200.0m);
            Console.WriteLine(stan);


        }

        static void TestPartII_02()
        {
            // scenariusz: wpłaty wypłaty, blokada konta
            // utworzenie konta plus z domyslnym limitem 100
            var john = new AccountPlus("John", initialBalance: 100.0m);
            Console.WriteLine(john);

            // wypłata - podanie kwoty ujemnej
            john.Withdrawal(-50.0m);
            Console.WriteLine(john);

            // wypłata bez wykorzystania debetu            
            john.Withdrawal(50.0m);
            Console.WriteLine(john);

            // wypłata z wykorzystaniem debetu
            john.Withdrawal(100.0m);
            Console.WriteLine(john);

            // konto zablokowane, wypłata niemożliwa
            john.Withdrawal(10.0m);
            Console.WriteLine(john);

            // wpłata odblokowująca konto
            john.Deposit(80.0m);
            Console.WriteLine(john);

            // wpłata podanie kwoty ujemnej
            john.Deposit(-80.0m);
            Console.WriteLine(john);


        }

        static void TestPartII_03()
        {
            /* weryfikacja, czy implementowany jest interfejs IAccountWithLimit
*/
            var account = new AccountPlus("AAA", 100.00m);
            if (account is Bank.IAccountWithLimit)
                Console.WriteLine("IAccountWithLimit implemented");
            else
                Console.WriteLine("IAccountWithLimit not implemented");
            /* weryfikacja, czy dziedziczona jest klasa Account
            */
            if (account is Bank.Account)
                Console.WriteLine("Account inherited");
            else
                Console.WriteLine("Account not inherited");


        }

        static void TestPartII_04()
        {


            /* weryfikacja, czy implementowany jest interfejs IAccountWithLimit
            */
            var account = new AccountPlus("AAA", 100.00m);
            if (account is Bank.IAccountWithLimit)
                Console.WriteLine("IAccountWithLimit implemented");
            else
                Console.WriteLine("IAccountWithLimit not implemented");
            /* weryfikacja, czy dziedziczona jest klasa Account
            */
            if (account is Bank.Account)
                Console.WriteLine("Account inherited");
            else
                Console.WriteLine("Account not inherited");

        }

        static void TestPartII_05()
        {

            // tworzenie konta, zmiana limitu
            // utworzenie konta plus z domyslnym limitem 100
            var john = new AccountPlus("John");
            Console.WriteLine(john);

            // utworzenie konta plus z ustawionym limitem na 200 i bilansem początkowym 99
            var eve = new AccountPlus("Eve", initialLimit: 200.0m, initialBalance: 99.0m);
            Console.WriteLine(eve);

            // zmiana limitu, konto nie zablokowane
            eve.OneTimeDebetLimit = 120.0m;
            Console.WriteLine(eve);

            // próba zmiany limitu, konto zablokowane
            eve.Block();
            eve.OneTimeDebetLimit = 500.0m;
            Console.WriteLine(eve);

            // próba utworzenia konta z limitem ujemnym
            var stan = new AccountPlus(name: "Stan", initialLimit: -200.0m);
            Console.WriteLine(stan);

        }



        static void TestPartII_06()
        {

            // scenariusz: wpłaty wypłaty, blokada konta
            // utworzenie konta plus z domyslnym limitem 100
            var john = new AccountPlus("John", initialBalance: 100.0m);
            Console.WriteLine(john);

            // wypłata - podanie kwoty ujemnej
            john.Withdrawal(-50.0m);
            Console.WriteLine(john);

            // wypłata bez wykorzystania debetu
            john.Withdrawal(50.0m);
            Console.WriteLine(john);

            // wypłata z wykorzystaniem debetu
            john.Withdrawal(100.0m);
            Console.WriteLine(john);

            // konto zablokowane, wypłata niemożliwa
            john.Withdrawal(10.0m);
            Console.WriteLine(john);

            // wpłata odblokowująca konto
            john.Deposit(80.0m);
            Console.WriteLine(john);

            // wpłata podanie kwoty ujemnej
            john.Deposit(-80.0m);
            Console.WriteLine(john);


        }

        static void TestPartII_07()
        {


            // sytuacje specjalne
            // konto z zerowym stanem
            var account = new AccountPlus("John", initialBalance: 0, initialLimit: 0);
            Console.WriteLine(account);
            account.Withdrawal(10);
            Console.WriteLine(account);

            // zerowe saldo, limit 50
            account.OneTimeDebetLimit = 50;
            Console.WriteLine(account);
            account.Withdrawal(0); // zerowa wypłata
            Console.WriteLine(account);
            account.Withdrawal(10); // wypłata w ramach debetu
            Console.WriteLine(account);
            account.Unblock(); // próba odblokowania konta
            Console.WriteLine(account);
            account.Deposit(10); // likwidacja debetu, zerowy bilans
            Console.WriteLine(account);

        }




        public static void Main(string[] args)
        {
            //Test00();
            //Test01();
            //Test02();
            //Test03();
            //Test04();
            //Test05();
            //Test06();
            //Test07();
            //Test08();
            //Test09();
            //Test10();
            //Test11();
            //Test12();
            //Test13();
            //Test14();
            //Test15();
            //Test16();

            /////////////////  Part II:
            TestPartII_01();
            TestPartII_02();
            TestPartII_03();
            TestPartII_04();
            TestPartII_05();
            TestPartII_06();
            TestPartII_07();

        }
    }
}


