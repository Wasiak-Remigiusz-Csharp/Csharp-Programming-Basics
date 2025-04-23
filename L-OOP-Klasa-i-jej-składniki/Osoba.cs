#nullable disable
public class Osoba
{
    // dane
    private string nazwisko;
    
    private string imie;

    public string Imie
    {
        get => imie;
        private set => imie = value.Trim().ToUpper();
    }

    public readonly string pesel;

    // public DateOnly DataUrodzenia {get;  private set;}
    private DateOnly dataUrodzenia;

    public DateOnly DataUrodzenia 
    {
        get => dataUrodzenia;
        private set
        {
            if (value.Year <1900)
            {
                throw new ArgumentOutOfRangeException(nameof(value),
                            "Data urodzenia nie może być wcześniejsza niż 1900");
            }
        }
    }
    // public DateOnly DataUrodzenia {get;  init;}

    // konstruktor
    public Osoba(string nazwisko, string imie, DateOnly dataUrodzenia)
    {
        this.nazwisko = nazwisko;
        this.imie = imie;
        this.pesel = GenerujPESEL();
        DataUrodzenia = dataUrodzenia;
    }

    // tekstowa reprezentacja obiektu
    public override string ToString()
    {
        return $"{imie} {nazwisko}";
    }

    // medoty
    private string GenerujPESEL()
    {
        // DataUrodzenia = new DateOnly(2000,1,1);
        return "12345678901";
    }

}