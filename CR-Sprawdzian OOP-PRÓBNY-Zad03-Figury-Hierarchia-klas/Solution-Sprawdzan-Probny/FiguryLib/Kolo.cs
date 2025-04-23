using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguryLib
{
    public class Kolo : Okrag, IMierzalna2D
    {
        public Kolo() : this(new Punkt(0, 0), 2)
        {
        }

        public Kolo(Punkt srodek, int promien) : base(srodek, promien)
        {
            DefaultColor = ConsoleColor.Red;
        }

        public double Pole => Math.PI * Promien * Promien;

        public double Obwod => this.Dlugosc;

        public override string ToString() => $"K({Srodek}, {Promien})";


        new public void Rysuj()
        {
            Console.ResetColor();
            Console.ForegroundColor = this.DefaultColor;
            Console.WriteLine($"K({Srodek}, {Promien}) obwod={Obwod:F2}, pole={Pole:F2}");
            Console.ResetColor();
        }
    }

}
