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

class Result
{

    /*
     * Complete the 'pickingNumbers' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY a as parameter. <---lies it takes in a List<int>
     */

    // thanks to https://github.com/RyanFehr/HackerRank/blob/master/Algorithms/Implementation/Picking%20Numbers/Solution.cs for helping me understand this better.
    public static int pickingNumbers(List<int> a)
    {
        int max = 0;
        List<int> sorted = a.OrderBy(x => x).ToList();

        for (int i =0; i < sorted.Count; i++)
        {
            int current = 1;
            //if (i > 0)   //this is not needed
            //{
            //    if (sorted[i] == sorted[i - 1])
            //    {
            //        continue;
            //    }
            //}
            for (int j = i + 1; j < sorted.Count; j++)
            {
                if (Math.Abs(sorted[j] - sorted[i]) <= 1)
                {
                    current++;
                }
                else
                {
                    break;
                }
                if (current> max)
                {
                    max = current;
                }                
            }
        }
        return max;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = new List<int> {4, 6, 5, 3, 3, 1 };//Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        int result = Result.pickingNumbers(a);
        Console.WriteLine(result);

        //textWriter.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
