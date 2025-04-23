
namespace FiguryLib
{
    public class Punkt : Figura
    {
        public int X {  get; set; }
        public int Y { get; set; }

        public Punkt()
        {
            Nazwa = "Punkt";
            Kolor = ConsoleColor.White;
        }

        public Punkt(int x  = 0, int y = 0, ConsoleColor kolor=ConsoleColor.White, string nazwa = null) 
            : base(kolor, nazwa)
        {
            X = x;
            Y = y;
        }

        public override void Rysuj()
        {
            Console.ForegroundColor = Kolor;
            Console.WriteLine(".");
            Console.ResetColor();
        }

        public override string ToString()
        {
            return $"Punkt o nazwie {Nazwa} i kolorze {Kolor}";
        }

        //public override void Przesun(int dx, int dy)
        //{
        //    X += dx;
        //    Y += dy;
        //}

        public void Przesun(int dx, int dy)
        {
            X += dx;
            Y += dy;
        }
    }
}
