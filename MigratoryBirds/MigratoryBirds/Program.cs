using System.CodeDom.Compiler;
using System.Collections.Generic;
//using System.Collections;
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

    // Complete the migratoryBirds function below.
    static int migratoryBirds(List<int> arr)
    {
        int one = 0;
        int two = 0;
        int three = 0;
        int four = 0;
        int five = 0;
        foreach ( int i in arr)
        {
            if (i == 1)
            {
                one++;
            }
            else if (i == 2)
            {
                two++;
            }
            else if (i == 3)
            {
                three++;
            }
            else if (i == 4)
            {
                four++;
            }
            else if (i == 5)
            {
                five++;
            }
            else
            {
                Console.WriteLine($"Hacker Rank lied the bird type is {i}");
            }                    
        }

        if (one >= two && one >= three && one >= four && one >= five)
        {
            return 1;
        }
        else if (two > one && two >= three && two >= four && two >= five){
            return 2;
        }
        else if (three > one && three > two && three >= four && three >= five)
        {
            return 3;
        }
        else if (four > one && four > two && four > three && four >= five)
        {
            return 4;
        }
        else if (five > one && five > two && five > three && five > four)
        {
            return 5;
        }
        else
        {
            return 999;
        }
    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = new List<int> { 1, 2, 3, 4, 5, 4, 3, 2, 1, 3, 4 };//Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = migratoryBirds(arr);
        Console.WriteLine(result);
        //textWriter.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
