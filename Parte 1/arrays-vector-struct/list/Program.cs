using System;
using System.Collections.Generic;

namespace list;

class Program
{
    static void Main()
    {
        List<string> list = new List<string>();
        
        list.Add("Ana");
        list.Add("Maria");
        list.Add("Eric");
        list.Insert(2, "Matheus");
        list.Add("Arara");
        
        foreach (var people in list)
        {
            Console.WriteLine(people);
        }
        Console.WriteLine($"List count: {list.Count}");

        string s1 = list.Find(x => x[0] == 'A');
        Console.WriteLine($"First 'A' person: {s1}");

        string s2 = list.FindLast(x => x[0] == 'A');
        Console.WriteLine($"Last person with 'A': {s2}");

        int pos1 = list.FindIndex(x => x[0] == 'A');
        Console.WriteLine($"First person 'A' index: {pos1}");

        int pos2 = list.FindLastIndex(x => x[0] == 'A');
        Console.WriteLine($"Last person with 'A': {pos2}");

        List<string> list2 = list.FindAll(x => x.Length == 5);
        Console.WriteLine("--------------");
        foreach (var people in list2)
        {
            Console.WriteLine(people);
        }
    }
}

