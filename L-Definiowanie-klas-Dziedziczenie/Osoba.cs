#nullable disable

public class Osoba
{
    // Dane

    // private string Nazwisko {get; init;}
    private string _nazwisko;
    public string Nazwisko 
    {
        get
        {
            return _nazwisko;
        }
         set
        {
            if(string.IsNullOrWhiteSpace(value))
            throw new ArgumentException(
                nameof(value),
                    "nazwisko nie może być null, puste lub składać się z samych białych znaków"
            );
            _nazwisko = value;
        }
    }

    // C# style
    private string imie;
    public string Imie
    {
        get => imie;
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentNullException(nameof(value), "Imię nie może być null, puste ani zawierać tylko spacji.");

            imie = value.Trim().ToUpper();
            if (imie.Length < 2)
                throw new ArgumentOutOfRangeException(nameof(value), "Imię musi mieć co najmniej 2 znaki.");

            if (!imie.All(c => char.IsLetter(c)))
                throw new ArgumentOutOfRangeException(nameof(value), "Imię może składać się tylko z liter.");
        }
    }


    public readonly string pesel;

    private DateOnly dataUrodzenia;

    public DateOnly DataUrodzenia 
    {
        get => dataUrodzenia;
        private set
        {
            if (value == null)
            {
                throw new ArgumentOutOfRangeException(nameof(value),
                            "Data urodzenia nie może być null");
            }

            if (value.Year <1900)
            {
                throw new ArgumentOutOfRangeException(nameof(value),
                            "Data urodzenia nie może być wcześniejsza niż 1900");
            }

            dataUrodzenia = value;
        }
    }

    // konstruktor
    public Osoba(string nazwisko, string imie, DateOnly dataUrodzenia)
    {
        Nazwisko = nazwisko;
        Imie = imie;
        this.pesel = GenerujPESEL();
        DataUrodzenia = dataUrodzenia;
    }

    // public int Wiek()
    // {
    //     var dzisiaj = DateTime.Today;
    //     var wiek =  dzisiaj.Year - DataUrodzenia.Year;
    //     return wiek;
    // }

    public int Wiek => DateTime.Today.Year - DataUrodzenia.Year;
    // public int Wiek() => DateTime.Today.Year - DataUrodzenia.Year;
    
    // tekstowa reprezentacja obiektu
    public override string ToString()
    {
        return $"{Imie} {Nazwisko} ({Wiek})";
    }


    // medoty
    private string GenerujPESEL()
    {
        // DataUrodzenia = new DateOnly(2000,1,1);
        return "12345678901";
    }
}


