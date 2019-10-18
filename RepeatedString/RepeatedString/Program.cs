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

    // Complete the repeatedString function below.
    static long repeatedString(string s, long n)
    {
        long amount = 0;
        long modulus = n % s.Length;
        long multi = n / s.Length;

        foreach (char a in s)
        {
            if (a == 'a')
            {
                amount++;
            }
        }
        amount *= multi;

        for (int i = 0; i < modulus; i++)
        {
            if (s[i] == 'a')
                amount++;
        }

        return amount;
    }

    static void Main(string[] args)
    {
        // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = "a";//Console.ReadLine();

        long n = 1000000000000;  //Convert.ToInt64(Console.ReadLine());

        long result = repeatedString(s, n);
        Console.WriteLine(result);

        //textWriter.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
