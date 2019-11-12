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

    // Complete the miniMaxSum function below.
    static void miniMaxSum(int[] arr)
    {
        long[] arrr = Array.ConvertAll(arr, item => (long)item);
        Array.Sort(arrr);
        long minSum = arrr[0] + arrr[1] + arrr[2] + arrr[3];
        long maxSum = arrr[1] + arrr[2] + arrr[3] + arrr[4];
        Console.WriteLine($"{minSum} {maxSum}");
    }

    static void Main(string[] args)
    {
        //int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        int[] arr = new int[5] { 256741038, 623958417, 467905213, 714532089, 938071625 };
        miniMaxSum(arr);
    }
}
