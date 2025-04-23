using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotekaKolekcji
{
    public class StosEmptyException : Exception
    {
        public StosEmptyException() { }

        public StosEmptyException(string message) : base(message) { }  
    }
}
