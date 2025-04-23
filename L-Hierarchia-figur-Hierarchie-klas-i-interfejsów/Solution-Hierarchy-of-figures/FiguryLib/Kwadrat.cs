

namespace FiguryLib
{
    public class Kwadrat : Figura , IMierzalna2D
    //sealed public class Kwadrat : Figura, IMierzalna
    {
        public int Bok {  get; set; }

        public virtual double Pole => Bok * Bok;

        // konstruktor  --> bezargumentowy:
        public Kwadrat() : base()
        {
            Bok = 1;
            Nazwa = "Kwadrat";
            Kolor = ConsoleColor.Yellow;
        }

        // konstruktor  --> argumentowy:
        public Kwadrat( int bok, ConsoleColor kolor, string nazwa = null)  : base(kolor, nazwa)
        {
            Bok = bok;
        }


        public override void Rysuj()
        {
            Console.ForegroundColor = Kolor;

            for (int i = 0; i < Bok; i++)
            {
                for (int j = 0; j < Bok; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ResetColor();
        }

        

    }
}
