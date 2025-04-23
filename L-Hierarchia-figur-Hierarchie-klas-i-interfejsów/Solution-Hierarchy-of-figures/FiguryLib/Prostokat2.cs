#nullable disable
namespace FiguryLib
{
    public class Prostokat2 : Figura
    {
        private Kwadrat kwadrat;

        private int _bok1;
        public int Bok1 
        {
            get => _bok1;
            set
            {
                _bok1 = value; 
                kwadrat.Bok = value; 
            }
        
        }
        public int Bok2 { get; set; }


        public Prostokat2( int bok1 = 1, int bok2 = 2 ,
                            ConsoleColor kolor = ConsoleColor.Red,
                            string nazwa = null)
        {
            Bok1 = bok1;
            Bok2 = bok2;

            kwadrat = new Kwadrat(Bok1, ConsoleColor.Blue);
        }

        public override void Rysuj()
        {
            Console.ForegroundColor = Kolor;
            if (Bok1==Bok2)
                kwadrat.Rysuj();
            else
                for (int i = 0; i < Bok2; i++)
                {
                    for (int j = 0; j < Bok1; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                Console.ResetColor();

        }

        public override string ToString()
        {
            return $"Prostokąt o bokach {Bok1} i {Bok2} i kolorze {Kolor}";
        }

    }
}
