using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguryLib
{
    public interface IMierzalna2D : IMierzalna1D
    {
        double Pole { get; }
        double Obwod { get; }
    }
}
