using BibliotekaKolekcji;

var s = new StosWTablicy<string>();

s.Push("Ala");
s.Push("ma");
s.Push("kota");
//s.

foreach (var element in s.ToArray())
{
    Console.Write(element + " ");
}
Console.WriteLine();


while (!s.IsEmpty)
{
    var element= s.Pop();
    Console.WriteLine(element);
}