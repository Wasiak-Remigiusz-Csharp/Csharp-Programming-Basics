// ------------------------------------------------ WZORKI ----------------------------------------------//

// ----------------------------------    Przykładu    ----------------------------------//
// Przykładu  -> PROSTOKĄT



// class Program
// {
//     const char CHAR = '*';
//     static void Star() => Console.Write(CHAR);
//     static void StarLn() => Console.WriteLine(CHAR);
//     static void Space() => Console.Write(" ");
//     static void SpaceLn() => Console.WriteLine(" ");
//     static void NewLine() => Console.WriteLine();

//     public static void Prostokat( int n, int m )
//     {
//         for( int i = 0; i<n; i++)
//         {
//             Star();
//         }
//         NewLine();
//       //   Console.WriteLine("a");

//         for (int j = 1; j < m-1; j++)
//         {
//             Star();
//             for (int i = 1; i < n - 1; i++)
//                 Space();

//             StarLn();
//              //   Console.WriteLine("a");
//         }

//         for (int i = 0; i < n; i++)
//         {
//             Star();
//         }
//          //   Console.WriteLine("a");
//         NewLine();

//     }

//     public static void Main(string[] args)
//     {
//         Prostokat(5, 7);
//     }
// }


// Console.Write("Write");
// Console.WriteLine("WriteLine");
// Console.Write("Write");
// Console.Write("Write");
// Console.Write("Write");
// Console.Write("Write");
// Console.WriteLine("WriteLine");
// Console.WriteLine("WriteLine");
// Console.WriteLine();



// ----------------------------------    Przykładu    ----------------------------------//
// Przykładu  -> Litera X

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


//         for (int i = 0; i < n; i++)
//         {
//             for (int j = 0; j < n; j++)
//             {
//                 if (i == j  ||  j + i == n - 1)
//                 // if (  j + i == n - 1)
//                    Star();
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








// ----------------------------------    Przykładu    ----------------------------------//
// Przykładu  -> Litera V

// class Program
// {
//     const char CHAR = '*';
//     static void Star() => Console.Write(CHAR);
//     static void StarLn() => Console.WriteLine(CHAR);
//     static void Space() => Console.Write(" ");
//     static void SpaceLn() => Console.WriteLine(" ");
//     static void NewLine() => Console.WriteLine();

//     static void LiteraX(int n)
// {
//     if (n < 3) throw new ArgumentException("zbyt mały rozmiar");
//     if (n % 2 == 0) n = n + 1;

//     //górna połówka
//     for (int i = 0; i < n / 2; i++)
//     {
//         for (int j = 0; j < i; j++)
//             Space();
//         Star();
//         for (int j = 0; j < n - 2 - 2 * i; j++)
//             Space();
//         StarLn();
//     }

//     //pojedyncza gwiazdka w środku

//     //dolna połówka, symetrycznie do górnej
// }


//       static void Main(string[] args)
//    {
//       LiteraX(11);
//     //   Console.WriteLine("------------");
//     //   LiteraX(8);
//    }
// }
