using System;

using ConsoleApp1;
class Program
{
    static void Test01()
    {
        // Test: poprawne tworzenie obiektu Player, dane poprawne
        //       typowe czynności poprawne
        Player p = new Player(name: "molenda",
                              password: "AbCd#123!");
        p.AddScore(22);
        p.AddScore(41);
        Console.WriteLine(p);
        p.Name = "kmol9";
        p.ChangePassword(oldPassword: "AbCd#123!",
                         newPassword: "a123*!BC");
        Console.WriteLine(p.TryAddScore(32));
        Console.WriteLine(p);
    }

    static void Test02()
    {
        // Test: poprawne zainicjowanie obiektu Player, dane poprawne
        Player p = new Player(name: "molenda", password: "AbCd#123!");
        Console.WriteLine(p);
    }

    static void Test03()
    {
        // Test: tworzenie obiektu Player, name do skorygowania,
        // spacje w środku, białe znaki na początku i końcu, wielkość liter
        Player p = new Player(name: "  Molenda", password: "AbCd#123!");
        Console.WriteLine(p);
        Player p1 = new Player(name: "Molenda   ", password: "AbCd#123!");
        Console.WriteLine(p1);
        Player p2 = new Player(name: "Mo Len  Da", password: "AbCd#123!");
        Console.WriteLine(p2);

    }


    static void Test04()
    {

        // Test: błędne name, nie dopuszczalne znaki
        try
        {
            Player p = new Player(name: "mol@123", password: "AbCd#123!");
            Console.WriteLine(p);
            Player p1 = new Player(name: null, password: "AbCd#123!");
            Console.WriteLine(p1);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }


    static void Test05()
    {
        // Test: błędne hasło, długość hasła
        try
        {
            Player p = new Player(name: "mol123", password: null);
            Console.WriteLine(p);
            Player p1 = new Player(name: "mol123", password: "AbCd#");
            Console.WriteLine(p1);
            Player p2 = new Player(name: "mol123", password: "AbCdef#0123456789");
            Console.WriteLine(p2);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

    }

    static void Test06()
    {

        // Test: błędne hasło, znaki w haśle
        try
        {
            Player p;
            p = new Player(name: "mol123", password: "brakCyfry!");
            p = new Player(name: "mol123", password: "123456789"); //brak litery
            p = new Player(name: "mol123", password: "brakZnakuInterpunkcyjnego1");
            p = new Player(name: "mol123", password: "  spacje_naP0czatku");
            p = new Player(name: "mol123", password: "brak-1.-duzej-litery");
            //p = new Player(name: "mol123", password: "p0prawne Hasl0!");
            Console.WriteLine(p);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

    }

    static void Test07()
    {

        // Test: metoda ChangePassword()
        Player p = new Player(name: "mol123", password: "p0prawne Hasl0!");
        Console.WriteLine(p.ChangePassword(oldPassword: "p0prawne Hasl0!",
                                           newPassword: "brakCyfr?"));
        Console.WriteLine(p.ChangePassword(oldPassword: "p0prawne Hasl0!",
                                           newPassword: "102938475"));
        Console.WriteLine(p.ChangePassword(oldPassword: "p0prawne Hasl0!",
                                           newPassword: "brakInterpunkcji1"));
        Console.WriteLine(p.ChangePassword(oldPassword: "p0prawne Hasl0!",
                                           newPassword: "spacjaNaKoncu1  "));
        Console.WriteLine(p.ChangePassword(oldPassword: "p0prawne Hasl0!",
                                           newPassword: "brak1duzej-litery"));
        Console.WriteLine(p.ChangePassword(oldPassword: "zleHasl0!",
                                           newPassword: "p0prawneHasl0."));
        Console.WriteLine(p.ChangePassword(oldPassword: "p0prawne Hasl0!",
                                           newPassword: "p0prawneHasl0."));
    }


    static void Test08()
    {
        // Test: metoda VerifyPassword()
        Player p = new Player(name: "mol123", password: "aB12.,aC");
        Console.WriteLine(p.VerifyPassword("aB12.,aC"));
        Console.WriteLine(p.VerifyPassword(null));
        Console.WriteLine(p.VerifyPassword("ab12-!aC"));
    }

    static void Test09()
    {
        // Test: AddScore
        Player p = new Player(name: "mol123", password: "aB12.,aC");
        Console.WriteLine(p);
        try
        {
            p.AddScore(-1);
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.WriteLine(e.Message);
        }
        try
        {
            p.AddScore(101);
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.WriteLine(e.Message);
        }
        p.AddScore(100);
        Console.WriteLine(p);
        p.AddScore(0);
        Console.WriteLine(p);
    }


    static void Test10()
    {

        // Test: TryAddScore
        Player p = new Player(name: "mol123", password: "aB12.,aC");
        Console.WriteLine(p);
        Console.WriteLine(p.TryAddScore(-1));
        Console.WriteLine(p);
        Console.WriteLine(p.TryAddScore(101));
        Console.WriteLine(p);
        Console.WriteLine(p.TryAddScore(100));
        Console.WriteLine(p);
        Console.WriteLine(p.TryAddScore(0));
        Console.WriteLine(p);
    }


    //static void Test11()
    //{

    //}

    public static void Main(string[] args)
    {
        //Test01();
        //Test02();
        //Test03();
        //Test04();
        //Test05();
        //Test06();
        //Test07();
        //Test08();
        Test09();
        //Test10();
    }
}