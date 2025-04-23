// CR: Sprawdź Sudoku

// Napisz program, który sprawdzi czy podana tabela 9x9 jednocyfrowych liczb całkowitych jest prawidłowym rozwiązaniem łamigłówki Sudoku.

// Wejście:

// 9 linii, w każdej linii 9 cyfr (od 1 do 9) oddzielonych pojedynczą spacją
// Wyjście:

// napis yes jeśli podany zestaw stanowi poprawne rozwiązanie Sudoku, w przeciwnym przypadku napis no
// UWAGA: piszesz cały program, odczytujący ze standardowego wejścia i piszący na standardowe wyjście.

// For example:

// Input	          |     Result
//---------------------------------
// 2 5 1 7 6 9 3 4 8        yes
// 9 8 6 3 4 5 2 7 1
// 3 7 4 8 2 1 6 9 5
// 4 2 9 6 3 8 5 1 7
// 8 6 3 5 1 7 9 2 4
// 5 1 7 4 9 2 8 3 6
// 7 9 5 1 8 3 4 6 2
// 1 4 2 9 5 6 7 8 3
// 6 3 8 2 7 4 1 5 9
//---------------------------------
// 2 5 1 7 6 9 3 4 8        no
// 9 8 6 3 4 5 2 7 1
// 3 7 4 8 2 1 6 9 5
// 4 2 9 6 3 8 5 1 7
// 8 6 3 5 1 7 9 2 4
// 5 1 7 4 9 2 8 3 6
// 7 9 5 1 8 3 4 6 2
// 1 4 2 9 5 6 7 8 3
// 6 3 8 2 7 4 1 9 5
//---------------------------------


using System;
using System.Collections.Generic;
using System.Linq;


public class Prgram
{

    static int[,] ReadMatrixArrayFromStdInput()
    {

        // int rowCount = 3;
        // int colsCount = 3;
        int rowCount = 9;
        int colsCount = 9;

        int [,] matrix = new int[rowCount,colsCount];


        for (int row = 0; row < rowCount; row++)
        {
            string[] input = Console.ReadLine().Split(" ");

            for (int col = 0; col < colsCount; col++)
            {
                matrix[row,col] = int.Parse(input[col]);
            }
        }

        return matrix;
    }


    static void PrintMatrixArrayToStdOutput(int[,] matrix)
    {

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i,j]}" + " ");
            }
            Console.WriteLine();
        }
    }


    static bool CheckRowsSum(int[,] matrix)
    {

        bool isSolution = false;
        int correctSum = 45;
        

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int rowSum = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                rowSum += matrix[i,j];
            }
            // Console.WriteLine($"rowSum[{i}]: {rowSum}");

            if (rowSum != correctSum)
            {
                return isSolution = false;
            }
        }

        isSolution = true;

        return isSolution;
    }



    static bool CheckColssSum(int[,] matrix)
    {

        bool isSolution = false;
        int correctSum = 45;
        

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int colSum = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                colSum += matrix[j,i];
            }
            // Console.WriteLine($"colSum[{i}]: {colSum}");

            if (colSum != correctSum)
            {
                return isSolution = false;
            }
        }

        isSolution = true;

        return isSolution;
    }


    static bool CheckSquaresSum(int[,] matrix)
    {

        bool isSolution = false;
        int correctSum = 45;

        int rows = 0;
    
        while (rows < 9)
        {
            // Console.WriteLine($"rows: {rows}");
            int rowsPlusThree = rows + 3;
            int cols = 0;

            int squareSum = 0;
            while (cols < 9)
            {
                int colsPlusThree = cols + 3;
                for (int i = rows; i < rowsPlusThree; i++)
                {
                    // Console.WriteLine($"----i: {i}");

                    for (int j = cols; j < colsPlusThree; j++)
                    {
                        // Console.WriteLine($"--------INDEX: i: {i}, j: {j}");
                        squareSum += matrix[j,i];
                    }

                }
                cols +=3;

                // Console.WriteLine($"--------------------end 3*3-------------------");

                // Console.WriteLine($"--------squareSum: {squareSum}");
                if (squareSum != correctSum)
                {   
                    isSolution = false;
                    return isSolution;
                }
                squareSum = 0;
            }
            rows +=3;
        }

        isSolution = true;
        return isSolution;
    }



    static void Main(string[] args)
    {
        // Matrix
        string isSolution = "no";

        int[,] matrix = ReadMatrixArrayFromStdInput();

        // Console.WriteLine("----- PrintMatrixArrayToStdOutput: ------");
        // // Print Matrix
        // PrintMatrixArrayToStdOutput(matrix);

        // Console.WriteLine("----- CheckRowsSum: ------");
        // Check rows sum
        bool isrowsSumCorrect = CheckRowsSum(matrix);
        // Console.WriteLine(isrowsSumCorrect);

        // Console.WriteLine("----- CheckColssSum: ------");
        // Check rows sum
        bool isColsSumCorrect = CheckColssSum(matrix);
        // Console.WriteLine(isColsSumCorrect);


        // Console.WriteLine("----- CheckSquaresSum: ------");
        // Check rows sum
        bool isSquaresSumCorrect = CheckSquaresSum(matrix);
        // Console.WriteLine($"isSquaresSumCorrect: {isSquaresSumCorrect}");


        // Console.WriteLine("----- isSolution: ------");

        if (isrowsSumCorrect == true && isColsSumCorrect == true && isSquaresSumCorrect== true)
        {
            isSolution = "yes";
        }else
        {
            isSolution = "no";
        }
        
        Console.WriteLine(isSolution);


    }

}
