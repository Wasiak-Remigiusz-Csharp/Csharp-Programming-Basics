// CR: Tablica postrzępiona
// Question 1
// Not complete
// Marked out of 3.00
// Flag question
// Question text
// Zadanie dotyczy tablic postrzępionych w C# (jagged arrays).

// Napisz metody (nie program) o sygnaturach:

// static char[][] ReadJaggedArrayFromStdInput() - z pierwszej linii standardowego 
// wejścia wczytuje liczbę wierszy (<10), następnie wczytuje kolejne wiersze składające się ze znaków oddzielonych pojedynczą spacją. 
// Jako wynik swojego działania zwraca wczytane dane w formie tablicy postrzępionej (patrz sygnatura),
// static char[][] TransposeJaggedArray(char[][] tab) - transponuje tablicę, zwracając nową, w której kolumny stają się wierszami, 
// zaś wiersze kolumnami,
// static void PrintJaggedArrayToStdOutput(char[][] tab) - wypisuje na standardowe wyjście tablicę wierszami w kolejnych liniach.
// Przy implementacji sugeruj się podanymi przykładami.

// Możesz utworzyć inne metody, które uznasz za pomocne, ale musisz zaprogramować podane powyżej dokładnie z taką sygnaturą.

// Twoje implementacje metod testowane będą w metodzie Main (nie pisz jej!!) w następujący sposób:

// For example:

// Input	    |      Result
// -----------------------------
// 3                   a b c d e
// a b c d e           a b
// a b                 a b c
// a b c               
//                     a a a
//                     b b b
//                     c   c
//                     d
//                     e
// -----------------------------



using System;
using System.Collections.Generic;
// using System.Linq;


public class Prgram
{
    static char[][] ReadJaggedArrayFromStdInput()
    {

        char[][] jaggedArray;

        // Wczytanie liczbe podtablic
        int subarrayCount = int.Parse(Console.ReadLine());
        jaggedArray = new char[subarrayCount][];


        // Tworzenie: Tablica postrzępiona   
        for (int i = 0; i < subarrayCount; i++)
        {
            string[] rowSingular = Console.ReadLine().Split(' ');
            int subarrayLenght = rowSingular.Length;
            jaggedArray[i] = new char[subarrayLenght];

            for (int j = 0; j < subarrayLenght; j++)
            {
                jaggedArray[i][j] = rowSingular[j][0];
            }
        }

        return jaggedArray;
    }

    static void PrintJaggedArrayToStdOutput(char[][] tab)
    {

        // Console.WriteLine($"{tab[1][0]}, {tab[1][1]}");
        int subarrayCount = tab.Length;

        int subarrayLength;

        for (int i = 0; i < subarrayCount; i++)
        {
            subarrayLength = tab[i].Length;
            for (int j = 0; j < subarrayLength; j++)
            {
                Console.Write($"{tab[i][j]}" + " ");
            }
            Console.WriteLine();
        }

    }

    static char[][] TransposeJaggedArray(char[][] tab)
    {
        int maxCol = 0;

        for (int i = 0; i < tab.Length; i++)
        {
            if (tab[i].Length > maxCol)
            {
                maxCol = tab[i].Length;
            }
        }


        // Console.Write($"maxCol: {maxCol}");

        char[][] jaggedArray;
        jaggedArray = new char[maxCol][];
        int rowsCount = tab.Length;

        for (int col = 0; col < maxCol; col++)
        {
            jaggedArray[col] = new char[rowsCount];

            for (int row = 0; row < rowsCount; row++)
            {
                jaggedArray[col][row] = (col < tab[row].Length) ? tab[row][col] : ' ';
            }
        }

        
        return jaggedArray;   
    }



    static void Main(string[] args)
    {
        char[][] jagged = ReadJaggedArrayFromStdInput();
        Console.WriteLine("----");
        PrintJaggedArrayToStdOutput(jagged);
        Console.WriteLine("--Transposes: --");
        jagged = TransposeJaggedArray(jagged);
        Console.WriteLine();
        PrintJaggedArrayToStdOutput(jagged);
    }


}




