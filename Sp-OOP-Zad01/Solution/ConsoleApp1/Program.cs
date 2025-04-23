


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
        var userWIthUniqueIP = new SortedSet<string>();


        foreach (var row in userLogs)
        {
            var tab = row.Split(" ");
            var ipNumber = tab[3];
            var user = tab[2];

            if (!dictUsers.ContainsKey(user))
                dictUsers[user] = new SortedSet<string>();

            dictUsers[user].Add(ipNumber);
            //uniqueDates.Add(ipNumber);


        }

        //foreach (var user in dictUsers)
        //{
        //    Console.WriteLine($"Users: {user.Key}, Dates: {string.Join(", ", user.Value)}");
        //}


        foreach (var user in dictUsers)
        {
            if (user.Value.Count == 1)
            {
                userWIthUniqueIP.Add(user.Key);
            }
            //else
            //{
            //    Console.WriteLine($"Użytkownik {user.Key} ma tylko jeden adres IP: {string.Join(", ", user.Value)}");
            //}
        }

        //var userInEveryDay = new SortedSet<string>();
        //foreach (var user in dictUsers)
        //{
        //    if (user.Value.SetEquals(uniqueDates))
        //    {
        //        userInEveryDay.Add(user.Key);
        //    }
        //}

        Console.WriteLine(userWIthUniqueIP.Count != 0 ? $"{string.Join(", ", userWIthUniqueIP)}" : "empty");



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

