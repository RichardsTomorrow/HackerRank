using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
class Solution
{
    static void Main(String[] args)
    {

        var N = int.Parse(Console.ReadLine());
        for (int j = 0; j < N; j++)
        {
            StringBuilder even = new StringBuilder();
            StringBuilder odd = new StringBuilder();
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {

                if (i % 2 == 0)
                {
                    even.Append(input[i]);
                }
                else
                {
                    odd.Append(input[i]);
                }
            }
            Console.Write($"{even} {odd}\n");

        }

    }

}
