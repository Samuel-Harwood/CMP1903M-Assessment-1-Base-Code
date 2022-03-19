using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Report
    {
        //Handles the reporting of the analysis
        //Maybe have different methods for different formats of output?
        //eg.   public void outputConsole(List<int>)
        public static void Reports(List <object> measurements)        
        {
            var m = measurements;
            Console.WriteLine("Sentences: {0}\nVowels: {1}\nConsonants: {2}\nUpperCase Letters: {3}\nLowerCase Letters: {4}\nMost common character: {5}\n"
            ,m[0], m[1], m[2], m[3],m[4],m[5]);
            Console.ReadLine();
        }

    }
}

