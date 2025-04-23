public class Czas24h
{
    private int liczbaSekund;

    public int Sekunda
    {
        get => liczbaSekund - Godzina * 60 * 60 - Minuta * 60;

        // uzupełnij kod - zdefiniuj setters'a
        set 
        {
            if (value < 0 || value > 59)
            {
                throw new ArgumentException("error");
            }
            liczbaSekund = (Godzina * 60 * 60) + (Minuta * 60) + value;

        }
    }

    public int Minuta
    {
        get => (liczbaSekund / 60) % 60;

        // uzupełnij kod - zdefiniuj setters'a
        set 
        {
            if (value < 0 || value > 59)
            {
                throw new ArgumentException("error");
            }
            liczbaSekund = (Godzina * 60 * 60) + (value * 60) + Sekunda;

        }
    }

    public int Godzina
    {
        get => liczbaSekund / 3600;

        // uzupełnij kod - zdefiniuj setters'a
         set 
        {
            if (value < 0 || value > 23)
            {
                throw new ArgumentException("error");
            }
            liczbaSekund = (value * 60 * 60) + (Minuta * 60) + Sekunda;

        }
    }

    public Czas24h(int godzina, int minuta, int sekunda)
    {
        // uzupełnij kod zgłaszając wyjątek ArgumentException
        // w sytuacji niepoprawnych danych
        if (godzina < 0 || godzina > 23 || 
            minuta < 0 || minuta > 59 || 
            sekunda < 0 || sekunda > 59)
                throw new ArgumentException("error");

        liczbaSekund = sekunda + 60 * minuta + 3600 * godzina;
    }

    public override string ToString() => $"{Godzina}:{Minuta:D2}:{Sekunda:D2}";
}