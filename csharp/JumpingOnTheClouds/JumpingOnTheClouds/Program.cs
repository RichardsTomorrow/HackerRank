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

    // Complete the jumpingOnClouds function below.
    static int jumpingOnClouds(int[] c)
    {
        int jumps = 0;
        int i = 0;

        while (i < c.Length-1)
        {
            if (i+2 < c.Length && c[i+2] == 0)// I only need to check and see if I can jump 2 otherwise I will always jump 1 and check for the opportuity to jump 2
            {
                i += 2;
                jumps++;
            }
            else
            {
                i++;
                jumps++;
            }
            
        }

        return jumps;
    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = 50;// Convert.ToInt32(Console.ReadLine());

        int[] c = new int[] { 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 1, 0, 0 };// Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
        //;
        int result = jumpingOnClouds(c);
        Console.WriteLine(result);
    //    textWriter.WriteLine(result);

    //    textWriter.Flush();
    //    textWriter.Close();
    }
}
