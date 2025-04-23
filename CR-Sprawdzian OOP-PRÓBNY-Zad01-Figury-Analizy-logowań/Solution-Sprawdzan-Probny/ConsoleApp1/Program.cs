
// Sprawdzian OOP - PRÓBNY (z r.a. 2020/21)

// Zadanie 01

//Twoim zadaniem jest wykonanie analizy logowań do pewnego systemu webowego.
//Otrzymujesz wielowierszowy napis (typu string) zawierający, w kolejnych liniach: datę i czas logowania, login użytkownika
//oraz numer IP, np.:

//2021 - 06 - 10 5:20 mirek 180.40.41.120
//2021-06-10 10:20 adam 80.40.41.120
//2021-06-10 10:21 admin 192.168.4.10
//2021-06-11 8:09 maciek 149.40.53.12
//2021-06-11 8:10 adam 80.40.41.120
//2021-06-11 18:10 mirek 180.40.41.120
//Napisz procedurę o sygnaturze

//public static void Analyze(string logs)
//wypisującą na standardowe wyjście, w porządku rosnącym, loginy użytkowników, którzy w badanym okresie
//zalogowali się do serwisu przynajmniej jeden raz każdego dnia.

//Nie wypisuj duplikatów.
//Loginy użytkowników wypisz w jednej linii, oddzielając je przecinkiem i pojedynczą spacją.
//W przypadku braku użytkowników spełniających warunki zadania wypisz słowo empty.
//⚠️ Rozwiąż zadanie wykorzystując właściwie dobrane do problemu standardowe kolekcje C#. Zabronione jest używanie operatorów LINQ.

//For example:

//Input                                         Result
//------------------------------------------------------------------
//2021-06-10 5:20 mirek 180.40.41.120           adam, mirek
//2021-06-10 10:20 adam 80.40.41.120
//2021-06-10 10:21 admin 192.168.4.10
//2021-06-11 8:09 maciek 149.40.53.12
//2021-06-11 8:10 adam 80.40.41.120
//2021-06-11 18:10 mirek 180.40.41.120
//------------------------------------------------------------------
//2021-06-10 5:20 mirek 180.40.41.120           empty
//2021-06-10 10:20 adam 80.40.41.120
//2021-06-10 10:21 admin 192.168.4.10
//2021-06-11 8:09 maciek 149.40.53.12
//2021-06-11 8:10 kazik 80.40.41.120
//------------------------------------------------------------------



using System;
using System.Collections.Generic;

class Program
{

    static void Test01()
    {
        Console.WriteLine("Test01");
    }

    public static void Analyze(string logs)
    {
        // Variables
        var userLogs = logs.Split('\n', StringSplitOptions.RemoveEmptyEntries);
        var dictUsers = new SortedDictionary<string, SortedSet<string>>();
        var uniqueDates = new SortedSet<string>();
        

        foreach (var row in userLogs)
        {
            var tab = row.Split(" ");
            var date = tab[0];
            var user = tab[2];

            if (!dictUsers.ContainsKey(user))
                dictUsers[user] = new SortedSet<string>();

            dictUsers[user].Add(date);
            uniqueDates.Add(date);


        }

        //foreach (var user in dictUsers)
        //{
        //    Console.WriteLine($"Users: {user.Key}, Dates: {string.Join(", ", user.Value)}");
        //}

        var userInEveryDay = new SortedSet<string>();
        foreach (var user in dictUsers)
        {
            if (user.Value.SetEquals(uniqueDates))
            {
                userInEveryDay.Add(user.Key);
            }
        }

        Console.WriteLine(userInEveryDay.Count != 0 ? $"{string.Join(", ", userInEveryDay)}" : "empty");



    }


    public static void Main()
    {

        // data
        int n = int.Parse(Console.ReadLine());
        string inputLogs = "";


        for (int i = 0; i < n; i++)
        {
            inputLogs += Console.ReadLine() + "\n";
        }

        Analyze(inputLogs);

    }
}
