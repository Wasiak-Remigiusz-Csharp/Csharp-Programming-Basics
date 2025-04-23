using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FiguryLib
{
    internal class Odcinek : Figura, IMierzalnosc1D
    {
        public Punkt PunktStartowy {  get; set; }
        public Punkt PunktKoncowy { get; set; }

        public double Dlugosc =>
            Math.Sqrt(Math.Pow(PunktKoncowy.X - PunktStartowy.X, 2) + Math.Pow(PunktKoncowy.Y - PunktStartowy.Y, 2));



        //public Odcinek(Punkt punktStartowy, Punkt punktKoncowy, ConsoleColor kolor, string nazwa = null)
        public Odcinek(Punkt punktStartowy, Punkt punktKoncowy, ConsoleColor kolor, string nazwa)
        {
            PunktStartowy = punktStartowy;
            PunktKoncowy = punktKoncowy;
            Kolor = kolor;
            Nazwa = nazwa;
        }

        public override void Rysuj()
        {
            Console.ForegroundColor = Kolor;
            Console.WriteLine($"Rysuję odcinek od {PunktStartowy} do {PunktKoncowy}");
            Console.ResetColor();
        }

        //public override void Przesun(int dx, int dy)
        //{
        //    PunktStartowy.Przesun( dx, dy);
        //    PunktKoncowy.Przesun(dx, dy);
        //}

        public  void Przesun(int dx, int dy)
        {
            PunktStartowy.Przesun(dx, dy);
            PunktKoncowy.Przesun(dx, dy);
        }
    }
}
