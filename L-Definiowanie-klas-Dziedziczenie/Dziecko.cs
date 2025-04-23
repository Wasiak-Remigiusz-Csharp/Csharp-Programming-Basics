public class Dziecko : Osoba
{
    // dane

    public Osoba Matka {get; }
    public Osoba Ojciec {get; set; }



    // konstruktor
    public Dziecko(
        // string nazwisko,
        string imie,
        DateOnly dataUrodzenia,
        Osoba matka,
        Osoba ojciec = null
        )
    // : base(nazwisko, imie, dataUrodzenia
    : base(matka.Nazwisko, imie, dataUrodzenia
    )

    {
        Matka = matka;
        Ojciec = ojciec;
        if (Ojciec!=null)
        {
            Nazwisko += $"-{Ojciec.Nazwisko}";
        }
    }


        
    // tekstowa reprezentacja obiektu
    public override string ToString()
    {
        return $"{Imie} {Nazwisko} ({Wiek})" + "\n" +
                $"-- Matka: {Matka}"+ "\n" +
                $"-- Ojciec: {Ojciec}";
    }






}