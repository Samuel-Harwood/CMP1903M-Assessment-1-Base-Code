using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Report
    {
        
        public void Reports(Dictionary <string,int> measurements,Dictionary <string,char>MCC) //Non-Static Method        
        {
            var m = measurements;
            var mcc = MCC;

           
            Console.WriteLine($"Sentences: {m["sentence"]}\n" +
                              $"Vowels: {m["vowelcount"]}\n" +
                              $"Consonants: {m["consonantcount"]}\n" +
                              $"Uppercase Letters: {m["uppercount"]}\n" +
                              $"Lowercase Letters: {m["lowercount"]}\n" +
                              $"Most common character: {mcc["result"]}\n" +
                              $"\nLongwords.txt created");

        Console.ReadLine();
            
        }
  

    }
}

