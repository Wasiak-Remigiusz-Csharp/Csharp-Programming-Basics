//  CR: Zgłaszanie i przechwytywanie wyjątków

// // -------------------------------- ZADANIE nr 1 --------------------------------//

/// <summary>
/// Oblicza obwód trójkąta dowolnego dla zadanych długości boków, zaokrąglając wynik do podanej liczby cyfr po przecinku
/// </summary>
// <param name="a">długość pierwszego boku, liczba całkowita nieujemna</param>
// <param name="b">długość drugiego boku, liczba całkowita nieujemna</param>
// <param name="c">długość trzeciego boku, liczba całkowita nieujemna</param>
// <param name="precision">dokładność obliczeń (zaokrąglenie), liczba cyfr po przecinku (od 2 do 8)</param>
// <returns>obwód trójkąta obliczony z zadaną dokładnością</returns>
// <exception cref="ArgumentOutOfRangeException">z komunikatem "wrong arguments", 
//     gdy <c>precision</c> jest poza przedziałem od 2 do 8 lub którakolwiek z długości jest ujemna</exception>    
// <exception cref="ArgumentException">z komunikatem "object not exist", gdy trójkąta nie można utworzyć</exception>
// <remarks>dopuszczamy trójkąt o pokrywających się bokach lub o wszystkich bokach o długości 0</remarks>



// using System;

// class Program 
// {

//     public static double TrianglePerimeter(int a, int b, int c, int precision=2)
// {
//     if (a < 0 || b < 0 || c < 0 || !(precision >= 2 && precision <= 8))
//     {
//         throw new ArgumentOutOfRangeException("wrong arguments");
//     }

//     if (a + b < c || a + c < b || b + c < a)
//     {
//         throw new ArgumentException("object not exist");
//     }

//     double obwod = a + b + c;
//     return Math.Round(obwod, precision);
// }
//     public static void Main(string[] args) 
//     {
//         // TrianglePerimeter(1,2,3);
//         Console.WriteLine(TrianglePerimeter(2,2,3));
//     }
// } 




// // -------------------------------- ZADANIE nr 2 --------------------------------//
using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
        
        int iloczyn;
        checked
        {
            iloczyn = x * y * z;
        }
        Console.WriteLine(iloczyn);
        
        }
        catch (ArgumentException)
        {
            Console.WriteLine("argument exception, exit");
        }
        catch (FormatException)
        {
            Console.WriteLine("format exception, exit");
        }
        catch (OverflowException)
        {
            Console.WriteLine("overflow exception, exit");
        }
        catch
        {
            Console.WriteLine("non supported exception, exit");
        }
    }
}


