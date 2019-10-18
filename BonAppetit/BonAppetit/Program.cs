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

    // Complete the bonAppetit function below.
    static void bonAppetit(List<int> bill, int k, int b)
    {
        int billSum = 0;

        foreach(int charge in bill)
        {
            billSum += charge;
        }
        int billDiv = billSum / 2;

        //Console.WriteLine(billSum); //troubleshooting
        if (billDiv == b)
        {
            int refund = bill[k] / 2;
            Console.WriteLine(refund);
        }
        else
            Console.WriteLine("Bon Appetit");

    }

    static void Main(string[] args)
    {
        //string[] nk = Console.ReadLine().TrimEnd().Split(' ');

        //int n = Convert.ToInt32(nk[0]);

        int k = 1;//Convert.ToInt32(nk[1]);

        List<int> bill = new List<int> { 3, 10, 2, 9 }; //Console.ReadLine().TrimEnd().Split(' ').ToList().Select(billTemp => Convert.ToInt32(billTemp)).ToList();

        int b = 7;//Convert.ToInt32(Console.ReadLine().Trim());

        bonAppetit(bill, k, b);
    }
}
