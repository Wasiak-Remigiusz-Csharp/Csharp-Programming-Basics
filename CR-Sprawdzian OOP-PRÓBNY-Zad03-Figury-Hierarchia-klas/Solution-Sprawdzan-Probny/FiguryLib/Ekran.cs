using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguryLib
{
    public class Ekran
    {
        private List<Figura> figury = new List<Figura>();
        public void Dodaj(Figura f) => figury.Add(f);
        public void Usun(Figura f) => figury.Remove(f);
        public void Rysuj() => figury.ForEach(f => f.Rysuj());

        public double SumarycznaDlugosc()
        {
            double sum = 0;
            foreach (var f in figury)
            {
                if (f is IMierzalna1D d)
                {
                    sum += d.Dlugosc;
                }
            }
            return Math.Round(sum, 2);
        }
        public double SumarycznePole()
        {
            double sum = 0;
            foreach (var f in figury)
            {
                if (f is IMierzalna2D d)
                {
                    sum += d.Pole;
                }
            }
            return Math.Round(sum, 2);
        }
    }
}
