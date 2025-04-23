public class Czas24h
{
    private int liczbaSekund;

    public int Sekunda
    {
        get => liczbaSekund - Godzina * 3600 - Minuta * 60;
        set
        {
            if (value < 0 || value > 59)
                throw new ArgumentException("Invalid value for Sekunda");
            liczbaSekund = Godzina * 3600 + Minuta * 60 + value;
        }
    }

    public int Minuta
    {
        get => (liczbaSekund / 60) % 60;
        set
        {
            if (value < 0 || value > 59)
                throw new ArgumentException("Invalid value for Minuta");
            liczbaSekund = Godzina * 3600 + value * 60 + Sekunda;
        }
    }

    public int Godzina
    {
        get => liczbaSekund / 3600;
        set
        {
            if (value < 0 || value > 23)
                throw new ArgumentException("Invalid value for Godzina");
            liczbaSekund = value * 3600 + Minuta * 60 + Sekunda;
        }
    }

    public Czas24h(int godzina, int minuta, int sekunda)
    {
        if (godzina < 0 || godzina > 23 || minuta < 0 || minuta > 59 || sekunda < 0 || sekunda > 59)
            throw new ArgumentException("Invalid values for Czas24h");

        liczbaSekund = sekunda + 60 * minuta + 3600 * godzina;
    }

    public override string ToString() => $"{Godzina}:{Minuta:D2}:{Sekunda:D2}";
}
