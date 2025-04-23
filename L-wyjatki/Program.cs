//  Lab. 04. Funkcje, procedury, metody, wyjątki
// Console.WriteLine("//--------------------------------------------------------------------------------------------------------------------------------//");
// Console.WriteLine("Lab. 04. Funkcje, procedury, metody, wyjątki");


// // try-catch
// int x = 10;
// try
// {
//   int y = 0;
//   x /= y; //zgłasza wyjątek
// }
// catch ( DivideByZeroException )
// {
//   Console.WriteLine("Wyjatek przechwycony");
//   //...
// }

// //  ---- try-catch
// int x = 10;
// try
// {
//   int y = 0;
//   x /= y; //zgłasza wyjątek
// }
// catch ( DivideByZeroException e )
// { //dostęp do zmiennej e reprezentujacej obiekt wyjątku
//     Console.WriteLine( $"Message: {e.Message}" );
//   Console.WriteLine( $"Source:  {e.Source}"  );
//   Console.WriteLine( $"Stack:   {e.StackTrace}" );
//   // ...
// }



//  --------  START - IndexOutOfRangeException --------//
// class Program
// {
//     static void Main(string[] args)
//    {
    
//     try
//     {
//         int[] tablica = {1,2,3,4};
//         int x = tablica[4];
//     }
//         catch (System.IndexOutOfRangeException  e)
//     {
        
//         Console.WriteLine( $"Message: {e.Message}" );
//     }
    
//    }
// }

//  --------  END - IndexOutOfRangeException --------//





//  --------  START - NullReferenceException --------//
// class Program
// {
//     static void Main(string[] args)
//    {
    
//     try
//     {
//         string s = null;
//         int x = s.Length;
//     }
//         catch (System.NullReferenceException  e)
//     {
        
//         Console.WriteLine( $"Message: {e.Message}" );
//     }
    
//    }
// }

//  --------  END - NullReferenceException --------//



//  --------  START - InvalidCastException --------//
// class Program
// {
//     static void Main(string[] args)
//    {
    
//     try
//     {
//         object x = 12;
//         Console.WriteLine( "x = " + x );
//         string s = (string) x; //rzutowanie zgłasza InvalidCastExcept
//     }
//         catch (System.InvalidCastException  e)
//     {
        
//         Console.WriteLine( $"Message: {e.Message}" );
//     }
    
//    }
// }

//  --------  END - InvalidCastException --------//




//  --------  START - OutOfMemoryException --------//
// class Program
// {
//     static void Main(string[] args)
//    {
    
//         Random rnd = new Random();
//         List<string> values = new List<string>();
//         for (long i = 1; i <= 4_000_000_000; i++)
//         {
//             values.Add( (rnd.NextDouble()).ToString() );
//             if (i % 1_000_000 == 0)
//                 Console.Write(".");
//             if (i % 10_000_000 == 0)
//                 Console.WriteLine($" Wczytano {i:N0} zestawow danych.");
//         }
    
//    }
// }

//  --------  END - OutOfMemoryException --------//


//  --------  START - ArgumentException --------//
// class Program

// {
//     public static bool TestEmail(string tekst)
//     {
//         if( !tekst.Contains('@') )
//             throw new ArgumentException("Bledny e-mail !"); //lub jeszcze dokładniej

//         //wykonaj dalsze czynności sprawdzania
//         return true;
//     }


//     static void Main(string[] args)
//     {
//         string email1 = "aaa@aaa.com";
//         string email2 = "aaa.com";

//         Console.WriteLine( email1 + ": " + TestEmail(email1) );
//         Console.WriteLine( email2 + ": " + TestEmail(email2) );
//     }
   
// }

//  --------  END - ArgumentException --------//



//  --------  START -- ArgumentNullException -- specjalizacja: ArgumentException --------//
// class Program
// {
//     static void Main(string[] args)
//    {
    
//     try
//     {
//         string napis = null;
//         int liczba = int.Parse(napis);
//     }
//         // catch (System.ArgumentException  e)
//         catch (System.ArgumentNullException  e)
//     {
        
//         Console.WriteLine( $"Message: {e.Message}" );
//     }
    
//    }
// }

//  --------  END -- ArgumentNullException -- specjalizacja: ArgumentException --------//




//  --------  START -- ArgumentOutOfRangeException -- specjalizacja: ArgumentException --------//
// class Program
// {
//     static void Main(string[] args)
//    {
    
//     try
//     {
//         var ciag = new List<int>(); //lista jest pusta
//         var index = 0;
//         ciag.RemoveAt(index);
//     }
//         // catch (System.ArgumentException  e)
//         catch (System.ArgumentOutOfRangeException  e)
//     {
        
//         Console.WriteLine( $"Message: {e.Message}" );
//     }
    
//    }
// }

//  --------  END -- ArgumentOutOfRangeException -- specjalizacja: ArgumentException --------//



// START - Klauzula catch  --  try-catch

// using System;
// class Program 
// {

//     public static void Main(string[] args) 
//     {
//         int x = 10;
//         try
//         {
//         int y = 0;
//         x /= y; //zgłasza wyjątek
//         }
//         catch ( DivideByZeroException )
//         {
//         Console.WriteLine("Wyjatek przechwycony");
//         //...
//         }
            
//     }
// } 

// END - Klauzula catch  --  try-catch




// -- //
// using System;

// class Program 
// {

//         static void Wzorek(int n)
//     {

        
          
          
//     }
//     public static void Main(string[] args) 
//     {
       
//         Wzorek(n);
//     }
// } 

// -- //



// Start -----------------------  Zgłaszanie wyjątków  -----------------------//

// class Program
// {

//     static double PoleTrojkata( double a, double b, double c )
//     {
//         if( a < 0 || b < 0 || c < 0 )
//             throw new ArgumentOutOfRangeException("bok ujemny");

//         if( a+b<c || a+c<b || b+c<a )
//             throw new ArgumentOutOfRangeException("warunek trojkata");

//         //wzór Herona: https://pl.wikipedia.org/wiki/Wz%C3%B3r_Herona
//         var p = a+b+c;
//         return Math.Sqrt( p*(p-a)*(p-b)*(p-c) );
//     }


//     static void Main(string[] args)
//    {
      
//         try
//         {
//         Console.WriteLine( PoleTrojkata(5, 5, 5) );
//         }
//         catch( ArgumentOutOfRangeException e )
//         when (e.Message.Contains("ujemny"))
//         {
//             Console.WriteLine( "Nie mozna obliczyc pola, ujemne argumenty");
//         }
//         catch( ArgumentOutOfRangeException e )
//         when (e.Message.Contains("warunek trojkata"))
//         {
//             Console.WriteLine( "Nie mozna obliczyc pola, nie da utworzyc sie trojkata");
//         }
//    }
// }

// End -----------------------  Zgłaszanie wyjątków  -----------------------//



// Start -----------------------  Rethrow - czyli podaj dalej  -----------------------//

// using System;

// class Program
// {
//     static double PoleTrojkata(double a, double b, double c)
//     {
//         if (a < 0 || b < 0 || c < 0)
//             throw new ArgumentOutOfRangeException("bok ujemny", "All sides must be non-negative.");

//         if (a + b <= c || a + c <= b || b + c <= a)
//             throw new ArgumentOutOfRangeException("warunek trojkata", "The sides do not satisfy the triangle inequality.");

//         // Heron's formula: https://en.wikipedia.org/wiki/Heron%27s_formula
//         var p = (a + b + c) / 2; // Semi-perimeter
//         return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
//     }

//     static void PrintPoleTrojkata(double a, double b, double c)
//     {
//         Console.WriteLine($"a = {a}, b = {b}, c = {c}");
//         try
//         {
//             Console.WriteLine($"Pole = {PoleTrojkata(a, b, c)}");
//         }
//         catch (ArgumentOutOfRangeException e)
//         {
//             // Print error information to Console.Error
//             Console.Error.WriteLine($"Error >> {e.Message}");
//             Console.Error.WriteLine($"StackTrace >> {e.StackTrace}");
//             // Re-throw the exception to propagate it
//             throw;
//         }
//     }

//     static void Main(string[] args)
//     {
//         try
//         {
//             PrintPoleTrojkata(5, 5, 10);
//             // PrintPoleTrojkata(3, 4, 5);
//         }
//         catch
//         {
//             Console.WriteLine("Nie udało się obliczyć, "
//                             + "ale nic poważnego się nie stało!");
//         }
//         Console.WriteLine("Kontynuacja programu ...");
//     }
// }

// End -----------------------  Rethrow - czyli podaj dalej  -----------------------//





// Start -----------------------  Zgłaszanie wyjątków w wyrażeniach  -----------------------//

using System;

class Account
{
  private int _pin;
  public int Pin
  {
    get => _pin;
    set => _pin = (value > 999)? value : throw new ArgumentException("PIN musi miec co najmniej 4 cyfry");
  }
  // ...
}
class Program 
{
    public static void Main(string[] args) 
    {
       
        // w main
        Account a = new Account();
        a.Pin = 1000;
        Console.WriteLine( a.Pin );
        a.Pin = 1; //exception
    }
} 



// End -----------------------  Zgłaszanie wyjątków w wyrażeniach  -----------------------//



