#nullable disable

var o = new Osoba("Kowalski",
                "Jan",
                new DateOnly(1901,1,1) 
                 );


Console.WriteLine(o);
// o.nazwisko = "Abacki";
Console.WriteLine(o);
// o.pesel = "12345";
Console.WriteLine(o + $" pesel: {o.pesel}");