using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{

    /*
     * Complete the timeConversion function below.
     */
    static string timeConversion(string s)
    {
        string time12 = s;
        var amPM = time12.Substring(8);
        var hour = time12.Substring(0, 2);
        var minSec = time12.Substring(2, 6);

        if (amPM == "AM" && hour == "12")
        {
            hour = "00";
        }
        else if(amPM == "PM")
        {
            int hourNumber = Int32.Parse(hour);
            if (hourNumber != 12)
            {
                hourNumber += 12;
                hour = Convert.ToString(hourNumber);
            }
        }
        //Console.WriteLine(hour + minSec);
        return hour + minSec;
    }

    static void Main(string[] args)
    {
       // TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = "07:05:45PM"; //Console.ReadLine();
                    
        string result = timeConversion(s);

        //tw.WriteLine(result);

        //tw.Flush();
        //tw.Close();
    }
}

