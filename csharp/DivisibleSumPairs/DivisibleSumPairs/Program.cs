using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    // Complete the divisibleSumPairs function below.
    static int divisibleSumPairs(int n, int k, int[] ar)
    {
        int counter = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                int sum = ar[i] + ar[j];

                if ((sum % k) == 0)
                {
                    counter++;
                }
            }
        }

        return counter;
    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //string[] nk = Console.ReadLine().Split(' ');

        int n = 6; // Convert.ToInt32(nk[0]);

        int k = 3; // Convert.ToInt32(nk[1]);

        int[] ar = new int[] { 1, 3, 2, 6, 1, 2};//Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
        //;
        int result = divisibleSumPairs(n, k, ar);

        Console.WriteLine(result);
        //textWriter.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
