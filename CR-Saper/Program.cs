// CR: Odsłoń planszę (Saper)

// Napisz program, który wczyta ze standardowego wejścia prostokątną planszę gry Saper (ang. minswepper), 
// a następnie wprowadzi do odpowiednich komórek planszy liczby określające liczbę przylegających min.

// Przyjmujemy, że plansza jest prostokątem o zadanych rozmiarach (nie większych niż 8) 
// składającym się z komórek, do których wprowadzone są znaki:

// -    kropki . oznaczającej pole nieodsłonięte,
// -    gwiazdki * oznaczającej minę,
// -    cyfry oznaczającej liczbę przylegających min.

// Twoim zadaniem jest "odsłonić" całą planszę. Przyjmujemy, że jeśli komórka nie przylega do żadnej miny, pozostawiamy znak kropki. 
// Sugeruj się podanymi przykładami.

// -    Na wejściu, w pierwszym wierszu podane są dwie liczby oddzielone jedną spacją, określające 
// -    wymiary planszy: liczbę wierszy i liczbę kolumn odpowiednio
// -    W kolejnych wierszach "narysowana" jest plansza gry za pomocą kropek i gwiazdek
// -    Na wyjściu wypisana jest plansza, zapełniona w odpowiedni sposób liczbami.

// -    For example:

// Input	|   Result
//--------------------------
// 4 5          1*3*1
// .*.*.        13*31
// ..*..        .2*2.
// ..*..        .111.
// .....
//--------------------------
// 4 4          *1..
// *...         221.
// ....         1*1.
// .*..         111.
// ....
//--------------------------
// 3 5          **1..
// **...        332..
// .....        1*1..
// .*...    
//--------------------------



using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{

    static char Dot()  // kropki . oznaczającej pole nieodsłonięte,
    {
        char dot = '.';
        return dot;
    }

    static char Star() // gwiazdki * oznaczającej minę,
    {
        char star = '*';
        return star;
    }

     static char numberMinesAround(int count) //cyfry oznaczającej liczbę przylegających min.
    {
        // char number  = n.ToString()[0];
        // return number;
        return count.ToString()[0];
    }

    static int CountMines(string[,] matrix, int currentI, int currentJ, int maxRowInput, int maxColInput)
    {

        int row = currentI;
        int col = currentJ;

        // Console.WriteLine($"Current matrix - index[{row},{col}]");

        // string[,] matrix = matrix;

        int previousRow = row - 1;
        int previousCol = col - 1;

        int nextRow = row + 2;

        int nextCol = col + 2;

        int minRow = 0;
        int minCol = 0;

        int maxRow = maxRowInput - 1;
        int maxCol = maxColInput - 1;

        int count = 0;


        for (int i = previousRow; i < nextRow; i++)
        {
            for (int j = previousCol; j < nextCol; j++)
            {
                
                    if ( i ==row && j ==col ||i<  minRow || j<  minCol || i> maxRow || j> maxCol )
                        continue;
                    else
                    {
                        if (matrix[i,j] == "*")
                        {
                            count++;
                        }
                    }
                // Console.Write($"index[{i},{j}]" + " ");
            }
            // Console.WriteLine();
        }
        // Console.WriteLine(count);

        return count;
    }



    static string[,] ReadMatrixArrayFromStdInput(int rows, int cols)
    {
        string[,] inputGameBoard = new string[rows,cols];

        for (int i = 0; i < rows; i++)
        {
            string input = Console.ReadLine();
            for (int j = 0; j < cols; j++)
            {
                inputGameBoard[i,j] = input[j].ToString();
            }
        }

        return inputGameBoard;
    }

    static void PrintMatrixArrayToStdOutput(string[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i,j]}");
            }
            Console.WriteLine();
        }
    }


    static string[,] ConvertMatrixArrayFromStdInput(string[,] matrix)
    {
        string[,] resultMatrix = new string[matrix.GetLength(0),matrix.GetLength(1)];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                
                if (matrix[i,j] == "*")
                {
                    resultMatrix[i,j] = matrix[i,j];
                }
                else
                {
                    // Console.WriteLine($" ---------------Begore count: index[{i},{j}]");
                    int minesNumer = CountMines(matrix, i, j, matrix.GetLength(0), matrix.GetLength(1));
                    // int count = 2;



                    // Console.WriteLine($"minesNumer: {minesNumer}");
                    if (minesNumer > 0)
                    {
                        // Console.WriteLine($"Inside if (minesNumer > 0)");
                        // Console.WriteLine($"Inside if (minesNumer > 0) minesNumer: {minesNumer}");
                        resultMatrix[i,j] = numberMinesAround(minesNumer).ToString();
                        // resultMatrix[i,j] = minesNumer.ToString();
                    }
                    else
                    {
                        // Console.WriteLine($"Inside else of (minesNumer > 0)");
                        resultMatrix[i,j] = Dot().ToString();
                    }
                    //  resultMatrix[i,j] = Dot().ToString();
                    //  resultMatrix[i,j] = "1";

                }
            }
        }

        return resultMatrix;
    }




    public static void Main(string[] args)
    {
        // Input
        int[] inputSizes = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
        int rows = inputSizes[0];
        int cols = inputSizes[1];

        string[,] inputGameBoard = ReadMatrixArrayFromStdInput(rows,cols);

        // Console.WriteLine("---- Print Matrix ----");
        // Print Matrix
        // PrintMatrixArrayToStdOutput(inputGameBoard);

        string[,] outputGameBoard = ConvertMatrixArrayFromStdInput(inputGameBoard);


        // int row = 0;
        // int col = 0;

        // string[,] matrix = inputGameBoard;

        // int previousRow = row - 1;
        // int previousCol = col - 1;

        // int nextRow = row + 2;
        // int nextCol = col + 2;

        // int minRow = 0;
        // int minCol = 0;

        // int maxRow = 9;
        // int maxCol = 8;

        // int count = 0;


        // for (int i = previousRow; i < nextRow; i++)
        // {
        //     for (int j = previousCol; j < nextCol; j++)
        //     {
                
        //             if ( i ==row && j ==col ||i<  minRow || j<  minCol || i> maxRow || j> maxCol )
        //                 continue;
        //             else
        //             {
        //                 if (matrix[i,j] == "*")
        //                 {
        //                     count++;
        //                 }
        //             }
        //         Console.Write($"index[{i},{j}]" + " ");
        //     }
        //     Console.WriteLine();
        // }
        // Console.WriteLine(count);





        // Console.WriteLine("---- Print Result Matrix ----");
        // Print Matrix
        PrintMatrixArrayToStdOutput(outputGameBoard);


    }
}