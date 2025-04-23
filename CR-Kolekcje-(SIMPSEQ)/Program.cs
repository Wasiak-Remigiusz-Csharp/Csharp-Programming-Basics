// CR: Kolekcje (SIMPSEQ)

// Zadanie 01

// Dane są dwie niepuste tablice liczb całkowitych int[] a oraz int[] b. 
// Liczby zapamiętane w tych tablicach są posortowane w porządku niemalejącym.

// Napisz procedurę o sygnaturze

// public static void Print(int[] a, int[] b)
// wypisującą na standardowe wyjście, w porządku rosnącym, te liczby z tablicy a, których nie ma w tablicy b.

// Nie wypisuj duplikatów.
// Liczby wypisz w jednej linii, oddzielając je pojedynczą spacją.
// W przypadku braku liczb spełniających warunki zadania wypisz słowo empty.
// ⚠️ Rozwiąż zadanie wykorzystując standardowe kolekcje z przestrzeni nazw System.Collections.Generic. 
// Zabronione jest używanie pętli (for, foreach, while) oraz technologii LINQ. Aby przygotować wynik do wydruku użyj metody string.Join().

// For example:

// Input	                                Result
// --------------------------------------------------------
// a = new int[] {-2, -1, 0, 1, 4};         0 4
// b = new int[] {-3, -2, -1, 1, 2, 3};
// --------------------------------------------------------
// a = new int[] {-2, -1, 0, 1, 4};         empty
// b = new int[] {-2, -1, 0, 1, 4, 5, 6};
// --------------------------------------------------------



using System;
using System.Collections.Generic;

class Program
{
    public static void Print(int[] a, int[] b)
    {
        var setA = new HashSet<int>(a);
        var setB = new HashSet<int>(b);

        setA.ExceptWith(setB);

        if (setA.Count == 0)
        {
            Console.WriteLine("empty");
        }else
        {
            Console.WriteLine(string.Join(" ",setA));
        }
    }

    public static void Main()
    {


        int[] a = new  int[]{-2, -1, 0, 1, 4};
        int[] b = new int[] {-3, -2, -1, 1, 2, 3};

        
        // int[] a = new  int[]{-2, -1, 0, 1, 4};
        // int[] b = new int[] {-2, -1, 0, 1, 4, 5, 6};
        Print(a,b);
    }
}





// --------------------------------------------------------------------------------------------------------
// Zadanie 02

// Dane są dwie niepuste tablice liczb całkowitych int[] a oraz int[] b. 
// Liczby zapamiętane w tych tablicach są posortowane w porządku niemalejącym.

// Napisz procedurę o sygnaturze

// public static void Print(int[] a, int[] b)
// wypisującą na standardowe wyjście, w porządku rosnącym, te liczby z tablicy a, które również są w tablicy b.

// Nie wypisuj duplikatów.
// Liczby wypisz w jednej linii, oddzielając je pojedynczą spacją.
// W przypadku braku liczb spełniających warunki zadania wypisz słowo empty.
// Rozwiąż zadanie wykorzystując standardowe kolekcje z przestrzeni nazw System.Collections.Generic. 
// Zabronione jest używanie pętli (for, foreach, while) oraz technologii LINQ. Aby przygotować wynik do wydruku użyj metody string.Join().

// For example:

// Input	                                    Result
// --------------------------------------------------------
// a = new int[] {-2, -1, 0, 1, 4};             2 -1 1
// b = new int[] {-3, -2, -1, 1, 2, 3};
// --------------------------------------------------------
// a = new int[] {1, 2, 3};                     empty
// b = new int[] {-3, -2, -1};
// --------------------------------------------------------

// using System;
// using System.Collections.Generic;

// class Program
// {
//     public static void Print(int[] a, int[] b)
//     {
//         var setA = new SortedSet<int>(a);
//         var setB = new SortedSet<int>(b);

//         setA.IntersectWith(setB);

//         if (setA.Count == 0)
//         {
//             Console.WriteLine("empty");
//         }else
//         {
//             Console.WriteLine(string.Join(" ",setA));
//         }
//     }

//     public static void Main()
//     {


//         int[] a = new  int[]{-2, -1, 0, 1, 4};
//         int[] b = new int[] {-3, -2, -1, 1, 2, 3};

        
//         // int[] a = new  int[]{1, 2, 3};
//         // int[] b = new int[] {-3, -2, -1};
//         Print(a,b);
//     }
// }


// --------------------------------------------------------------------------------------------------------
// Zadanie 03
// Dane są dwie niepuste tablice liczb całkowitych int[] a oraz int[] b. 
// Liczby zapamiętane w tych tablicach są posortowane w porządku niemalejącym.

// Napisz procedurę o sygnaturze

// public static void Print(int[] a, int[] b)
// wypisującą na standardowe wyjście, w porządku rosnącym, te liczby z tablicy a, których nie ma w tablicy b oraz 
// te liczby w tablicy b których nie ma w tablicy a.

// Nie wypisuj duplikatów.
// Liczby wypisz w jednej linii, oddzielając je pojedynczą spacją.
// W przypadku braku liczb spełniających warunki zadania wypisz słowo empty.
// Rozwiąż zadanie wykorzystując standardowe kolekcje z przestrzeni nazw System.Collections.Generic. Zabronione jest używanie pętli (for, foreach, while) oraz technologii LINQ. Aby przygotować wynik do wydruku użyj metody string.Join().

// For example:

// Input	                                    Result
// --------------------------------------------------------
// a = new int[] {-2, -1, 0, 1, 4};             -3 0 2 3 4
// b = new int[] {-3, -2, -1, 1, 2, 3};
// --------------------------------------------------------
// a = new int[] {0, 1, 1, 2, 3, 3, 3};         empty
// b = new int[] {0, 1, 2, 3, 3};
// --------------------------------------------------------


// using System;
// using System.Collections.Generic;

// class Program
// {
//     public static void Print(int[] a, int[] b)
//     {
//         var setA = new SortedSet<int>(a);
//         var setB = new SortedSet<int>(b);

//         setA.SymmetricExceptWith(setB);

//         if (setA.Count == 0)
//         {
//             Console.WriteLine("empty");
//         }else
//         {
//             Console.WriteLine(string.Join(" ",setA));
//         }
//     }

//     public static void Main()
//     {


//         int[] a = new  int[]{-2, -1, 0, 1, 4};
//         int[] b = new int[] {-3, -2, -1, 1, 2, 3};

        
//         // int[] a = new  int[]{0, 1, 1, 2, 3, 3, 3};
//         // int[] b = new int[] {0, 1, 2, 3, 3};
//         Print(a,b);
//     }
// }

