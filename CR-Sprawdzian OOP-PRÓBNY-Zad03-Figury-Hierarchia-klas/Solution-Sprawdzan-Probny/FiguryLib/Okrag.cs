using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguryLib
{

    public class Okrag : Figura, IMierzalna1D
    {

        public Punkt Srodek { get; set; }



        private int promien;
        public int Promien
        {
            get => promien;
            //set => promien = (value <0) ? 0: promien = value;
            set
            {
                if (value < 0)
                    promien = 0;
                else
                    promien = value;
            }
        }

        //public Okrag()
        //{
        //    Srodek = new Punkt(0,0);
        //    Promien = 1;

        //}


        public Okrag() : this(new Punkt(0, 0), 1)
        {
        }

        public Okrag(Punkt srodek, int promien)
        {
            if (srodek == null)
            {
                throw new ArgumentException("Punkt nie może być null");
            }

            Srodek = srodek;
            Promien = promien;
            DefaultColor = ConsoleColor.Cyan;
        }

        public double Dlugosc
        {
            get
            {
                return 2 * Math.PI * promien;
            }
        }

        public override string ToString() => $"O({Srodek}, {Promien})";

        public override void Rysuj()
        {
            Console.ResetColor();
            Console.ForegroundColor = this.DefaultColor;
            Console.WriteLine($"O({Srodek}, {Promien}) dlugosc={Dlugosc:F2}");
            Console.ResetColor();
        }


    }
}
