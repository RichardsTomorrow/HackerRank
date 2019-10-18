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

    // Complete the plusMinus function below.
    static void plusMinus(int[] arr)
    {
        int pos = 0;
        int neg = 0;
        int zer = 0;

        foreach(int number in arr)
        {
            if(number > 0)
            {
                pos++;
            }
            else if (number < 0)
            {
                neg++;
            }
            else if (number == 0)
            {
                zer++;
            }
        }
        
        double posRat = (double)pos / arr.Length;
        double negRat = (double)neg / arr.Length;
        double zerRat = (double)zer / arr.Length;

        Console.WriteLine(posRat);
        Console.WriteLine(negRat);
        Console.WriteLine(zerRat);

    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        plusMinus(arr);
    }
}
