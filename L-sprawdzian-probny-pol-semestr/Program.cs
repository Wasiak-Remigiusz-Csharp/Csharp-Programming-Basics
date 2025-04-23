// Sprawdzian próbny (1/2 sem)

// // -------------------------------- ZADANIE nr 1 --------------------------------//

// Napisz procedurę, o sygnaturze

// public static void Wzorek(int n)
// która dla zadanego argumentu, wypisze na konsoli wzorek podany jako przykład. 
// Procedura ma mieć własność „skalowalności”, tzn. dla różnych wartości parametrów ma wypisywać różnej wielkości, 
// ale poprawnie wyglądające wzorki.

// Przyjmij, że argument n jest nie mniejszy niż 3. Jeśli n jest parzyste, to narysuj wzorek dla n-1.

// ⚠️ nie piszesz programu, tylko treść procedury! Możesz (ale nie musisz) umieścić kod pomocniczy, który 
// można wykorzystać w procedurze Wzorek.

// For example:

// Input    |	Result
// --------------------
// 7            *******
//               *****
//                ***
//                 *
// --------------------
// 8            *******
//               *****
//                ***
//                 *
// --------------------
// 3            ***
//               *
// --------------------


// using System;

// class Program 
// {
//     const char CHAR = '*';
//     static void Star() => Console.Write(CHAR);
//     static void StarLn() => Console.WriteLine(CHAR);
//     static void Space() => Console.Write(" ");
//     static void SpaceLn() => Console.WriteLine(" ");
//     static void NewLine() => Console.WriteLine();

//         static void Wzorek(int n)
//     {
//         if ( n < 3) throw new ArgumentException("zbyt mały rozmiar");
//         if ( n % 2 == 0) n = n - 1;

//         int halfX = (n / 2) + 1;
//         // Console.WriteLine(halfX);
        

//         for (int i = 0; i < halfX; i++)
//         {
//             for (int j = 0; j < n; j++)
//             {
//                 if (i == j  ||  j + i == n - 1)

//                    Star();

//                 else if (j > i && j + i < n - 1)
//                 {
//                     Star();
//                 }

//                 else
//                   Space();
              
//             }
//             NewLine();  
//         }
        
        
          
          
//     }
//     public static void Main(string[] args) 
//     {
//         int n = int.Parse(Console.ReadLine());
//         Wzorek(n);

//     }
// } 



// // -------------------------------- ZADANIE nr 2 --------------------------------//

// Zaimplementuj funkcję o sygnaturze i opisie podanymi poniżej:

// <summary>
// Oblicza pole trójkąta dowolnego dla zadanych długości boków, zaokrąglając wynik do podanej liczby cyfr po przecinku
// </summary>
// <param name="a">długość pierwszego boku, liczba całkowita nieujemna</param>
// <param name="b">długość drugiego boku, liczba całkowita nieujemna</param>
// <param name="c">długość trzeciego boku, liczba całkowita nieujemna</param>
// <param name="precision">dokładność obliczeń (zaokrąglenie), liczba cyfr po przecinku (od 2 do 8)</param>
/// <returns>pole trójkąta obliczone z zadaną dokładnością</returns>
// <exception cref="ArgumentOutOfRangeException">z komunikatem "wrong arguments", 
///     gdy <c>precision</c> jest poza przedziałem od 2 do 8 lub którakolwiek z długości jest ujemna</exception>    
/// <exception cref="ArgumentException">z komunikatem "object not exist", gdy trójkąta nie można utworzyć</exception>
// public static double TriangleArea(int a, int b, int c, int precision=2)
// For example:

// Input	    |   Result
// --------------------
// a:1              --test: start
// b:1              0.433
// c:1              --test: stop
// precision:3
// --------------------
// a:-1             --test: start
// b:0              wrong arguments
// c:1              --test: stop
// precision:9
// --------------------
// a:1              --test: start
// b:2              object not exist
// c:10             --test: stop
// precision:8
// --------------------



// using System;

// class Program 
// {

//     public static double TriangleArea(int a, int b, int c, int precision=2)
// {
//     if (a < 0 || b < 0 || c < 0 || !(precision >= 2 && precision <= 8))
//     {
//         throw new ArgumentOutOfRangeException("wrong arguments");
//     }

//     if (a + b < c || a + c < b || b + c < a)
//     {
//         throw new ArgumentException("object not exist");
//     }

//     // s⁠ => be the semiperimeter 
//     double s = (a + b + c) / 2.0;
//     // area 
//     double area = Math.Sqrt( (s * ( s - a) * (s - b) * (s - c)));
//     return Math.Round(area, precision);
// }
//     public static void Main(string[] args) 
//     {
//         // TrianglePerimeter(1,2,3);
//         // Console.WriteLine(TrianglePerimeter(2,2,3));
//         Console.WriteLine(TriangleArea(1,1,1, 3));
//     }
// } 



// // -------------------------------- ZADANIE nr 3 --------------------------------//

// Napisz program, który:

// ze standardowego wejścia wczyta 3 napisy, podane w oddzielnych liniach,
// przekonwertuje te napisy na liczby całkowite (typu int)
// obliczy sumę tych trzech liczb całkowitych i wypisze wynik 
// na standardowe wyjście (o ile nie zostaną zgłoszone wyjątki).
// Twój program nie może zostać przerwany z powodu wyjątków, które mogą zostać zgłoszone podczas jego działania. 
// Przechwyć je i wypisz na standardowe wyjście stosowny komunikat:

// gdy zgłoszony zostanie inny wyjątek niż podane poniżej, wypisz tekst non supported exception, exit
// gdy zgłoszony zostanie wyjątek FormatException wypisz tekst format exception, exit
// gdy zgłoszony zostanie wyjątek ArgumentException wypisz tekst argument exception, exit
// gdy zgłoszony zostanie wyjątek OverflowException wypisz tekst overflow exception, exit
// For example:

// Input	            |           Result
// --------------------
// 2                                9
// 3
// 4
// --------------------
// 1                                argument exception, exit
// 2
// --------------------
// 2.1                              format exception, exit
// 1
// 2
// --------------------
// 1127531753753751275371253        overflow exception, exit
// 2
// 3
// --------------------
// 00234                            237
// 1
// 2
// --------------------
// 2_234                            format exception, exit
// 1
// 2
// --------------------



// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
        
//         try
//         {
//             int a  = int.Parse(Console.ReadLine());
//             int b  = int.Parse(Console.ReadLine());
//             int c  = int.Parse(Console.ReadLine());

//             int iloczyn;
//             checked
//             {
//                 iloczyn = a + b + c;
//             }
//             Console.WriteLine(iloczyn);
//         }
//         catch (System.FormatException)
//         {
            
//             Console.WriteLine("format exception, exit");
//         }
//         catch (System.ArgumentException)
//         {
            
//             Console.WriteLine("argument exception, exit");
//         }
//         catch (System.OverflowException)
//         {
            
//             Console.WriteLine("overflow exception, exit");
//         }
//         catch 
//         {
            
//             Console.WriteLine("non supported exception, exit");
//         }
//     }
// }




// // -------------------------------- ZADANIE nr 4 --------------------------------//
// Napisz funkcję, która dla przekazanej jako parametr dwuwymiarowej regularnej tablicy liczb całkowitych obliczy 
// średnią arytmetyczną zawartych w niej liczb dodatnich, zaokrąglając wynik 
// do 2 miejsc po przecinku. Jeśli jako argument przekazano null lub tablicę pustą, zwróć 0.00. 
// Jeśli nie ma liczb spełniających wymagania, zwróć 0.00.

// Nagłówek funkcji:

// public static double Srednia( int[,] tab )
// ⚠ wprowadzasz tylko definicję funkcji!

// For example:

// Input	    |   Result
// --------------------
// 1 1 1 1 1 1      2.00
// 2 2 2 2 2 2
// 3 3 3 3 3 3
// --------------------
// 1 2 3            2.00
// --------------------
// -1               1.00
// 1 
// 1
// --------------------
// 1 1              1.33
// 2 -1
// --------------------



// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Xml.XPath;

// public class Program
// {
//     // static void outputMatrix(int[,] matrix)
//     public static double Srednia( int[,] tab )
//     {


//         if (tab == null  || tab.Length == 0)
//         {
//             return 0.00;
//         }


//         int sum = 0;
//         int count = 0;

//         for (int i = 0; i < tab.GetLength(0); i++)
//         {
//             for (int j = 0; j < tab.GetLength(1); j++)
//             {
//                 // Console.Write(tab[i,j] + " ");
//                 if (tab[i,j] > 0)
//                 {
//                     sum += tab[i,j];
//                     count++;
//                 }
//             }
//             // Console.WriteLine();
//         }


//         if (count==0)
//         {
//             return 0.00;
//         }
//         else
//         {
//             double result = Math.Round((double)sum/count, 2);
//             return result;
//         }
//     }
//     public static void Main(string[] args)
//     {

//         List<int[]> rowsInput = new List<int[]>();
//         string consoleLine;


//         while ((consoleLine = Console.ReadLine()) != null && consoleLine.Trim() != "")
//         {
//             int[] rowSingular = consoleLine.Split(' ').Select(int.Parse).ToArray();
//             rowsInput.Add(rowSingular);
//         }

//         int rowsCount =  rowsInput.Count;
//         int colsCount =  rowsInput[0].Length;
//         int [,] matrix = new int[rowsCount,colsCount];

//         // Converting a list to a matrix

//         for (int i = 0; i < rowsCount; i++)
//         {
//             for (int j = 0; j < colsCount; j++)
//             {
//                 matrix[i,j] = rowsInput[i][j];
//             }
//         }


//         // Printing Matrix 

//         // for (int i = 0; i < rowsCount; i++)
//         // {
//         //     for (int j = 0; j < colsCount; j++)
//         //     {
//         //         Console.Write(matrix[i,j] + " ");
//         //     }
//         //     Console.WriteLine();
//         // }


//         // outputMatrix(matrix);
//         double finish = Srednia(matrix);

//         Console.WriteLine(finish);

//     }
// }



// // -------------------------------- ZALICZENIE --------------------------------//
// // -------------------------------- ZADANIE nr 1 --------------------------------//
// Napisz procedurę, o sygnaturze

// public static void Wzorek(int n)
// która dla zadanego argumentu, wypisze na konsoli wzorek podany jako przykład. 
// Procedura ma mieć własność „skalowalności”, tzn. dla różnych wartości parametrów ma wypisywać różnej wielkości, 
// ale poprawnie wyglądające wzorki.

// Przyjmij, że argument n jest nie mniejszy niż 5.

// ⚠️ nie piszesz programu, tylko treść procedury! Możesz (ale nie musisz) umieścić kod pomocniczy, 
// który można wykorzystać w procedurze Wzorek.

// using System;

// class Program 
// {
//     const char CHAR = '*';
//     static void Star() => Console.Write(CHAR);
//     // static void Star1() => Console.Write("1");
//     static void StarLn() => Console.WriteLine(CHAR);
//     static void Space() => Console.Write(" ");
//     static void SpaceLn() => Console.WriteLine(" ");
//     static void NewLine() => Console.WriteLine();

//         static void Wzorek(int n)
//     {
//         if ( n < 5) throw new ArgumentException("zbyt mały rozmiar");
//         int entryN = n;
//         if ( n % 2 == 0) n = n - 1;

//         int halfX = (n / 2) + 1;
//         // Console.WriteLine($"halfX: {halfX}");
        
//         // Ver 2

//         if (entryN == n)
//         {
            
//             for (int i = 0; i < n; i++)
//             {
//                 for (int j = 0; j < n; j++)
//                         {

                        
//                         if (i ==0 && j ==n-1  || i ==n-1 && j ==n-1 || i == halfX-1 && j ==n-1)
//                             {
//                                 Space();
//                             }
//                             else if ( i ==0 && j <=n-1  || i ==n-1 && j <=n-1 || i == halfX-1 && j <=n-1)
//                             {
//                                 Star();
//                             }
//                             else if ( i !=0 && j ==n-1  || i !=n-1 && j ==n-1 || i != halfX-1 && j ==n-1)
//                             {
//                                 // Star1();
//                                 Star();
//                             }
//                             else
//                             Space();
//                         }
//                         NewLine(); 
//                     }
//          }
//          else
//          {
//             // Console.WriteLine("ko");
//             for (int i = 0; i < n; i++)
//             {
//                 for (int j = 0; j < n+1; j++)
//                         {

                        
//                         if (i ==0 && j ==n  || i ==n-1 && j ==n || i == halfX-1 && j ==n)
//                             {
//                                 Space();
//                             }
//                             else if ( i ==0 && j <=n  || i ==n-1 && j <=n || i == halfX-1 && j <=n)
//                             {
//                                 Star();
//                             }
//                             else if ( i !=0 && j ==n  || i !=n-1 && j ==n || i != halfX-1 && j ==n)
//                             {
//                                 // Star1();
//                                 Star();
//                             }
//                             else
//                             Space();
//                         }
//                         NewLine(); 
//                     }
            
            
//          }


          
//     }
//     public static void Main(string[] args) 
//     {
//         int n = int.Parse(Console.ReadLine());
//         Wzorek(n);

//     }
// } 



// // -------------------------------- ZADANIE nr 2 --------------------------------//

// Zaimplementuj funkcję o sygnaturze i opisie podanymi poniżej:

// /// <summary>
// /// Oblicza obwód trapezu równoramiennego dla zadanych długości: obu podstaw oraz ramienia, 
// zaokrąglając wynik do podanej liczby cyfr po przecinku
// /// </summary>
// /// <param name="base1">długość pierwszej podstawy, liczba całkowita nieujemna</param>
// /// <param name="base2">długość drugiej podstawy, liczba całkowita nieujemna</param>
// /// <param name="leg">długość ramienia, liczba całkowita nieujemna</param>
// /// <param name="precision">dokładność obliczeń (zaokrąglenie), liczba cyfr po przecinku (od 2 do 8)</param>
// /// <returns>obwód trapezu obliczony z zadaną dokładnością</returns>
// /// <exception cref="ArgumentOutOfRangeException">z komunikatem "wrong arguments", 
// ///     gdy <c>precision</c> jest poza przedziałem od 2 do 8 lub którakolwiek z długości jest ujemna</exception>    
// /// <exception cref="ArgumentException">z komunikatem "object not exist", gdy trapezu nie można utworzyć</exception>
// public static double TrapesoidIsoscelesPerimeter(int base1, int base2, int leg, int precision=2)


using System;

class Program 
{

    // public static double TrianglePerimeter(int a, int b, int c, int precision=2)
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

    public static double TrapesoidIsoscelesPerimeter(int base1, int base2, int leg, int precision=2)
    {
        // throw new NotImplementedException();
        // Console.WriteLine("TrapesoidIsoscelesPerimeter");
        if (base1 < 0 || base2 < 0 || !(precision >= 2 && precision <= 8))
        {
            throw new ArgumentOutOfRangeException("wrong arguments");
        }

        
        int a = base1;
        int b = base2;
        int c = leg;
        int d = leg;

        double obwod = a + b + c +d;
        return Math.Round(obwod, precision);;
    }





    public static void Main(string[] args) 
    {
        // TrianglePerimeter(1,2,3);
        // Console.WriteLine(TrianglePerimeter(2,2,3));
        Console.WriteLine(TrapesoidIsoscelesPerimeter(1,1,1));
    }
} 








// // -------------------------------- ZADANIE nr 3 --------------------------------//
// Napisz program, który:

// ze standardowego wejścia wczyta 3 napisy, podane w oddzielnych liniach,
// przekonwertuje te napisy na liczby całkowite (typu int)
// obliczy rozstęp dla tych trzech liczb całkowitych i wypisze wynik na standardowe wyjście 
// (o ile nie zostaną zgłoszone wyjątki).
// Rozstęp dla zbioru liczb = różnica między wartością największą a najmniejszą

// Twój program nie może zostać przerwany z powodu wyjątków, które mogą zostać zgłoszone podczas jego działania. Przechwyć je i wypisz na standardowe wyjście stosowny komunikat:

// gdy zgłoszony zostanie inny wyjątek niż podane poniżej, wypisz tekst non supported exception, exit
// gdy zgłoszony zostanie wyjątek FormatException wypisz tekst format exception, exit
// gdy zgłoszony zostanie wyjątek ArgumentException wypisz tekst argument exception, exit
// gdy zgłoszony zostanie wyjątek OverflowException wypisz tekst overflow exception, exit



// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
        
//         try
//         {
//             int a  = int.Parse(Console.ReadLine());
//             int b  = int.Parse(Console.ReadLine());
//             int c  = int.Parse(Console.ReadLine());

//             int max = Math.Max(a, Math.Max(b,c));
//             int min = Math.Min(a, Math.Min(b,c));

//             // Console.WriteLine($"Max: {max}");
//             // Console.WriteLine($"min: {min}");

//             int roztep;
            

//             checked
//             {
//                 roztep = max - min;
//             }
//             Console.WriteLine(roztep);
//         }
//         catch (System.FormatException)
//         {
            
//             Console.WriteLine("format exception, exit");
//         }
//         catch (System.ArgumentException)
//         {
            
//             Console.WriteLine("argument exception, exit");
//         }
//         catch (System.OverflowException)
//         {
            
//             Console.WriteLine("overflow exception, exit");
//         }
//         catch 
//         {
            
//             Console.WriteLine("non supported exception, exit");
//         }
//     }
// }



// // -------------------------------- ZADANIE nr 4 --------------------------------//