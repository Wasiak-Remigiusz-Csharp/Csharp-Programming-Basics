#nullable disable
namespace BankLibrary
{
    public class Konto
    {
        public decimal Saldo { get; private set; }
        public string Nazwa { get; private set; }

        public bool JestZablokowane { get; set; } = false;

        public Konto(string nazwa, decimal saldoPoczatkowe)
        {
            Nazwa = nazwa;
            Saldo = saldoPoczatkowe;
            //JestZablokowane = false;
        }

        public void Zablokuj() => JestZablokowane = true;
        public void Odblokuj() => JestZablokowane = false;


        public void Wplac(decimal kwota)
        {
            if (JestZablokowane)
                throw new ArgumentException();
            Saldo += kwota;
        }

        public void Wyplac(decimal kwota)
        {
            if (JestZablokowane || Saldo < kwota)
                throw new ArgumentException();
            Saldo -= kwota;
        }

        override public string ToString()
        {
            return $"{Nazwa}: {Saldo} PLN, blokada: {JestZablokowane}";
        }
    }
}
