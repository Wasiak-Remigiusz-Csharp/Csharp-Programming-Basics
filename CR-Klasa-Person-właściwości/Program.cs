
using System;
namespace MyProg 
{
  // STUDENT_ANSWER

  public class Program

  {

    static  void Test1()
    {
        /* Test: Utworzenie obiektu, dane poprawne */
        var p1 = new Person(familyName : "Abacki",
                            firstName: "John", 
                            birthday: new DateTime(year: 2000, month: 1, day: 1)
                        );
        Console.WriteLine(p1.FamilyName);
        Console.WriteLine(p1.FirstName);
        Console.WriteLine($"{p1.Birthday:yyyy-MM-dd}");
    }

    static  void Test2()
    {
        /* Test: FamilyName, dane poprawne, nazwisko dwuczłonowe, ToString */
        Person p2 = new Person("Abacka-Kuś", 
                                "Ewa", 
                                new DateTime(2000, 1, 1));
        Console.WriteLine(p2);
    }

    static  void Test3()
    {
        /* Test: FamilyName, dane błędne, jest null */
        Person p3 = new Person("Aaa", "Bbb", new DateTime(2000, 1, 1));
        try
        {
        p3.FamilyName = null;
        Console.WriteLine( p3 );
        }
        catch(ArgumentException e)
        when (e.Message == "Incorrect data for FamilyName")
        {
        Console.WriteLine( e.Message );
        }
    }

    static  void Test4()
    {
        	
        /* Test: FamilyName, dane błędne, jest pusty string */
        Person person4 = new Person("Aaa", "Bbb", new DateTime(2000, 1, 1));
        try
        {
        person4.FamilyName = "";
        Console.WriteLine( person4.FamilyName );
        }
        catch(ArgumentException e)
            when (e.Message == "Incorrect data for FamilyName")
        {
        Console.WriteLine( e.Message );
        }
    }


    static  void Test5()
    {
        	
        /* Test: FamilyName, spacje przed i po nazwisku powinny być usunięte */
        Person p5 = new Person("  Aaa  ", "Bbb", new DateTime(2000, 1, 1));
        Console.WriteLine( p5.FamilyName );
    }

    static  void Test6()
    {
        /* Test: FamilyName, za krótkie nazwisko, po usunięciu spacji */
        Person p6 = new Person("  Aaa  ", "Bbb", new DateTime(2000, 1, 1));
        try
        {
        p6.FamilyName = "  A  ";
        Console.WriteLine( p6.FamilyName );
        }
        catch(ArgumentException e)
            when (e.Message == "Incorrect data for FamilyName")
        {
        Console.WriteLine( e.Message );
        }
    }


    static  void Test7()
    {
    
        /* Test: FamilyName, nazwisko dwuczłonowe, za dużo członów */
        Person p7 = new Person("Aaa", "Bbb", new DateTime(2000, 1, 1));
        try
        {
        p7.FamilyName = "Aaa-Bbb-Ccc";
        Console.WriteLine( p7.FamilyName );
        }
        catch(ArgumentException e)
            when (e.Message == "Incorrect data for FamilyName")
        {
        Console.WriteLine( e.Message );
        }
    }

    static  void Test8()
    {
        /* Test: FamilyName, nie dozwolone znaki */
        Person p8 = new Person("Aaa", "Bbb", new DateTime(2000, 1, 1));
        try
        {
        p8.FamilyName = "Aaa.Bbb1Ccc";
        Console.WriteLine( p8.FamilyName );
        }
        catch(ArgumentException e)
            when (e.Message == "Incorrect data for FamilyName")
        {
        Console.WriteLine( e.Message );
        }
    }

    static  void Test9()
    {
        /* Test: FirstName, nie dozwolone znaki, null,
        za krótkie po usunięciu spacji, pusty string,
        */
        Person p = new Person("Aaa", "Bbb", new DateTime(2000, 1, 1));
        try
        {
        p.FirstName = "Aaa.Bbb1Ccc";
        p.FirstName = null;
        p.FirstName = "  A  ";
        p.FirstName = "  ";
        p.FirstName = "  A  ";
        Console.WriteLine( p );
        }
        catch(ArgumentException e)
            when (e.Message == "Incorrect data for FirstName")
        {
        Console.WriteLine( e.Message );
        }
    }


    static  void Test10()
    {
        /* Test: FamilyName, spacje przed i po imieniu powinny być usunięte */
        Person p = new Person("Aaa", "   Bbb ", new DateTime(2000, 1, 1));
        Console.WriteLine( p.FirstName );
    }

    static  void Test11()
    {
        /* Test: FamilyName, spacje przed i po imieniu powinny być usunięte */
        Person p = new Person("Aaa", "   Bbb ", new DateTime(2000, 1, 1));
        Console.WriteLine( p.FirstName );
    }

    static  void Test12()
    {
        /* Test: Birthday, data przyszła */
        Person p = new Person("Aaa", "Bbb", new DateTime(2000, 1, 1));
        try
        {
        p.Birthday = new DateTime( DateTime.Now.Year + 1, 1, 1);

        Console.WriteLine( p );
        }
        catch(ArgumentException e)
            when (e.Message == "Incorrect data for Birthday")
        {
        Console.WriteLine( e.Message );
        }
    }

  
    public static void Main(string[] args) 
    {
        // TEST.testcode

        
        // Test1();
        Test2();
        // Test3();
        // Test4();
        // Test5();
        // Test6();
        // Test7();
        // Test8();
        // Test9();
        // Test10();
        // Test11();
        // Test12();



        	
        
    }
  }
}