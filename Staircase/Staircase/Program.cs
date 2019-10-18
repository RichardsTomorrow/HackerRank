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

    // Complete the staircase function below.
    static void staircase(int n)
    {
        for (int i =0; i< n; i++)
        {
            int pounder = i + 1;
            int spacer = n - 1 - i;
            string space = " ";
            string pound = "#";
            string row = "";

            for (int s = 0; s < spacer; s++)
            {
                row = row + space;
            }
            for (int p = 0; p < pounder; p++)
            {
                row = row + pound;
            }
            Console.WriteLine(row);
        }
        
    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        staircase(n);
    }
}
