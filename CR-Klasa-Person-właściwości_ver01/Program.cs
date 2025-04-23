// CR: Klasa Person (właściwości)

// Zaprojektuj klasę Person spełniającą następujące założenia:

// Dane:

// FamilyName : string, nazwisko, tylko litery (co najmniej dwie), pierwsza litera duża, pozostałe małe; 
// możliwość nazwiska dwuczłonowego - wtedy człony połączone łącznikiem (znak -), każdy człon z dużej litery, 
// pozostałe z małych (człon nazwiska składa się z co najmniej 2. liter). Próba zapamiętania wartości 
// niezgodnej z wytycznymi skutkuje zgłoszeniem wyjątku ArgumentException z komunikatem Incorrect data for FamilyName. 
// Spacje na początku i końcu należy usunąć.

// FirstName : string, imię, tylko litery (co najmniej dwie), pierwsza litera duża, pozostałe małe. 
// Próba zapamiętania wartości niezgodnej z wytycznymi skutkuje zgłoszeniem wyjątku 
// ArgumentException z komunikatem Incorrect data for FirstName. Spacje na początku i końcu należy usunąć.

// Birthday : DateTime, data urodzenia, nie później niż dzisiaj. Próba zapamiętania wartości niezgodnej z wytycznymi 
// skutkuje zgłoszeniem wyjątku ArgumentException z komunikatem Incorrect data for Birthday.

// Dane obiektu są read/write oraz obligatoryjne, zrealizuj je jako właściwości (properties).

// Zachowanie:

// metoda ToString() wypisująca dane o osobie w formacie {FirstName} {FamilyName} ({Birthday}), data urodzenia w formacie yyyy-MM-dd.
// Uwagi

// Postaraj się zapisać kod klasy używając jak najmniejszej liczby linii kodu - np. wykorzystuj metody klasy string, jeśli 
// kod miałby się powtarzać - zdefiniuj metodę prywatną, którą wykorzystasz wielokrotnie.

// Do oceny przesyłasz kod klasy Person, ewentualnie poprzedzony dyrektywami using. Nie umieszczasz go w żadnej przestrzeni nazw. 
// Twój kod (STUDENT_ANSWER) zostanie osadzony w podanym szkielecie, następnie całość zostanie skompilowana 
// i uruchomiona - dla każdego przypadku testowego oddzielnie:



using System;
using System.Globalization;

namespace MyProg
{
    public class Person
    {
        private string familyName;
        private string firstName;
        private DateTime birthday;

        public string FamilyName
        {
            get => familyName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Incorrect data for FamilyName");

                value = value.Trim();
                if (!IsValidFamilyName(value))
                    throw new ArgumentException("Incorrect data for FamilyName");

                familyName = value;
            }
        }

        public string FirstName
        {
            get => firstName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Incorrect data for FirstName");

                value = value.Trim();
                if (!IsValidFirstName(value))
                    throw new ArgumentException("Incorrect data for FirstName");

                firstName = value;
            }
        }

        public DateTime Birthday
        {
            get => birthday;
            set
            {
                if (value > DateTime.Today)
                    throw new ArgumentException("Incorrect data for Birthday");

                birthday = value;
            }
        }

        public Person(string familyName, string firstName, DateTime birthday)
        {
            FamilyName = familyName;
            FirstName = firstName;
            Birthday = birthday;
        }

        private bool IsValidFamilyName(string value)
        {
            var parts = value.Split('-');
            if (parts.Length > 2)
                return false;

            foreach (var part in parts)
            {
                if (!IsValidNamePart(part))
                    return false;
            }
            return true;
        }

        private bool IsValidFirstName(string value)
        {
            return IsValidNamePart(value);
        }

        private bool IsValidNamePart(string value)
        {
            return value.Length >= 2 && char.IsUpper(value[0]) && IsAllLetters(value.Substring(1));
        }

        private bool IsAllLetters(string value)
        {
            foreach (char c in value)
            {
                if (!char.IsLetter(c))
                    return false;
            }
            return true;
        }

        public override string ToString()
        {
            return $"{FirstName} {FamilyName} ({Birthday:yyyy-MM-dd})";
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // TEST.testcode - tutaj wstawiamy kod testowy
            var p1 = new Person(familyName: "Abacki",
                                firstName: "John",
                                birthday: new DateTime(year: 2000, month: 1, day: 1));
            Console.WriteLine(p1.FamilyName);
            Console.WriteLine(p1.FirstName);
            Console.WriteLine($"{p1.Birthday:yyyy-MM-dd}");
        }
    }
}
