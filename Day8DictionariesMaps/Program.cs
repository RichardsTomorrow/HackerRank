using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */

        Dictionary<string, int> phonebook = new Dictionary<string, int>();
        //int n = int.Parse(Console.ReadLine());
        Int32.TryParse(Console.ReadLine(), out int n);


        for (int i = 0; i < n; i++)
        {
            string[] values = Console.ReadLine().Split(' ');
            string name = values[0];
            int phoneNumber = Convert.ToInt32(values[1]);

            phonebook.Add(name, phoneNumber);
        }
        for (int i =0; i < n; i++)
        {
            string check = Console.ReadLine();

            if (phonebook.ContainsKey(check))
            {
                int number = phonebook[check];
                Console.WriteLine($"{check}={number}");
            }
            else
            {
                Console.WriteLine($"Not found");
            }
        }

    }
}
