// R: Czas24h (properties)

// Klasa Czas24h
// Jesteś praktykantem w firmie informatycznej. Otrzymałeś zadanie zmodyfikowania klasy Czas24h napisanej w języku C#.

// Obiekty klasy Czas24h reprezentują czas, t.j.: godzinę, minutę i sekundę w zapisie 24-godzinnym, w formacie h:mm:ss (np. 2:20:05). 
// Wewnętrznie czas jest zapamiętany jako liczba sekund, które upłynęły od godziny początkowej 0:00:00 - w prywatnym polu liczbaSekund (patrz kod).

// Twoim zadaniem jest zmodyfikować załączony kod klasy Czas24h tak, aby:

// w konstruktorze nie dopuścić do utworzenia obiektu - zgłaszając wyjątek ArgumentException - w sytuacji przekazania niewłaściwych danych. 
// Dopuszczalne wartości parametrów to: 0..59 dla sekund i minut, 0..23 dla godzin,
// obiekty klasy Czas24h były zmiennicze (mutable) poprzez poprawne zdefiniowanie properties typu set dla godzin, minut i sekund (patrz kod).
// nie wolno modyfikować istniejącego kodu - jedynie uzupełniasz brakujące fragmenty (wskazane komentarzem).
// Poniżej załączono kod klasy Czas24h, który będziesz modyfikować.



using System;
using System.Globalization;

namespace MyProg
{
    public class Czas24h
{
    private int liczbaSekund;
 
    public int Sekunda
    {
        get => liczbaSekund - Godzina * 60 * 60 - Minuta * 60;
        // uzupełnij kod - zdefiniuj setters'a
    }
 
    public int Minuta
    {
        get => (liczbaSekund / 60) % 60;
        // uzupełnij kod - zdefiniuj setters'a
    }
 
    public int Godzina
    {
        get => liczbaSekund / 3600;
        // uzupełnij kod - zdefiniuj setters'a
    }
 
    public Czas24h(int godzina, int minuta, int sekunda)
    {
        // uzupełnij kod zgłaszając wyjątek ArgumentException
        // w sytuacji niepoprawnych danych
 
        liczbaSekund = sekunda + 60 * minuta + 3600 * godzina;
    }
 
    public override string ToString() => $"{Godzina}:{Minuta:D2}:{Sekunda:D2}";
}

    public class Program
    {
        public static void Main(string[] args)
        {
            // TEST.testcode - tutaj wstawiamy kod testowy
            var t = new Czas24h(2, 15, 37);
            // t.Minuta = 20;
            // t.Godzina = 1;
            // t.Sekunda = 26;
            Console.WriteLine(t);

        }
    }
}
