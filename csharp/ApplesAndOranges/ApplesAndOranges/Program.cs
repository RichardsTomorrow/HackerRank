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

    // Complete the countApplesAndOranges function below.
    static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
    {
        int appleCounter = 0;
        int orangeCounter = 0;
        for (int i = 0; i < apples.Length; i++)
        {
            int appleTest = a + apples[i];
            if (appleTest >= s && appleTest <= t)
            {
                appleCounter++;
            }
        }
        for (int i = 0; i < oranges.Length; i++)
        {
            int orangeTest = b + oranges[i];
            if (orangeTest >= s && orangeTest <= t)
            {
                orangeCounter++;
            }
        }

        Console.WriteLine(appleCounter);
        Console.WriteLine(orangeCounter);
    }

    static void Main(string[] args)
    {
        //string[] st = Console.ReadLine().Split(' ');

        int s = 7;

        int t = 11;

        //string[] ab = Console.ReadLine().Split(' ');

        int a = 5;

        int b = 15;

        //string[] mn = Console.ReadLine().Split(' ');

        //int m = 3;

        //int n = 2;

        int[] apples = new int[3] { -2, 2, 1 };

        int[] oranges = { 5, -6 };
        countApplesAndOranges(s, t, a, b, apples, oranges);
    }
}

