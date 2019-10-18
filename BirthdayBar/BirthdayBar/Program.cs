using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    // Complete the birthday function below.
    static int birthday(List<int> s, int d, int m)
    {
        int counter = 0;
        for (int i = 0; i <= s.Count - m; i++)
        {
            int sum = s.GetRange(i, m).Aggregate((a, b) => a + b);
            if (sum == d)
            {
                counter++;
            }
        }
        

        //int counter = 0;

        //for(int i = 0; i < s.Count -m; i++)
        //{
        //    int temp = 0;
        //    for(int j = 0; j < m; j++)
        //    {
        //        temp += s[i + j];
        //    }
        //    if (temp == d)
        //    {
        //        counter++;
        //    }
        //}

        //for (int i = 0; i < s.Count - m; i++)
        //{
        //    int j, x, temp = 0;
        //    for (j = i, x = 1; x <= m; x++, j++)
        //    {
        //        temp += s[j];
        //    }

        //    //Console.WriteLine($" this is the {i} round temp:{temp}");
        //    if (temp == d)
        //    {
        //        counter += 1;
        //    }
        //}

        return counter;
    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> s = new List<int> { 2, 5, 1, 3, 4, 4, 3, 5, 1, 1, 2, 1, 4, 1, 3, 3, 4, 2, 1 }; //Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

        //string[] dm = Console.ReadLine().TrimEnd().Split(' ');

        int d = 18; //Convert.ToInt32(dm[0]);

        int m = 7; //Convert.ToInt32(dm[1]);

        int result = birthday(s, d, m);

        Console.WriteLine(result);

        Console.ReadLine();
        //textWriter.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
