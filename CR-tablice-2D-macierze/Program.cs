// // CR: Seria zadań - tablice 2D (macierze)

// // -------------------------------- ZADANIE nr 1 --------------------------------//

// Napisz program, który wczyta ze standardowego wejścia tablicę liczb całkowitych i wypisze 
// na standardowe wyjście jej transpozycję (zamiana wierszy na kolumny).

// Na wejściu, w pierwszej linii podane będą dwie dodatnie liczby n oraz m oddzielone pojedynczą spacją, 
// oznaczające odpowiednio liczbę wierszy oraz liczbę kolumn wczytywanej tablicy. Liczby n oraz m nie przekroczą wartości 10.
// W kolejnych liniach podane będą ciągi liczb całkowitych oddzielonych pojedynczą spacją, 
// oznaczające kolejne wiersze wczytywanej tablicy.
// Na wyjściu wypisz, w kolejnych liniach, ciągi liczb oddzielonych pojedynczą spacją, 
// będące kolejnymi wierszami tablicy po transpozycji.

// For example:

// Input  |	Result
// ---------------
// 2 3    |  1 4
// 1 2 3  |  2 5
// 4 5 6  |  3 6


using System;

public class Program
{
    public static void Main(string[] args)
    {

        string[] input = Console.ReadLine().Split(" ");
        int n = int.Parse(input[0]);
        int m = int.Parse(input[1]);



        // Matrix
        int [,] matrix = new int[n,m];

        for (int i = 0; i < n; i++)
        {
            string[] inputRow = Console.ReadLine().Split(" ");

            for (int j = 0; j < m; j++)
            {
                matrix[i,j] = int.Parse(inputRow[j]);
            }
        }


        // Console.WriteLine("Matrix:");
        // for (int i = 0; i < n; i++)
        // {
        //     for (int j = 0; j < m; j++)
        //     {
        //         Console.Write(matrix[i,j] + " ");
        //     }

        //     Console.WriteLine();
        // }


        // Console.WriteLine("Matrix Transposition:");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                // Console.WriteLine($"i; {i}  - j; {j}");
                // Console.Write(matrix[i,j] + " ");
                Console.Write(matrix[j, i] + " ");
                // Console.Write("1 ");
            }
            // Console.WriteLine("-------");
            Console.WriteLine();
        }
        

    }
}








// // -------------------------------- ZADANIE nr 2 --------------------------------//


// Napisz program, który wczyta ze standardowego wejścia dwie tablice liczb całkowitych (A i B) 
// i wypisze na standardowe wyjście ich iloczyn macierzowy (A x B) (https://pl.wikipedia.org/wiki/Mno%C5%BCenie_macierzy).

// Na wejściu, w pierwszej linii podane są dwie dodatnie liczby n1 oraz m1 oddzielone pojedynczą spacją, 
// oznaczające odpowiednio liczbę wierszy oraz liczbę kolumn wczytywanej macierzy A. Liczby n1 oraz m1 nie przekroczą wartości 10.
// W drugiej linii podane są wartości macierzy A (liczby jednocyfrowe oddzielone pojedynczą spacją).
// W trzeciej linii podane są dwie dodatnie liczby n2 oraz m2 oddzielone pojedynczą spacją, oznaczające 
// odpowiednio liczbę wierszy oraz liczbę kolumn wczytywanej macierzy B. Liczby n2 oraz m2 nie przekroczą wartości 10.
// W czwartej linii podane są wartości macierzy B (liczby jednocyfrowe oddzielone pojedynczą spacją).
// Na wyjściu wypisz, w kolejnych liniach, ciągi liczb oddzielonych pojedynczą spacją, będące kolejnymi 
//wierszami iloczynu macierzy A x B. Jeśli operacja mnożenia nie będzie możliwa, wypisz napis impossible.

// For example:

// Input    |	Result
// ---------------
// 2 2          3 3
// 1 2 3 4
// 2 2          7 7
// 1 1 1 1
// ---------------
// 1 3          4 2
// 1 2 3
// 3 2
// 1 0 0 1 1 0
// ---------------
// 1 3          impossible
// 3 4 5
// 1 2
// 8 9
// ---------------


// using System;

// public class Program
// {
//     static void outputMatrix(int[,] matrix)
//     {

//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 Console.Write(matrix[i,j] + " ");
//             }
//             Console.WriteLine();
//         }

//     }
//     public static void Main(string[] args)
//     {


//         // pierwsza linia -- MatrixA
//         string[] inputMatrixA = Console.ReadLine().Split(" ");
//         int n1 = int.Parse(inputMatrixA[0]);
//         int m1 = int.Parse(inputMatrixA[1]);

//         // druga linia
//         string[] dataMatrixA = Console.ReadLine().Split(" ");


//         // MatrixA
//         int [,] matrixA = new int[n1,m1];
//         int valueMtxA = 0;

//         for (int i = 0; i < n1; i++)
//         {

//             for (int j = 0; j < m1; j++)
//             {
//                 matrixA[i,j] = int.Parse(dataMatrixA[valueMtxA]);
//                 Console.Write(matrixA[i,j] + " ");
//                 valueMtxA++;
//                 // matrixA[i,j] = 1;
//                 // Console.Write("1 ");

//             }
//             Console.WriteLine();
            
//         }


//         Console.WriteLine("------------------------------");


//         // trzecia linia -- MatrixB
//         string[] inputMatrixB = Console.ReadLine().Split(" ");
//         int n2 = int.Parse(inputMatrixB[0]);
//         int m2 = int.Parse(inputMatrixB[1]);

//         // czwarta linia
//         string[] dataMatrixB = Console.ReadLine().Split(" ");


//         int [,] matrixB = new int[n2,m2];
//         int valueMtxB = 0;

//         for (int i = 0; i < n2; i++)
//         {

//             for (int j = 0; j < m2; j++)
//             {
//                 matrixB[i,j] = int.Parse(dataMatrixB[valueMtxB]);
//                 Console.Write(matrixB[i,j] + " ");
//                 valueMtxB++;
//                 // matrixA[i,j] = 1;
//                 // Console.Write("1 ");

//             }
//             Console.WriteLine();
            
//         }

//         Console.WriteLine("-------------- Matrix multiplication ----------------");

//         // Matrix multiplication
//         if (m1 == n2)
//         {
//             // MatrixA
//             int [,] matrixC = new int[n1,m2];

//             for (int i = 0; i < n1; i++)
//             {
//                 for (int j = 0; j < m2; j++)
//                 {
//                     // Console.Write("1 ");
//                     for (int z = 0; z < m1; z++)
//                     {
//                         matrixC[i,j] += matrixA[i,z] * matrixB[z,j];
//                     }   
//                 }
//                 // Console.WriteLine();
//             }

//             outputMatrix(matrixC);

//         }
//         else{
//             Console.WriteLine("impossible");
//         }



//     }
// }



// // -------------------------------- ZADANIE nr 3 --------------------------------//

// Napisz program, który wczyta ze standardowego wejścia prostokątną tablicę liczb całkowitych, 
// a następnie wypisze indeks kolumny o największej sumie. Jeśli kolumn z największą sumą będzie więcej, 
// wypisze indeks najmniejszy. Przyjmujemy 0-based indexing.

// Na wejściu, w kolejnych liniach (wartość nieokreślona) podane będą j
// ednakowej długości ciągi liczb całkowitych (liczby jednocyfrowe, oddzielone jedną spacją).
// Na wyjściu: jedna liczba całkowita określająca indeks kolumny o największej sumie (pierwszy).
// Podpowiedź:

// 1) ponieważ nie wiesz, ile wierszy będzie liczyła tablica danych, 
// musisz skorzystać z dynamicznej struktury danych. Najwygodniejszą wydaje się lista tablic List<int[]>, której 
//później można używać w podobny sposób, jak dla tablic dwuwymiarowych. Odczytując kolejne wiersze możesz je splitować do 
//tablicy liczb całkowitych, a następnie tę tablicę doklejać do listy (Add). Gdy wczytasz wszystkie dane możesz odwoływać 
// się do jej konkretnych elementów za pomocą indeksowania [i][j].

// 2) innym sposobem rozwiązania problemu może być wykorzystanie koncepcji jagged_array oraz metody Array.Resize().

// For example:

// Input	|   Result
// ---------------
// 1 2 3 4      3
// 1 1 1 1
// ---------------
// 1 3          1
// 3 2
// ---------------
// 1            0
// 2
// 3
// ---------------


// using System;
// using System.Collections.Generic;
// using System.Linq;

// public class Program
// {
    
//     public static void Main(string[] args)
//     {


//         List<int[]> rowsInput = new List<int[]>();

//         string consoleLine;

//         while ((consoleLine = Console.ReadLine()) != null && consoleLine.Trim() !="" )
//         // while ((line = Console.ReadLine()) != "2" )
//         {
//             int[] rowSingular = consoleLine.Split(' ').Select(int.Parse).ToArray();
//             rowsInput.Add(rowSingular);
//         }

//         if (rowsInput.Count == 0)
//         {
//             Console.WriteLine("no data");
//         }

//         // Console.WriteLine("---------------");

//         // Converting a list to a matrix

//         int rowsCount = rowsInput.Count;
//         int colsCount = rowsInput[0].Length;
//         int [,] matrix = new int[rowsCount, colsCount];

//         // Console.WriteLine($"rowsCount: {rowsCount}");
//         // Console.WriteLine($"colsCount: {colsCount}");

//         for (int i = 0; i < rowsCount; i++)
//         {
//             for (int j = 0; j < colsCount; j++)
//             {
//                 matrix[i,j] = rowsInput[i][j];
//             }
//         }


//         // Console.WriteLine("--------------- Printing Matrix ------------------");

//         // for (int i = 0; i < rowsCount; i++)
//         // {
//         //     for (int j = 0; j < colsCount; j++)
//         //     {
//         //         Console.Write(matrix[i,j] + " ");
//         //     }
//         //     Console.WriteLine();
//         // }
        

//         // Console.WriteLine("--------------- Matrix Transposition ------------------");


//         int matrixTranspositionRows = colsCount;
//         int matrixTranspositionCols = rowsCount;
//         int [,] matrixTransposition = new int[matrixTranspositionRows, matrixTranspositionCols];
//         // int [,] matrixTransposition = new int[colsCount, rowsCount];


//         for (int i = 0; i < matrixTranspositionRows; i++)
//         {
//             for (int j = 0; j < matrixTranspositionCols; j++)
//             {
//                 // Console.WriteLine($"i; {i}  - j; {j}");
//                 // Console.Write(matrix[i,j] + " ");
//                 // Console.Write(matrix[j, i] + " ");
//                 // Console.Write("1 ");
//                 matrixTransposition[i,j] = matrix[j, i];
//             }
//             // Console.WriteLine("-------");
//             // Console.WriteLine();
//         }


//         // Console.WriteLine("--------------- Printing Matrix Transposition ------------------");

//         // for (int i = 0; i < matrixTranspositionRows; i++)
//         // {
//         //     for (int j = 0; j < matrixTranspositionCols; j++)
//         //     {
//         //         Console.Write(matrixTransposition[i,j] + " ");
//         //     }
//         //     Console.WriteLine();
//         // }


//         // Sum
//         int iterationSum = 0;
//         int sumMax = 0;
//         int iteration = 0;



//         for (int i = 0; i < matrixTranspositionRows; i++)
//         {
//             // sumMax = 0;
//             iterationSum = 0;
//             for (int j = 0; j < matrixTranspositionCols; j++)
//             {
//                 iterationSum += matrixTransposition[i,j];
//                 // Console.WriteLine($"iterationSum: {iterationSum}");
//             }


//             // Console.WriteLine($"sumMax: {sumMax}");
//             // Console.WriteLine($"i: {i}");
//             // Console.WriteLine($"iterationSum: {iterationSum}");
//             // Console.WriteLine($"sumMax: {sumMax}");
//             // Console.WriteLine("-----------");

//             if (iterationSum > sumMax)
//             {
//                 sumMax = iterationSum;
//                 iteration = i;
//             }

//         }

//         // Console.WriteLine($"sumMax: {sumMax}  -- iteracja: {iteration}");
//         Console.WriteLine(iteration);

//     }
// }
