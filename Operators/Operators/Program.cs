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

    // Complete the solve function below.
    static void solve(double meal_cost, int tip_percent, int tax_percent)
    {
        double tip = meal_cost * ((double)tip_percent / 100);
        double tax = meal_cost * ((double)tax_percent / 100);
        double total = meal_cost + tip + tax;
        int answer = (int)Math.Round(total);
        Console.WriteLine(answer);
        //Console.WriteLine(total);
        //Console.WriteLine(tip);
        //Console.WriteLine(tax);

    }

    static void Main(string[] args)
    {
        double meal_cost = 12.00; //Convert.ToDouble(Console.ReadLine());

        int tip_percent = 20; //Convert.ToInt32(Console.ReadLine());

        int tax_percent = 8; //Convert.ToInt32(Console.ReadLine());

        solve(meal_cost, tip_percent, tax_percent);
    }
}

