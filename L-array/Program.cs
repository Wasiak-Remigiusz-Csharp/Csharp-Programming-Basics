// int[] tab1D;
// int[,] tab2D;
// int[,,] tab3D;

// int[]    arr2  = new int[4];
// string[] mcArr = new string[4];
// int[,,]  arr3  = new int[3,6,2];


// int[] tab1Da = new int[4] { 10, 20, 30, 40 };
// int[] tab1Db = new int[]  { 10, 20, 30, 40 };
// int[] tab1Dc =            { 10, 20, 30, 40 };

// Console.WriteLine( $"tab1Da: {tab1Da}, Length={tab1Da.Length}" );
// Console.WriteLine( $"tab1Db: {tab1Db}, Length={tab1Db.Length}" );
// Console.WriteLine( $"tab1Dc: {tab1Dc}, Length={tab1Dc.Length}" );


// //
// Console.WriteLine("--");
// int[,] tab2Da = new int[3,2] { {10, 1}, {2, 10}, {11, 9} };
// int[,] tab2Db = new int[,]   { {10, 1}, {2, 10}, {11, 9} };
// int[,] tab2Dc =              { {10, 1}, {2, 10}, {11, 9} };
// int[,] tab2Dd = {
//                   {10, 1},
//                   {2, 10},
//                   {11, 9}
//                 };
// Console.WriteLine( $"tab2Da: \n" +
//                    $" Type = {tab2Da.GetType()} \n" +
//                    $" Length = {tab2Da.Length} \n" +
//                    $" Rank = {tab2Da.Rank} \n" +
//                    $" GetLength(0) = {tab2Da.GetLength(0)} \n" +
//                    $" GetLength(1) = {tab2Da.GetLength(1)}");



//
// Console.WriteLine("----");

// var tab = new int[] { 1, 2, 3 };
// tab[0] = 4; // zmiana wartości elementu o indeksie 0
//             //teraz tablica składa się z elementów {4, 2, 3}
// tab.SetValue( 5, 1 ); // ustawiasz wartość 5 dla elementu o indeksie 1
//                       //teraz tablica składa się z elementów {4, 5, 3}
// Console.WriteLine( $"tab[0]={tab[0]}");
// Console.WriteLine( $"tab[1]={tab[1]}");
// Console.WriteLine( $"tab[2]={tab[2]}");



// Console.WriteLine("--------");
// Console.WriteLine("Iterowanie po elementach tablicy");

//// Przeglądanie indeksowane "w przód":
// var tab = new int[] { 1, 2, 3 };
// for(int i = 0; i < tab.Length; i++)
// {
//   Console.WriteLine( $"tab[{i}]={tab[i]}");
// }

// // Przeglądanie indeksowane "wstecz":
// var tab = new int[] { 1, 2, 3 };
// for(int i = tab.Length-1; i >= 0; i--)
// {
//   Console.WriteLine( $"tab[{i}]={tab[i]}");
// }


// // Przeglądanie co drugiego elementu:
// var tab = new int[] { 1, 2, 3, 4 };
// for(int i = 0; i < tab.Length; i=i+2 )
// {
//   Console.WriteLine( $"tab[{i}]={tab[i]}");
// }



// // Przeglądanie tablicy 2-wymiarowej (zagnieżdżenie pętli):
// int[,] tab2D = {
//                   {10, 1},
//                   {2, 10},
//                   {11, 9}
//                };

// for( int row = 0; row < tab2D.GetLength(0); row++ )
// {
//   for( int col = 0; col < tab2D.GetLength(1); col++ )
//   {
//     Console.Write( tab2D[row, col] + " ");
//   }
//   Console.WriteLine();
// }




// // UWAGA: odwołanie się do elementu o indeksie spoza dozwolonego zakresu spowoduje zgłoszenie wyjątku IndexOutOfRangeException:

// int[,] tab2D = {
//                   {10, 1},
//                   {2, 10},
//                   {11, 9}
//                };

// for( int row = 0; row < 2; row++ ) // omyłkowo, zamiast 3 wstawiono 2
//   for( int col = 0; col < 3; col++ ) // omyłkowo, zamiast 2 wstawiono 3
//     Console.WriteLine( tab2D[row, col]);



// // Jeśli nie zależy Ci na informacji o położeniu elementu w tablicy oraz nie będziesz zmieniał wartości elementu w tablicy, 
// // a chcesz przeglądnąć wszystkie elementy tablicy, możesz zastosować pętlę foreach.
// int[,] tab2D = {
//                   {10, 1},
//                   {2, 10},
//                   {11, 9}
//                };

// foreach( var x in tab2D )
// {
//   if( x % 2 == 0 )
//     Console.Write(x + " ");
// }




// Console.WriteLine("--------");
// Console.WriteLine("Tablice postrzępione");

// int[][] Arr; //deklaracja - tablica postrzępiona
//              //             liczb całkowitych
//              //             o wymiarze 2
// Arr = new int [3][]; //1. Instancja najwyższego poziomu
// Arr[0] = new int[] {10, 20, 30}; // 2. Instancja podtablicy
// Arr[1] = new int[] {40, 50, 60, 70}; // 3. Instancja kolejnej podtablicy
// Arr[2] = new int[] {80, 90, 100, 110, 120};  // 4. Instancja ostatniej podtablicy




// Taka organizacja elementów w tablicach postrzępionych wymaga uważnego ich przeglądania. 
// Możemy bowiem napotkać null zamiast oczekiwanej podtablicy oraz podtablice mogą być różnych rozmiarów.

// int[][] Arr = new int[3][]
//               {
//                   new int[] {1, 2, 3},
//                   null,
//                   new int[] {5, 6 }
//               };
// for( int i = 0; i < Arr.Length; i++ )
// {
//   Console.Write( $"Arr[{i}] = " );
//   if( Arr[i] is null )
//     Console.Write("null");
//   else
//     for( int j = 0; j < Arr[i].Length; j++ )
//       Console.Write( Arr[i][j] + " ");
  
//   Console.WriteLine();
// }


// // Oczywiście możliwe jest utworzenie tablicy, zawierającej tablice 2-wymiarowe (np. tablica zdjęć).

// int[][,] Arr = new int[3][,] {new int[,] { {10, 20}, {100, 200} },
//                               new int[,] { {30, 40, 50}, {300, 400, 500} },
//                               new int[,] { {60, 70, 80, 90}, {600, 700, 800, 800} }
//                              };
// // Wyswietla elementy tablicy:
// for (int i = 0; i < Arr.GetLength(0); i++)
// {
//   for (int j = 0; j < Arr[i].GetLength(0); j++)  
//   {
//       for (int k = 0; k < Arr[i].GetLength(1); k++)
//           Console.Write($"Arr[{i}] [{j},{k}]: {Arr[i][j, k]}   ");
//       Console.WriteLine();
//   }
//   Console.WriteLine();
// }





// Console.WriteLine("--------");
// Console.WriteLine("Pętla foreach w tablicach postrzępionych");


// // Ponieważ tablice postrzępione są tablicami tablic, należy oddzielnie przetwarzać je pętlami foreach.

// int[][] Arr = new int[3][]
//               {
//                   new int[] {1, 2, 3},
//                   null,
//                   new int[] {5, 6}
//               };

// foreach( int[] subArray in Arr )
// {
//   int sum = 0;
//   if( subArray is null )
//     continue;  
//   foreach( var x in subArray )
//   {
//     sum += x;
//   }
//   Console.WriteLine( $"sum = {sum}" );
// }



// // Przykład 1 - sortowanie, odwracanie
// int[] arr = new int[] { 15, 20, 5, 25, 10 };
// // String.Join() łączy separator z każdym elementem tablicy
// Console.WriteLine( "Oryginalna: " + String.Join(", ", arr) );

// Array.Sort(arr);
// Console.WriteLine( "Po sortowaniu: " + String.Join(", ", arr) );

// Array.Reverse(arr);
// Console.WriteLine( "Po odwroceniu: " + String.Join(", ", arr) );

// Console.WriteLine();
// Console.WriteLine($"Rank = { arr.Rank }, Length = { arr.Length }");
// Console.WriteLine($"GetLength(0)     = { arr.GetLength(0) }");
// Console.WriteLine($"GetType()        = { arr.GetType() }");



// Przykład 2 - konwersja wszystkich elementów na inny typ
//Zamiana tekstu zawierającego ciąg liczb na tablicę liczb

// string napis1 = "1 23 3 2 15 6 3 8";
// string[] tablicaNapisow1 = napis1.Split( new char[] {' '},
//                                     StringSplitOptions.RemoveEmptyEntries
//                                   );
// int[] tablica1 = Array.ConvertAll( tablicaNapisow1, int.Parse );
// Console.WriteLine( String.Join(", ", tablica1) );

// string napis2 = "1, 23, 3, 2, 15, 6, 3, 8";
// string[] tablicaNapisow2 = napis2.Split( new char[] {',', ' '},
//                                     StringSplitOptions.RemoveEmptyEntries
//                                   );
// int[] tablica2 = Array.ConvertAll( tablicaNapisow2, int.Parse );
// Console.WriteLine( String.Join(", ", tablica2) );



// Przykład 3 - wyszukiwanie elementu w tablicy
// Find, FindAll, FindLast - zwraca znaleziony element, lub - jeśli nie znaleziono -
// wartość domyślną typu.

// FindIndex, FindLastIndex - zwraca index znalezionego elementu, lub - jeśli nie znaleziono - zwraca -1.

// Exists - sprawdza, czy element spełniający określony predykat jest w tablicy

// // W powyższych funkcjach należy podać predykat - funkcję sprawdzającą określony warunek logiczny
// // i zwracającą true lub false. Najczęściej podaje się ja w zapisie lambda, np. x => (x==10).

// var los = new Random();
// int[] tab = new int[15];
// for(int i = 0; i < tab.Length; i++)
//   tab[i] = los.Next(1, 10); //liczba pseudolosowa z zakresu 1..9



// for(int i = 0; i < tab.Length; i++)
// {
//   Console.WriteLine( $"tab[{i}]={tab[i]}");
// }


// Console.WriteLine( $"Array.Find: {Array.Find( tab, x => (x==4) )}" ); //nie znaleziono, wynik default(int)

// Console.WriteLine($"Array.FindIndex: {Array.FindIndex( tab, x => (x==7) )}"  ); //nie znaleziono, wynik -1

// Console.WriteLine( $"Array.Exists: {Array.Exists( tab, x => (x==10) ) }"); //nie znaleziono, wynik false

// Console.WriteLine( $"Array.Find {Array.Find( tab, x => (x > 5) )}" );

// Console.WriteLine( "Liczba wystapien liczby  = " +
//                     Array
//                     .FindAll( tab, x => (x == 9) )
//                     .Length
//                   );



// // Przykład 4 - szybkie wyszukiwanie, algorytm binsearch
// // Dla n-elementowej tablicy nieuporządkowanej, przeszukanie jej wymaga n iteracji.

// // Jeśli jednak tablica jest posortowana, proces wyszukiwania elementu można skrócić znacząco (O(log2(n))), 
// // stosując algorytm wyszukiwania połówkowego Binarysearch. Jeśli elementu nie ma, zwracany jest wynik -1.

// // UWAGA: dla tablicy nieposortowanej wynik działania algorytmu może być (najczęściej jest) błędny.

// var los = new Random();
// int[] tab = new int[15];
// for(int i = 0; i < tab.Length; i++)
//   tab[i] = los.Next(1, 4); //liczba pseudolosowa z zakresu 1..99999




// Console.WriteLine( Array.Find( tab, x => (x==10) ) );

// Console.WriteLine( Array.FindIndex( tab, x => (x==10) ) );

// Console.WriteLine( Array.Exists( tab, x => (x==10) ) );

// Array.Sort( tab );

// // for(int i = 0; i < tab.Length; i++)
// // {
// //   Console.WriteLine( $"tab[{i}]={tab[i]}");
// // }
// Console.WriteLine( Array.BinarySearch( tab, 2 ) );





//  --  Array.Count  --  //

using System;
// using System.Linq;

public class Program
{
    public static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5, 2 };
        int elementToCheck = 3;

        // bool isUnique = arr.Count(x => x == elementToCheck) == 1;  
        bool isUnique = arr.Count(x => x == elementToCheck) == 1;  

        Console.WriteLine(isUnique ? $"{elementToCheck} is unique" : $"{elementToCheck} is not unique");
    }
}
