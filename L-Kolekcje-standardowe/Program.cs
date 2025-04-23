// Lab. C#. Kolekcje standardowe

using System;
using System.Collections.Generic;

class Program
{   
    static void DisplaySet<T>(ISet<T> set) 
    {
        Console.WriteLine("DisplaySet: " + string.Join(", ",set));
    }
    public static void Main()
    {
        //  --------------------------------------------------------------------------------------------------------------------------\\
        //  --------------------------------------               Zadanie 1. Lista              -------------------------------------- \\

        // Utwórz listę elementów typu string reprezentującą zwyczajowe nazwy gatunków zwierząt (np. kot, pies, ...).


        Console.WriteLine("\n" + "Utwórz listę elementów typu string reprezentującą zwyczajowe nazwy gatunków zwierząt (np. kot, pies, ...).");
        var zwierzaki = new List<string>();


        // Dodaj do niej co najmniej 5 elementów.
        Console.WriteLine("\n" + "Dodaj do niej co najmniej 5 elementów.");
        zwierzaki.Add("pies");

        string[] inneZwierzaki = {"kot", "krowa" , "kaczka","mysz"};
        zwierzaki.AddRange(inneZwierzaki);


        // Wydrukuj zawartość listy na konsoli.
        Console.WriteLine("\n" + "Wydrukuj zawartość listy na konsoli.");
        // Console.WriteLine(zwierzaki);

        foreach (var zwierzak in zwierzaki)
        {
            Console.WriteLine(zwierzak);
        }


        // var wszystkieZwierzaki = string.Join(", ", zwierzaki);
        var wszystkieZwierzaki = ""; 
        wszystkieZwierzaki = string.Join(", ", zwierzaki);
        Console.WriteLine("string.Join: " + wszystkieZwierzaki);

        // Usuń z listy element ostatni oraz element drugi.
        Console.WriteLine("\n" + "Usuń z listy element ostatni oraz element drugi.");
        Console.WriteLine("zwierzaki.Count: " + zwierzaki.Count);
        zwierzaki.RemoveAt(zwierzaki.Count - 1);
        zwierzaki.RemoveAt(1);



        // Ponownie wydrukuj zawartość listy na konsoli.
        Console.WriteLine("\n" + "Ponownie wydrukuj zawartość listy na konsoli.");
        wszystkieZwierzaki = string.Join(", ", zwierzaki);
        Console.WriteLine("string.Join: " + wszystkieZwierzaki);


        // Wstaw na koniec listy element mucha.
        Console.WriteLine("\n" + "Wstaw na koniec listy element mucha.");
        zwierzaki.Add("mucha");


        // Wstaw na pozycji 1 element gazela.
        Console.WriteLine("\n" + "Wstaw na pozycji 1 element gazela.");
        zwierzaki.Insert(1,"gazela");


        // Ponownie wydrukuj zawartość listy na konsoli.
        Console.WriteLine("\n" + "Ponownie wydrukuj zawartość listy na konsoli.");
        Console.WriteLine(string.Join(", ", zwierzaki));



        // Usuń z listy element gazela.
        Console.WriteLine("\n" + "Usuń z listy element gazela.");
        zwierzaki.Remove("gazela");


        // Ponownie wydrukuj zawartość listy na konsoli.
        Console.WriteLine("\n" + "Ponownie wydrukuj zawartość listy na konsoli.");
        Console.WriteLine(string.Join(", ", zwierzaki));

        // Wypisz na konsoli true jeśli element krowa jest na liście, w przeciwnym przypadku wypisz false.
        Console.WriteLine("\n" + "Wypisz na konsoli true jeśli element krowa jest na liście, w przeciwnym przypadku wypisz false.");
        Console.WriteLine(zwierzaki.Contains("krowa"));



        // Wypisz na konsoli indeks elementu mucha.
        Console.WriteLine("\n" + "Wypisz na konsoli indeks elementu mucha.");
        Console.WriteLine(zwierzaki.IndexOf("mucha"));


        // Odwróć kolejność elementów na liście i wypisz ma konsoli zawartość listy.
        Console.WriteLine("\n" + "Odwróć kolejność elementów na liście i wypisz ma konsoli zawartość listy.");
        zwierzaki.Reverse();


        // Posortuj listę w kolejności rosnącej i wypisz ją. Wykorzystamy domyślny sposób porównywania napisów.
        Console.WriteLine("\n" + "Posortuj listę w kolejności rosnącej i wypisz ją. Wykorzystamy domyślny sposób porównywania napisów.");
        zwierzaki.Sort();
        foreach (var zwierzak in zwierzaki)
        {
            Console.WriteLine(zwierzak);
        }


        // Posortuj listę w kolejności malejącej i wypisz ją. Wskazówka: argumentem metody sortującej będzie obiekt typu Comparison<string>, czyli funkcja porównująca: (x,y) => y.CompareTo(x).
        Console.WriteLine("\n" + "Posortuj listę w kolejności malejącej i wypisz ją. Wskazówka: argumentem metody sortującej będzie obiekt typu Comparison<string>, czyli funkcja porównująca: (x,y) => y.CompareTo(x).");
        zwierzaki.Sort((x,y) => y.CompareTo(x)); // Sortyje malejąco
        // zwierzaki.Sort((x,y) => x.CompareTo(y)); // Sortyje rosnąco
        foreach (var zwierzak in zwierzaki)
        {
            Console.WriteLine(zwierzak);
        }



        // Dodatkowe: Posortuj listę w kolejności od najkrótszego do najdłuższego napisu. Jeśli napisy są tej samej długości, przyjmij naturalny porządek zdefiniowany w typie string.
        Console.WriteLine("\n" + "Dodatkowe: Posortuj listę w kolejności od najkrótszego do najdłuższego napisu. Jeśli napisy są tej samej długości, przyjmij naturalny porządek zdefiniowany w typie string.");
        // Console.WriteLine(zwierzaki);
        zwierzaki.Add("aaaa");
        // zwierzaki.Sort((x,y)=> x.Length.CompareTo(y.Length));
        zwierzaki.Sort((x,y)=> x.Length ==y.Length ? x.CompareTo(y): x.Length.CompareTo(y.Length));

        foreach (var zwierzak in zwierzaki)
        {
            Console.WriteLine(zwierzak);
        }




        //  --------------------------------------------------------------------------------------------------------------------------\\
        //  --------------------------------------           Zadanie 2. Kolejka i stos          -------------------------------------- \\
        Console.WriteLine("//  --------------------------------------           Zadanie 2. Kolejka i stos          -------------------------------------- \\");

        // => Dokumentacja klasy Stack<T>
        // => Dokumentacja klasy Queue<T>


        // 1. Utwórz pustą kolejkę i pusty stos napisów (typu string).
        Console.WriteLine("\n" + "1. Utwórz pustą kolejkę i pusty stos napisów (typu string).");
        var kolejka = new Queue<string>();
        var stos = new Stack<string>();

        // 2. Wstaw na stos kolejno elementy: 1, 2, 3, 4.
        Console.WriteLine("\n" + "2. Wstaw na stos kolejno elementy: 1, 2, 3, 4.");
        stos.Push("1");
        stos.Push("2");
        stos.Push("3");
        stos.Push("4");


        //3.  Wstaw do kolejki kolejno elementy: a, b, c, d.
        Console.WriteLine("\n" + "3.  Wstaw do kolejki kolejno elementy: a, b, c, d.");
        kolejka.Enqueue("a");
        kolejka.Enqueue("b");
        kolejka.Enqueue("c");
        kolejka.Enqueue("d");


        // 4. Wypisz na konsoli zawartość stosu i zawartość kolejki.
        Console.WriteLine("\n" + "4. Wypisz na konsoli zawartość stosu i zawartość kolejki.");
        Console.WriteLine("Stos: " + string.Join(", ",stos));
        Console.WriteLine("Kolejka: " + string.Join(", ",kolejka));


        // 5. Zdejmij ze stosu dwa elementy i wstaw je do kolejki.
        Console.WriteLine("\n" + "5. Zdejmij ze stosu dwa elementy i wstaw je do kolejki.");
        kolejka.Enqueue(stos.Pop());
        kolejka.Enqueue(stos.Pop());


        // 6. Wypisz na konsoli zawartość stosu i zawartość kolejki po zmianach.
        Console.WriteLine("\n" + "6. Wypisz na konsoli zawartość stosu i zawartość kolejki po zmianach.");
        Console.WriteLine("Stos: " + string.Join(", ",stos));
        Console.WriteLine("Kolejka: " + string.Join(", ",kolejka));


        // 7. Wypisz na konsoli (nie usuwając) element szczytowy stosu i element czołowy z kolejki.
        Console.WriteLine("\n" + " 7. Wypisz na konsoli (nie usuwając) element szczytowy stosu i element czołowy z kolejki.");
        Console.WriteLine("Stos: " + stos.Peek());
        Console.WriteLine("Kolejka: " + kolejka.Peek());


        // 8. Usuń ze stosu dwa elementy i wstaw do kolejki element e.
        Console.WriteLine("\n" + "8. Usuń ze stosu dwa elementy i wstaw do kolejki element e.");
        stos.Pop();
        stos.Pop();
        kolejka.Enqueue("e");


        // 9. Wypisz na konsoli zawartość stosu i zawartość kolejki po zmianach.
        Console.WriteLine("\n" + "9. Wypisz na konsoli zawartość stosu i zawartość kolejki po zmianach.");
        Console.WriteLine("Stos: " + string.Join(", ",stos));
        Console.WriteLine("Kolejka: " + string.Join(", ",kolejka));


        // 10. Spróbuj przesunąć ze stosu element szczytowy i wstawić go do kolejki.
        Console.WriteLine("\n" + "10. Spróbuj przesunąć ze stosu element szczytowy i wstawić go do kolejki.");
        // kolejka.Enqueue(stos.Pop());
        try
        {
            kolejka.Enqueue(stos.Pop());
        }
        catch (System.Exception )
        {
            
            Console.WriteLine("Error" );
        }



        //  --------------------------------------------------------------------------------------------------------------------------\\
        //  -------------------------------------------           Zadanie 3. Zbiór          ------------------------------------------ \\
        Console.WriteLine("\n//  --------------------------------------           Zadanie 3. Zbiór          -------------------------------------- \\");

        // Dokumentacja klasy HashSet<T>
        // Zbiór @dotnetperls


        // 1. Utwórz dwa zbiory liczb całkowitych: A = {1, 3, 5, 2, 7, 8} oraz B = {2, 1, 5, 3, 9, 6}.
        Console.WriteLine("\n" + "1. Utwórz dwa zbiory liczb całkowitych: A = {1, 3, 5, 2, 7, 8} oraz B = {2, 1, 5, 3, 9, 6}.");
        var A =  new HashSet<int> {1, 3, 5, 2, 7, 8};
        var B = new HashSet<int> {2, 1, 5, 3, 9, 6};

        // 2. Wypisz zawartość tych zbiorów na konsoli.
        Console.WriteLine("\n" + "2. Wypisz zawartość tych zbiorów na konsoli.");
        Console.WriteLine("set A: " + string.Join(", ",A));
        Console.WriteLine("set B: " + string.Join(", ",B));


        // 3. Napisz metodę void DisplaySet<T>(ISet<T> set) wypisującą na konsolę elementy zbioru podanego jako argument.
        Console.WriteLine("\n" + "3. Napisz metodę void DisplaySet<T>(ISet<T> set) wypisującą na konsolę elementy zbioru podanego jako argument.");
        DisplaySet(A);
        DisplaySet(B);


        // 4. Utwórz zbiór C będący sumą zbiorów A oraz B. Posortuj go malejąco. Wypisz na konsolę jego elementy.
        Console.WriteLine("\n" + "4. Utwórz zbiór C będący sumą zbiorów A oraz B. Posortuj go malejąco. Wypisz na konsolę jego elementy.");
        var C =new HashSet<int>(A);
        C.UnionWith(B);
        var listC = new List<int>(C);
        listC.Sort((x,y) => y.CompareTo(x));
        Console.WriteLine("listC: " + string.Join(", ", listC));


        // 5. Oblicz średnią arytmetyczną zbioru C i wypisz ją na konsolę.
        Console.WriteLine("\n" + "5. Oblicz średnią arytmetyczną zbioru C i wypisz ją na konsolę.");
        var mean = listC.Average();
        Console.WriteLine("Średnia: " + mean);


        // 6. Wypisz na konsolę część wspólną zbiorów A oraz B.
        Console.WriteLine("\n" + "6. Wypisz na konsolę część wspólną zbiorów A oraz B.");
        var intersec = new HashSet<int>(A);
        intersec.IntersectWith(B);
        // DisplaySet(intersec);
        Console.WriteLine("część wspólną zbiorów A oraz B: " + string.Join(", ", intersec));

        // 7. Sprawdź, czy zbiór {6, 9} jest podzbiorem różnicy symetrycznej zbiorów B oraz A.
        Console.WriteLine("\n" + "7. Sprawdź, czy zbiór {6, 9} jest podzbiorem różnicy symetrycznej zbiorów B oraz A.");
        var subSet = new HashSet<int> {6,9};
        // var subSet = new HashSet<int> {6, 7, 8, 9};
        var symDiff =  new HashSet<int>(A);
        symDiff.SymmetricExceptWith(B);
        bool isSubset = subSet.IsSubsetOf(symDiff);
        Console.WriteLine("Czy zbiór {6, 9} jest podzbiorem różnicy symetrycznej zbiorów B oraz A? " + isSubset);




        //  --------------------------------------------------------------------------------------------------------------------------\\
        //  -------------------------------------------           Zadanie 4. Słownik         ------------------------------------------ \\
        Console.WriteLine("\n//  -----------------------------------         Zadanie 4. Słownik         --------------------------------- \\");

        // Dokumentacja klasy Dictionary<TKey, TValue>
        // Słownik @dotnetperls

        // 1. Za pomocą klasy Dictionary, stwórz co najmniej 5-elementowy słownik zawierający listę zwierząt ("kot", "pies", "krowa”, "wąż", ...) 
        // i odpowiadającą im liczbę nóg.
        Console.WriteLine("\n" + "1. Za pomocą klasy Dictionary, stwórz co najmniej 5-elementowy słownik zawierający listę zwierząt ('kot', pies, krowa, wąż, ...) \ni odpowiadającą im liczbę nóg.");
        var animals = new Dictionary<string, int>
        {
            {"kot", 4},
            {"pies", 4},
            {"krowa", 4},
            {"wąż", 0},
            {"pająk", 8},
        };

        // 2. Wydrukuj zawartość słownika na konsolę.
        Console.WriteLine("\n" + "2. Wydrukuj zawartość słownika na konsolę.");

        foreach (var a in animals)
        {
            Console.WriteLine($"{a.Key} {a.Value}");
        }
        Console.WriteLine(string.Join(", ", animals));

        // 3. Przetestuj, czy zawiera on wybrany element za pomocą metod ContainsKey i TryGetValue.
        Console.WriteLine("\n" + "3. Przetestuj, czy zawiera on wybrany element za pomocą metod ContainsKey i TryGetValue.");
        Console.WriteLine("animals.ContainsKey(''): "  + animals.ContainsKey("pająk"));

        if (animals.TryGetValue("pająk", out int value))
        {
            Console.WriteLine($"TryGetValue: {value}");
        }

        // 4. Sprawdź, czy w słowniku są zwierzęta z 6 nogami.
        Console.WriteLine("\n" + "4. Sprawdź, czy w słowniku są zwierzęta z 6 nogami.");
        foreach (var animal in animals)
        {
            if (animal.Value == 6)
            {
                Console.WriteLine(animal.Key);
            }
        }


        // 5. Dodaj do słownika zwierzę "pająk" z liczbą nóg 6.
        Console.WriteLine("\n" + "5. Dodaj do słownika zwierzę 'pająk' z liczbą nóg 6.");
        animals["pająk"] = 6;

        // 6. Wypisz na konsoli zawartość słownika.
        Console.WriteLine("\n" + "6. Wypisz na konsoli zawartość słownika.");

        foreach (var a in animals)
        {
            Console.WriteLine($"{a.Key} {a.Value}");
        }
        Console.WriteLine(string.Join(", ", animals));

        // 7. Zmień pająkowi liczbę nóg na 8.
        Console.WriteLine("\n" + "7. Zmień pająkowi liczbę nóg na 8.");
        animals["pająk"] = 8;
        animals["baran"] = 4;

        // 8. Wypisz na konsoli zwierzęta zapamiętane w słowniku, w kolejności rosnącej (Keys).
        Console.WriteLine("\n" + "8. Wypisz na konsoli zwierzęta zapamiętane w słowniku, w kolejności rosnącej (Keys).");
        var sortedDict = animals.OrderBy(animal => animal.Key);
        // foreach (var animal in sortedDict)
        foreach (var animal in animals.OrderBy(animal => animal.Key))
        {
            Console.WriteLine($"{animal.Key} {animal.Value}");
        }

        Console.WriteLine(string.Join(", ", sortedDict));

        // 9. Wypisz na konsoli zbiór nóg zapamiętanych w słowniku (Values).
        Console.WriteLine("\n" + "9. Wypisz na konsoli zbiór nóg zapamiętanych w słowniku (Values).");
        foreach (var animal in animals.Values)
        {
            Console.WriteLine(animal);
        }


        // 10. Wypisz na konsoli te zapamiętane zwierzęta, które maja 4 nogi.
        Console.WriteLine("\n" + "10. Wypisz na konsoli te zapamiętane zwierzęta, które maja 4 nogi.");
        foreach (var animal in animals)
        {
            if (animal.Value == 4)
            {
                Console.WriteLine(animal.Key);
            }
        }

        // 11. Wypisz na konsoli sumę nóg zapisanych w słowniku zwierząt.
        Console.WriteLine("\n" + "11. Wypisz na konsoli sumę nóg zapisanych w słowniku zwierząt.");
        Console.WriteLine(animals.Values.Sum());


        // 12. Spróbuj ponownie dodać do słownika pająka z liczbą nóg 8.
        Console.WriteLine("\n" + "12. Spróbuj ponownie dodać do słownika pająka z liczbą nóg 8.");
        bool addedAnimal = animals.TryAdd("pająk", 6);
        Console.WriteLine("Czy dodany?: " + addedAnimal);

        // 13. Usuń wpis dotyczący pająka ze słownika.
        Console.WriteLine("\n" + "13. Usuń wpis dotyczący pająka ze słownika.");
        animals.Remove("pająk");
        Console.WriteLine(string.Join(", ", animals));

        // 14. Wypisz na konsoli zwierzęta oraz liczbę nóg, w kolejności od najmniejszej liczby nóg do największej. 
        // W przypadku tej samej liczby nóg wypisz zwierzęta w kolejności rosnącej (porządek leksykograficzny).
        Console.WriteLine("\n" + "14. Wypisz na konsoli zwierzęta oraz liczbę nóg, w kolejności od najmniejszej liczby nóg do największej. \nW przypadku tej samej liczby nóg wypisz zwierzęta w kolejności rosnącej (porządek leksykograficzny).");
        var sortedAnimals = animals
            .OrderBy(v => v.Value)
            .ThenBy(k => k.Key);
        
        foreach (var animal in sortedAnimals)
        {
            Console.WriteLine($"{animal.Value} {animal.Key}");
        }

    }   
}

  
  



  


  

  

  

//var aa = new HashSet<int>(a); 

//var bb = new HashSet<int>(b); 

//aa.Except(bb); 

  

//if(aa.Count == 0) 

//    Console.WriteLine("empty"); 

//else 

//    Console.WriteLine(Console.WriteLine(string.join(" ", aa)); 

  



  


  

 