// // CR: Seria zadań - przetwarzanie tablic 1D

// // -------------------------------- ZADANIE nr 1 --------------------------------//

// // Dane są dwie niepuste tablice liczb całkowitych int[] a oraz int[] b. 
// // Liczby zapamiętane w tych tablicach są posortowane w porządku niemalejącym.

// // Napisz procedurę o sygnaturze

// // public static void Print(int[] a, int[] b)
// // wypisującą na standardowe wyjście, w porządku rosnącym, te liczby z tablicy a, których nie ma w tablicy b.

// // Nie wypisuj duplikatów.
// // Liczby wypisz w jednej linii, oddzielając je pojedynczą spacją.
// // W przypadku braku liczb spełniających warunki zadania wypisz słowo empty.


// using System;

// class Program
// {
//     public static void Print(int[] a, int[] b)
//     {
//         string output = "";
//         for (int i = 0; i < a.Length; i++)
//         {

//             if (Array.Exists(b, x => (x ==a[i])) == false)
//             {
//                 if (i > 0)
//                 {
//                     if (a[i] != a[i - 1])
//                     {
//                         if (output == "")
//                         {
//                             output += a[i]; 
//                         }
//                         else
//                         {
//                             output +=  " " + a[i];
//                         }
//                     }
//                 }
//                 else
//                 {
//                     if (output == "")
//                     {
//                         output += a[i]; 
//                     }
//                     else
//                     {
//                         output +=  " " + a[i];
//                     }
//                 }


//             }
//         }
//         if (output =="")
//         {
//             output = "empty";
//         }

//         Console.WriteLine(output);
//     }

//     public static void Main(string[] args)
//     {
//         // int[] a = {-2, -1, 0, 1, 4, 5, 6 , 7};
//         // int[] b = {-2, -1, 1, 2, 3};

//         // int[] a ={0, 1, 1, 2, 3, 3, 3};
//         // int[] b = {0, 2, 2, 3, 4};

//         int[] a ={1};
//         int[] b = {2};

//         Print(a,b);
//     }
// }



// // -------------------------------- ZADANIE nr 2 --------------------------------//

// Dane są dwie niepuste tablice liczb całkowitych int[] a oraz int[] b. 
// Liczby zapamiętane w tych tablicach są posortowane w porządku niemalejącym.

// Napisz procedurę o sygnaturze

// public static void Print(int[] a, int[] b)
// wypisującą na standardowe wyjście, w porządku rosnącym, te liczby z tablicy a, które również są w tablicy b.

// Nie wypisuj duplikatów.
// Liczby wypisz w jednej linii, oddzielając je pojedynczą spacją.
// W przypadku braku liczb spełniających warunki zadania wypisz słowo empty.



// using System;

// class Program
// {
//     public static void Print(int[] a, int[] b)
//     {
//         string output = "";
//         for (int i = 0; i < a.Length; i++)
//         {

//             if (Array.Exists(b, x => (x ==a[i])) == true)
//             {
//                 if (i > 0)
//                 {
//                     if (a[i] != a[i - 1])
//                     {
//                         if (output == "")
//                         {
//                             output += a[i]; 
//                         }
//                         else
//                         {
//                             output +=  " " + a[i];
//                         }
//                     }
//                 }
//                 else
//                 {
//                     if (output == "")
//                     {
//                         output += a[i]; 
//                     }
//                     else
//                     {
//                         output +=  " " + a[i];
//                     }
//                 }


//             }
//         }
//         if (output =="")
//         {
//             output = "empty";
//         }

//         Console.WriteLine(output);
//     }

//     public static void Main(string[] args)
//     {
//         int[] a = {-2, -1, 0, 1, 4};;
//         int[] b =  {-3, -2, -1, 1, 2, 3};;

//         // int[] a ={0, 1, 1, 2, 3, 3, 3};
//         // int[] b = {0, 2, 2, 3, 4};

//         // int[] a ={1};
//         // int[] b = {2};

//         Print(a,b);
//     }
// }




// // -------------------------------- ZADANIE nr 3 --------------------------------//

// Dane są dwie niepuste tablice liczb całkowitych int[] a oraz int[] b. 
// Liczby zapamiętane w tych tablicach są posortowane w porządku niemalejącym.

// Napisz procedurę o sygnaturze

// public static void Print(int[] a, int[] b)
// wypisującą na standardowe wyjście, w porządku rosnącym, te liczby z tablicy a, których nie ma w tablicy b 
// oraz te liczby w tablicy b których nie ma w tablicy a.

// Nie wypisuj duplikatów.
// Liczby wypisz w jednej linii, oddzielając je pojedynczą spacją.
// W przypadku braku liczb spełniających warunki zadania wypisz słowo empty.
// ⚠️ Rozwiąż zadanie wykorzystując metody przeglądania tablic. Zabronione jest używanie kolekcji oraz technologii LINQ.

// For example:

//      Input	                                     Result
//-------------------------------------------------------------
//      a = new int[] {-2, -1, 0, 1, 4};
//      b = new int[] {-3, -2, -1, 1, 2, 3};         -3 0 2 3 4
//--------------------------------------------------------------
//      a = new int[] {0, 1, 1, 2, 3, 3, 3};
//      b = new int[] {0, 1, 2, 3, 3};               empty


using System;

public class Program
{
    public static void Print(int[] a, int[] b)
    {
        int i = 0, j = 0;
        bool hasOutput = false;


        while (i < a.Length  || j < b.Length)
        {
            // Jeśli TAB B skończyła sie, lub a[i] jest mniejszy 
            if (j >= b.Length || ( i < a.Length && a[i] < b[j]))
            {
                if (i == 0  || a[i] != a[i - 1])
                {
                    Console.Write(a[i] + " ");
                    hasOutput = true;
                }
                i++;
                // j++;

            }
            
            // Jeśli TAB A skończyła sie, lub b[i] jest mniejszy 
            else if (i >= a.Length || ( j < b.Length &&b[j] < a[i]))
            {
                if (j == 0  || b[j] != b[j - 1])
                {
                    Console.Write(b[j] + " ");
                    hasOutput = true;
                }
                // i++;
                j++;

            }

            // Jeśli a[i] == b[j], przechodzi sie do następnego elementu w obu tablicach
            else
            {
                i++;
                j++;
            }

        }

        // Output
        if (!hasOutput)
        {   
            Console.WriteLine("empty");
        }
        else
        {
            Console.WriteLine();
        }
    }       

    public static void Main()
    {
        // int[] a = new int[] { -2, -1, 0, 1, 4 , 5};
        // int[] b = new int[] { -2, -1, 1, 2, 3 };
        // Print(a, b); // Wynik: -3 0 2 3 4

        // a = new int[] { 0, 1, 1, 2, 3, 3, 3 };
        // b = new int[] { 0, 1, 2, 3, 3,4,5,6,7 };
        // Print(a, b); // Wynik: empty



        // a = new int[] {  2, 3, 3, 3 };
        // b = new int[] { 0, 1, 2, 3, 3 };
        // Print(a, b); // Wynik: empty


        int[] a = new int[] {-2, -1, 0, 1, 4};
        int[] b = new int[] {-2, -1, 0, 1, 4, 5, 6};
        Print(a, b); // Wynik: -3 0 2 3 4
    }
}
