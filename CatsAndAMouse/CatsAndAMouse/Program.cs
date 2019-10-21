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

    // Complete the catAndMouse function below.
    static string catAndMouse(int x, int y, int z) // cat a = x, cat b = y, mouse = z
    {
        int catAToMouse = Math.Abs(x-z);
        int catBToMouse = Math.Abs(y-z);

        if (catAToMouse> catBToMouse)
        {
            return "Cat B";
        }
        else if (catBToMouse> catAToMouse)
        {
            return "Cat A";
        }
        else if (catAToMouse == catBToMouse)
        {
            return "Mouse C";
        }
        else
        {
            return "Your logic is wrong Richard and you should feel bad";
        }
    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //int q = Convert.ToInt32(Console.ReadLine());

        //for (int qItr = 0; qItr < q; qItr++)
        //{
            //string[] xyz = Console.ReadLine().Split(' ');
            // cat a = x, cat b = y, mouse = z
            int x = 1; //Convert.ToInt32(xyz[0]);

            int y = 3; //Convert.ToInt32(xyz[1]);

            int z = 2; // Convert.ToInt32(xyz[2]);

            string result = catAndMouse(x, y, z);
            Console.WriteLine(result);

        //    //textWriter.WriteLine(result);
        //}

        //textWriter.Flush();
        //textWriter.Close();
    }
}
