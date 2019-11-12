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

    // Complete the dayOfProgrammer function below.
    static string dayOfProgrammer(int year)
    {
        int leapFeb = 29;
        int feb = 28;
        int jan, mar, may, jul, aug;
        jan= mar= may= jul= aug = 31;
        int apr, jun;
        apr = jun = 30;
        bool isLeapYear = false;
        int daysUntilSeptInLeap = jan + leapFeb + mar + apr + may + jun + jul + aug;
        int daysUntilSeptInNonLeap = jan + feb + mar + apr + may + jun + jul + aug;
        
        //bool isLeapYear(int year)
        //{
            if (year < 1918 && year % 4 == 0)
            {
                isLeapYear =  true;
            }
            else if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
            {

                isLeapYear = true;
            }
            else
            {
                isLeapYear = false;
            }
        //}

        string answer= "something is wrong";
        if (year == 1918)
        {
            answer = "26.09.1918";
        }
        else if (year > 1918 && isLeapYear)
        {
            int dayInSept = 256 - daysUntilSeptInLeap;
            answer = $"{dayInSept}.09.{year}"; 
        }
        else if (year > 1918)
        {
            int dayInSept = 256 - daysUntilSeptInNonLeap;
            answer = $"{dayInSept}.09.{year}";
        }
        else if(year < 1918 && isLeapYear)
        {
            int dayInSept = 256 - daysUntilSeptInLeap;
            answer = $"{dayInSept}.09.{year}";
        }
        else if (year < 1918)
        {
            int dayInSept = 256 - daysUntilSeptInNonLeap;
            answer = $"{dayInSept}.09.{year}";
        }
        else
        {
            answer = "mess up in the day calculator";
        }

        //string test = $"Leap year is {isLeapYear(year)}";
        //return test;
        return answer;
        
    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int year = 1801; //Convert.ToInt32(Console.ReadLine().Trim());

        string result = dayOfProgrammer(year);

        Console.WriteLine(result);

        //textWriter.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
