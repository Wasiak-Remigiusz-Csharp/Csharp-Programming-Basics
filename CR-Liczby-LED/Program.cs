//  BONUS - CR: Liczby LED

// Napisz program, który dla wczytanej ze standardowego wejścia liczby całkowitej bez znaku 
// wypisze ją (na standardowe wyjście) przy użyciu cyfr LED. Do zapisu cyfr LED użyto tylko 
// trzech znaków: spacji, podkreślenia _ oraz pionowej kreski |. 
// Cyfry zawsze mają tę samą wysokość (3) oraz szerokość (3). Między cyframi nie ma dodatkowych odstępów.

// Sugeruj się poniższymi przykładami.

// 232095
//  _  _  _  _  _  _ 
//  _| _| _|| ||_||_ 
// |_  _||_ |_|  | _|

// 164610
//     _     _     _ 
//   ||_ |_||_   || |
//   ||_|  ||_|  ||_|


// 799518
//  _  _  _  _     _ 
//   ||_||_||_   ||_|
//   |  |  | _|  ||_|


//   Wejście:

// liczba całkowita bez znaku
// Wyjście:

// zapis liczby przy użyciu cyfr LED
// Jeśli rozwiązałeś to zadanie, nie powinien sprawić Ci kłopotu problem "odwrotny" - opublikowany na SPOJ: DIGNUM - Digital LED Number.

// Rozwiązanie zadania jest testowane na podanych przykładach, jak 
// również na innych, nie podanych zestawach testowych.

// ⚠️ Każdorazowe wysłanie zadania do wstępnej oceny (przycisk Sprawdź) skutkuje odjęciem punktów (kara) za 
// rozwiązanie niepełne, nie przechodzące wszystkich testów, zgodnie ze skalą kar.

// ⚠️ Aby przesłać finalnie zadanie do oceny musisz kliknąć przycisk Zatwierdź i zakończ. 
// Twoje rozwiązanie i ocena (uwzględniające dotychczasowe próby) zostaną zapamiętane.

// ⚠️ Nie dziel się kodem. Możesz pomóc, podpowiedzieć, ale nie udostępniaj całego kodu. 
// Pozwól innym nauczyć się programowania!

// Input	|   Result
// 232095
            //  _  _  _  _  _  _ 
            //  _| _| _|| ||_||_ 
            // |_  _||_ |_|  | _|
// 164610
            //     _     _     _ 
            //   ||_ |_||_   || |
            //   ||_|  ||_|  ||_|
// 799518
                //  _  _  _  _     _ 
                //   ||_||_||_   ||_|
                //   |  |  | _|  ||_|



using System;

namespace LedNumbers
{
    class Program
    {


        static void PrintLedsNumber(string inputNumbers)
        {
            // Variables
            int currentNumber;
            int ledNumberHeight = 3;

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



         

            for (int i = 0; i < ledNumberHeight; i++)
            {
                for (int j = 0; j < inputNumbers.Length; j++)
                {
                    // Console.Write(inputNumbers[j]);
                    currentNumber = (int)char.GetNumericValue(inputNumbers[j]);
                    Console.Write(matrixLedsNumbers[currentNumber,i]);

                }
                Console.WriteLine();
            }

        }
        static void Main()
        {

            // Twój kod

            // Variables
            string inputNumbers = Console.ReadLine();

            PrintLedsNumber(inputNumbers);
        }
    }
}