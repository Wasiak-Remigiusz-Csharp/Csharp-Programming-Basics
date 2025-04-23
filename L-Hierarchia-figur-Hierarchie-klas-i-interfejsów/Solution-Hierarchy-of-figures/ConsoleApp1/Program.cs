using System;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using FiguryLib;

class Program
{
    public static void Main(string[] args)
    {
        // Figura
        //Figura f = new Figura(Color.Red);

        //Figura g = new Figura();
        //g.Kolor = Color.Blue;


        //// Kwadrat
        ////Kwadrat k = new Kwadrat();
        //Kwadrat k = new Kwadrat(5, ConsoleColor.Cyan);
        //k.Rysuj();
        //Console.WriteLine(k);
        ////Console.WriteLine($"Pole: {k.Pole}");


        //// Prostokat
        ////Prostokat p = new Prostokat();
        //var p = new Prostokat(5, 10, ConsoleColor.Cyan, "Prostokącik");
        //p.Rysuj();
        //Console.WriteLine(p);
        //Console.WriteLine($"Pole: {p.Pole}");



        // 
        Prostokat p1 = new Prostokat(5, 3, ConsoleColor.Green, "P1");
        Prostokat p2 = new Prostokat(3, 5, ConsoleColor.Yellow, "P2");

        Kwadrat k1 = new Kwadrat(5, ConsoleColor.Red, "K1");
        Kwadrat k2 = new Kwadrat(3, ConsoleColor.Blue, "K2");

        Punkt p = new Punkt( 1,1, ConsoleColor.White, "P");

        Figura[] figuty = new Figura[] { p1,p2,k1,k2,p};


        double suma = 0.0;
        foreach (var figura in figuty)
        {
            Console.WriteLine(figura);
            figura.Rysuj();

            if (figura is IMierzalna2D)
            {
                Console.WriteLine($"Pole figury: {((IMierzalna2D)figura).Pole}");
                suma += ((IMierzalna2D)figura).Pole;
            }
            
            Console.WriteLine();
            Console.WriteLine(suma);

        }


    }
}
