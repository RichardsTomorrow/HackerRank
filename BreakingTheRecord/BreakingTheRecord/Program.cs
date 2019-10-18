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

    // Complete the breakingRecords function below.
    static int[] breakingRecords(int[] scores)
    {
        int highTracker = 0;
        int lowTracker = 0;
        int highscore = scores[0];
        int lowscore = scores[0];

        for (int i = 0; i < scores.Length; i++)
        {
            
            if (scores[i]> highscore)
            {
                highTracker++;
                highscore = scores[i];
            }
            else if(scores[i]< lowscore)
            {
                lowscore = scores[i];
                lowTracker++;

            }
        }
        int[] result = new int[2] { highTracker, lowTracker };
        return result;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp))
        ;
        int[] result = breakingRecords(scores);

        textWriter.WriteLine(string.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
