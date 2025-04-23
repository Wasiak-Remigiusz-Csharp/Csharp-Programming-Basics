#nullable disable
//using System.Drawing;

namespace FiguryLib
{
    abstract public class Figura // : IPrzesuwalna
    {
        public ConsoleColor Kolor {  get; set; }
        public string Nazwa { get; set; } // Label  --> etykieta


        // konstruktor  --> bezargumentowy:
        public Figura()
        {
            Kolor = ConsoleColor.White;
            Nazwa = "Figura";
        }


        // konstruktor  --> argumentowy:
        public Figura(ConsoleColor kolor, string nazwa = null)
        {
            Kolor = kolor;
            Nazwa = nazwa;
        }

        public override string ToString()
        {
            return $"Figura nieznana o nazwie {Nazwa} i kolorze {Kolor}";
        }

        //public void Rysuj()
        //{

        //}

        abstract public void Rysuj();

        public void ResetujKolor()
        {
            Kolor = ConsoleColor.White;
        }

        //abstract public void Przesun(int dx, int dy);

        //abstract public void Przesun(int dx,  int dy);


    }
}
