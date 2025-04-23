// BONUS - SPOJ: Zadanie - DIGNUM - Digital LED Number

// Twoim zadaniem jest rozwiązanie problemu na SPOJ: DIGNUM - Digital LED Number.


using System;
using System.Globalization;
using System.Linq;
using System.Text;

namespace LedNumbers
{
    class Program
    {


        static void PrintLedsNumber(string[,] inputNumbers, int cols)
        {
            // Variables
            int digitHeight = 3;

            string[,] matrixLedsNumbers = {
                        {" _ ", "| |", "|_|"}, // 0
                        {"   ", "  |", "  |"}, // 1
                        {" _ ", " _|", "|_ "}, // 2
                        {" _ ", " _|", " _|"}, // 3
                        {"   ", "|_|", "  |"}, // 4
                        {" _ ", "|_ ", " _|"}, // 5
                        {" _ ", "|_ ", "|_|"}, // 6
                        {" _ ", "  |", "  |"}, // 7
                        {" _ ", "|_|", "|_|"}, // 8
                        {" _ ", "|_|", "  |"}, // 9
            };


            int column = 0;
            int col = 0;

            StringBuilder output = new StringBuilder(); 
            
            while (column < cols)
            {
                string[,] singNumbMatrix = new string[3,1];
                for (int i = 0; i < digitHeight; i++)
                {
                    for (int j = col; j < col+1; j++)
                    {
                        singNumbMatrix[i,0] = inputNumbers[i,j];
                    }
                }
                column++;
                col++;
                
                for (int i = 0; i < 10; i++)
                {
                    if (singNumbMatrix[0,0] ==matrixLedsNumbers [i,0]
                        && singNumbMatrix[1,0] ==matrixLedsNumbers [i,1]
                        && singNumbMatrix[2,0] ==matrixLedsNumbers [i,2])
                    {
                        output.Append(i.ToString());
                    }
                }
            }
            Console.WriteLine(output);
        }


        static void Main()
        {

            // Variables
            int oneDigitLen = 3;
            int digitHeight = 3;

            List<string> inputLine = new List<string>();
            string digits;
            int input = 0;

            while ((digits = Console.ReadLine())!=null)
            {
                inputLine.Add(digits);
            }

            for (int i = 0; i < inputLine.Count; i+=digitHeight)
            {
                var group = inputLine.Skip(i).Take(digitHeight).ToList();


                int cols;
                int inpDigitLen;
                try
                {
                    inpDigitLen = group[0].Length;
                }
                catch (NullReferenceException )
                {
                    
                    return;
                }

                cols= inpDigitLen / oneDigitLen;
                string[,] inputMatrix = new string[digitHeight, cols];

                
                foreach (var (item, index) in group.Select((value, index) => (value, index)))
                {
                    int colMatrix = 0;
                    for (int j = 0; j < item.Length; j=j+3)
                    {
                        string digit;
                        int startDigit = j;
                        int endDigit = j+3;
                        string numDigit = "";
                        

                        while (startDigit < endDigit )
                        {
                            numDigit = numDigit + item[startDigit];
                            startDigit++;
                        }
                        inputMatrix[index, colMatrix] = numDigit;
                        colMatrix++;
                    }
                }

                PrintLedsNumber(inputMatrix , cols);

            } 
            

        }

    }
}