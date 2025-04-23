// CR: Klasa Person, klasa Child - dziedziczenie


// Jesteś poproszony o zamodelowanie klas dla aplikacji przechowującej dane osób. Musisz przewidzieć, że będziesz przechowywał 
// informacje na temat osób dorosłych i dzieci. Dzieci dziedziczą pewne cechy od swoich rodziców.

// Tworzysz:

// klasę Person – będąca klasą bazową z której pozostałe klasy dziedziczą.

// Osoba ma imię (FirstName) i nazwisko (FamilyName).
// Imię i nazwisko są pojedynczymi wyrazami (nie zawierają spacji), składają się wyłącznie z liter, zaczynają się od 
// dużej litery, zaś pozostałe są literami małymi. Stosowne korekty wprowadź w chwili 
// przypisywania wartości (usuń spacje, skoryguj format "duża litera-małe litery"). Jeśli napis miałby zawierać znaki, które nie są 
// literami, lub byłby pusty zgłoś wyjątek typu ArgumentException z komunikatem "Wrong name!".
// Wiek osoby nie może być ujemny (zgłoś wyjątek ArgumentException z komunikatem "Age must be positive!").
// Zdefiniuj właściwości FirstName, FamilyName oraz Age w klasie Person, publiczne do 
// odczytu i chronione do zapisu (dostępne tylko z poziomu klasy i klas dziedziczących).
// Zdefiniuj konstruktor, akceptujący parametry firstName, familyName oraz age.
// Zdefiniuj tekstową reprezentację obiektu, zwracającą napis w formacie {firstName} {familyName} ({age})
// Zdefiniuj metody modyfikujące imię, nazwisko oraz wiek, o dostępie publicznym i o nazwach: modifyFirstName, modifyFamilyName, 
// modifyAge.
// klasę Child - będącą klasą dziedziczącą z klasy Person i dodatkowo spełniającą warunki:

// Zawiera referencje na rodziców: matkę (mother) oraz ojca (father). Referencje te ustawiane są w momencie konstrukcji obiektu 
// i nie mogą być już nigdy zmienione. Jeśli nie są znani rodzice dziecka, przypisz referencjom null.
// Dziecko nie może mieć wieku większego niż 15 lat (zgłoś wyjątek ArgumentException z 
// komunikatem "Child’s age must be less than 15!").
// Modyfikacja wieku dziecka możliwa jedynie w zakresie od 0 do 15 lat.
// Tekstowa reprezentacja obiektu:
// w pierwszej linii jak dla klasy Person
// w drugiej linii dane matki w formacie "mother: {firstName} {FamilyName} ({age})". Jeśli matka nie jest znana "mother: no data"
// w trzeciej linii dane ojca w formacie "father: {firstName} {FamilyName} ({age})". Jeśli ojciec nie jest znany "father: no data"
// Pozostałe wymagania odczytasz z przypadków testowych. Musisz zapisać kod tak, aby każdy z przypadków się kompilował 
// oraz produkował oczekiwane wyniki.

// UWAGA: Do oceny przesyłasz kod klas Person oraz Child, ewentualnie poprzedzony dyrektywami using. 
// Nie umieszczasz go w żadnej przestrzeni nazw. Twój kod (STUDENT_ANSWER) zostanie osadzony w podanym szkielecie, następnie 
// całość zostanie skompilowana i uruchomiona - dla każdego przypadku testowego oddzielnie:



using System;
namespace MyProg 
{
  public class Program
  {
  
  static void Test01()
  {
        /* Test: poprawne tworzenie obiektu Person, dane poprawne */
        try
        {
            Person p = new Person(familyName: "Molenda", firstName: "Krzysztof", age: 18);
            Console.WriteLine(p);
        }
        catch( Exception e)
        {
            Console.WriteLine(e.Message);
        }
  }


    static void Test02()
  {
        /* Test: poprawne tworzenie obiektu Person, 
        błędne imię lub nazwisko, pierwsza duża pozostałe małe */
        try
        {
            Person p = new Person(familyName: "MOlenda", firstName: "krzysztof", age: 18);
            Console.WriteLine(p);
        }
        catch( Exception e)
        {
            Console.WriteLine(e.Message);
        }
  }


    static void Test03()
  {
        /* Test: poprawne tworzenie obiektu Person, 
        błędne imię lub nazwisko, niewłaściwy wiek */
        try
        {
            Person p = new Person(familyName: "MOlenda", firstName: "krzysztof", age: -18);
            Console.WriteLine(p);
        }
        catch( Exception e)
        {
            Console.WriteLine(e.Message);
        }
  }

      static void Test04()
  {
        /* Test: modyfikacja obiektu */
        try
        {
            Person p = new Person(familyName: "Molenda", firstName: "Krzysztof", age: 18);
            p.modifyFirstName(" Ja n");
            p.modifyFamilyName("kolenda ");
            p.modifyAge(35);
            Console.WriteLine(p);
        }
        catch( Exception e)
        {
            Console.WriteLine(e.Message);
        }
  }

      static void Test05()
  {
        /* Test: tworzenie obiektu Child */
        try
        {
            Person o = new Person(familyName: "Molenda", firstName: "Krzysztof", age: 30);
            Person m = new Person(familyName: "Molenda", firstName: "Ewa", age: 29);
            Child d = new Child(familyName: "Molenda", firstName: "Anna", age: 10, 
                                mother: m, father: o);
            Console.WriteLine(d);
        }
        catch( Exception e)
        {
            Console.WriteLine(e.Message);
        }
  }

      static void Test06()
  {
        /* Test: tworzenie obiektu Child 
        brak rodziców */
        try
        {
            Child d = new Child(familyName: "Molenda", firstName: "Anna", age: 14);

            Console.WriteLine(d);
        }
        catch( Exception e)
        {
            Console.WriteLine(e.Message);
        }
  }

      static void Test07()
  {
        /* Test: tworzenie obiektu Child 
        brak jednego z rodziców */
        try
        {
            Person o = new Person(familyName: "Molenda", firstName: "Krzysztof", age: 30);
            Person m = new Person(familyName: "Molenda", firstName: "Ewa", age: 29);
            Child d = new Child(familyName: "Molenda", firstName: "Anna", age: 14, father: o);
            Console.WriteLine(d);
            d = new Child(familyName: "Molenda", firstName: "Anna", age: 14, mother: m);
            Console.WriteLine(d);
        }
        catch( Exception e)
        {
            Console.WriteLine(e.Message);
        }
  }

    static void Test08()
        {
            /* Test: poprawne tworzenie obiektu Person,
            błędne imię lub nazwisko, spacje przed i po */
            try
            {
                Person p = new Person(familyName: "  Molenda    ", firstName: " Krzysztof ", age: 18);
                Console.WriteLine(p);
            }
            catch( Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    static void Test09()
        {
            /* Test: poprawne tworzenie obiektu Person,
            błędne imię lub nazwisko, spacje w środku */
            try
            {
                Person p = new Person(familyName: "Molen  da", firstName: "Krzysztof.", age: 18);
                Console.WriteLine(p);
            }
            catch( Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    static void Test10()
        {
	
            /* Test: poprawne tworzenie obiektu Person,
            błędne imię lub nazwisko, nie tylko litery */
            try
            {
                Person p = new Person(familyName: "Mo1enda", firstName: "Krzysztof.", age: 18);
                Console.WriteLine(p);
            }
            catch( Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    static void Test11()
    {
    	
        /* Test: tworzenie obiektu Child
        modyfikacja danych */
        try
        {
            Person o = new Person(familyName: "Molenda", firstName: "Krzysztof", age: 30);
            Person m = new Person(familyName: "Molenda", firstName: "Ewa", age: 29);
            Child d = new Child(familyName: "Molenda", firstName: "Anna", age: 14,
                                mother: m, father: o);
            d.modifyFirstName("Aneta");
            Console.WriteLine(d);
            d.modifyFirstName("Kolenda");
            Console.WriteLine(d);
            d.modifyAge(18);
            Console.WriteLine(d);
        }
        catch( Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
    
    public static void Main(string[] args) 
    {
      // TEST.testcode
    //   Test01();
    //   Test02();
    //   Test03();
    //   Test04();
    //   Test05();
    //   Test06();
    //   Test07();
    //     Test08();
    //     Test09();
    //     Test10();
        Test11();
    }
  }
}