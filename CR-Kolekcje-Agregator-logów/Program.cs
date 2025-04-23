// CR: Kolekcje. Agregator logów

// You are given a sequence of access logs in format <IP> <user> <duration>. For example:

// 192.168.0.11 peter 33
// 10.10.17.33 alex 12
// 10.10.17.35 peter 30
// 10.10.17.34 peter 120
// 10.10.17.34 peter 120
// 212.50.118.81 alex 46
// 212.50.118.81 alex 4
// Write a program to aggregate the logs data and print for each user the total duration of his sessions and a list of unique IP addresses in format <user>: <duration> [<IP1>, <IP2>, …]. Order the users alphabetically. Order the IPs alphabetically. In our example, the output should be the following:

// alex: 62 [10.10.17.33, 212.50.118.81]
// peter: 303 [10.10.17.34, 10.10.17.35, 192.168.0.11]
// Input
// The input comes from the console. At the first line a number n stays which says how many log lines will follow. Each of the next n lines holds a log information in format <IP> <user> <duration>. The input data will always be valid and in the format described. There is no need to check it explicitly.

// Output
// Print one line for each user (order users alphabetically). For each user print its sum of durations and all of his sessions' IPs, ordered alphabetically in format <user>: <duration> [<IP1>, <IP2>, …]. Remove any duplicated values in the IP addresses and order them alphabetically (like we order strings).

// Constraints
// The count of the order lines n is in the range [1…1000].
// The <IP> is a standard IP address in format a.b.c.d where a, b, c and d are integers in the range [0…255].
// The <user> consists of only of Latin characters, with length of [1…20].
// The <duration> is an integer number in the range [1…1000].
// For example:

// Input	               | Result
// -------------------------------------------------------
// 7                         alex: 62 [10.10.17.33, 212.50.118.81]
// 192.168.0.11 peter 33     peter: 303 [10.10.17.34, 10.10.17.35, 192.168.0.11]
// 10.10.17.33 alex 12
// 10.10.17.35 peter 30
// 10.10.17.34 peter 120
// 10.10.17.34 peter 120
// 212.50.118.81 alex 46
// 212.50.118.81 alex 4
// -------------------------------------------------------
// 2                         mol: 60 [84.238.140.178]
// 84.238.140.178 mol 25
// 84.238.140.178 mol 35
// -------------------------------------------------------



// Napisz cały program (z funkcją Main()), wczytujący ze standardowego wejścia i wypisujący na standardowe wyjście

using System;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        // wczytaj
        int n = int.Parse(Console.ReadLine());
        var input = new string[n];

        for (int i = 0; i < n; i++)

        {
            input[i] = Console.ReadLine();
        }


        // przetwórz

        // słownik: user: sumaryczny czas
        var dict_time = new SortedDictionary<string, int>();


        // słownik: user: zbiór numerów IP
        var dict_ips = new Dictionary<string, SortedSet<string>>();


        // wpisz wynik

        foreach (var row in input)
        {
            var tab = row.Split(" ");
            var ip = tab[0];
            var user = tab[1];
            var time = int.Parse(tab[2]);

            if (dict_time.ContainsKey(user))
                dict_time[user] += time;
            else
                dict_time.Add(user, time);
            

            if (dict_ips.ContainsKey(user))
                dict_ips[user].Add(ip);    
            else
                dict_ips.Add(user, new SortedSet<string>());
                dict_ips[user].Add(ip);

        }

        // wypisz wynik

        foreach (var item in dict_time)
        {
            var user = item.Key;
            Console.WriteLine($"{user}: {item.Value} [{string.Join(", ", dict_ips[user])}]");
        }


    }
}
