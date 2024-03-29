﻿using System.CodeDom.Compiler;
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



    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;

        int[] reverse = new int[arr.Length];

        for (int i = 0; i < arr.Length; i++)
        {
            int temp = arr[arr.Length - i - 1];
            reverse[i] = temp;
        }

        foreach ( int number in reverse)
        {
            Console.Write($"{number} ");
        }

    }
}
