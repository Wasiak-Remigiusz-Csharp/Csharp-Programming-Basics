
using System;
namespace MyProg 
{
  // STUDENT_ANSWER

  public class Program

  {

    static  void Test1()
    {
        	
        // Test 1
        var t = new Czas24h(2, 15, 37);
        t.Minuta = 20;
        t.Godzina = 1;
        t.Sekunda = 26;
        Console.WriteLine(t);
    }

    static  void Test2()
    {
        // Test 2
        var t = new Czas24h(2, 15, 37);
        t.Minuta = 20;
        t.Godzina = 24;
        Console.WriteLine(t);
    }

    static  void Test3()
    {
        // Test 3
        var t = new Czas24h(2, 15, 37);
        t.Minuta = -20;
        t.Godzina = 23;
        Console.WriteLine(t);
    }
    static  void Test4()
    {
        // Test 4
        var t = new Czas24h(2, 15, 37);
        t.Minuta = 20;
        t.Godzina = 23;
        t.Godzina = 1;
        t.Sekunda = 15;
        t.Minuta = 10;
        t.Sekunda = 23;
        t.Sekunda = 1;
        t.Minuta = 12;
        Console.WriteLine(t);
    }

    static  void Test5()
    {
        // Test 5
        var t = new Czas24h(24, 15, 37);
        t.Minuta = 20;
        t.Godzina = 23;
        t.Godzina = 1;
        Console.WriteLine(t);
    }



  
    public static void Main(string[] args) 
    {
        // TEST.testcode

        
        // Test1();
        // Test2();
        // Test3();
        // Test4();
        Test5();



        	
        
    }
  }
}