using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{

    /*
     * Complete the pageCount function below.
     */

    // helpf from https://github.com/RyanFehr/HackerRank/blob/master/Algorithms/Implementation/Drawing%20Book/Solution.cs
    static int pageCount(int n, int p)  // n=total pages in book p= page turned to
    {
        int minTurns = 0;


        if (p == 1 || p == n)
            return minTurns;
        if (n % 2 != 0 && p == n-1)
            return minTurns;


        if (n % 2 == 0)
        {
            //even number of total pages e.g. 10
            if (p <= n / 2)
            {
                //start from front
                minTurns = p / 2;
                //Console.WriteLine("1");
            }
            else
            {
                //start from end
                double d = ((double)(n - p)) / 2;
                minTurns = (int)Math.Ceiling(d);
                //minTurns = (n - p) / 2;
                //Console.WriteLine("2");
            }
        }
        else
        {
            if (p == (n / 2) + 1 && n % 4 == 3)
            {
                //this requires special handling as this median will be close to the end instead
                minTurns = ((n - p) / 2);
                //Console.WriteLine("3");
            }
            else
            {
                if (p <= ((n / 2)+ 1))
                {
                    //start from front
                    minTurns = p / 2;
                    //Console.WriteLine("4");
                }
                else
                {
                    //start from end
                    minTurns = (n - p) / 2;
                    //Console.WriteLine("5");
                }
            }
        }

        return minTurns;
    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = 7;//Convert.ToInt32(Console.ReadLine());

        int p = 3;//Convert.ToInt32(Console.ReadLine());

        int result = pageCount(n, p);
        Console.WriteLine(result);

        //textWriter.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
