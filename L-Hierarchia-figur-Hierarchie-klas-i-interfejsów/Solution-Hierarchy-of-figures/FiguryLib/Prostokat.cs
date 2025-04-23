
namespace FiguryLib
{
    public class Prostokat : Kwadrat
    {
        public int Bok2 {get; set;}
        override public double Pole => Bok * Bok2;
        //new public double Pole => Bok * Bok2;

        // konstruktor  --> bezargumentowy:
        public Prostokat()
        {
            Bok2 = 1;
            Nazwa = "Prostokat";
            Kolor = ConsoleColor.Red;
        }

        // konstruktor  --> argumentowy:
        public Prostokat(int bok, int bok2, ConsoleColor kolor, string nazwa = null) 
            : base(bok, kolor, nazwa)
        {
            Bok2 = bok2;
        }


        public override void Rysuj()
        {
            Console.ForegroundColor = Kolor;

            for (int i = 0; i < Bok2; i++)
            {
                for (int j = 0; j < Bok; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ResetColor();
        }

        public override string ToString()
        {
            return $"Prostokąt o bokach {Bok} i {Bok2}, o nazwie {Nazwa} i kolorze {Kolor}";
        }

    }
}
