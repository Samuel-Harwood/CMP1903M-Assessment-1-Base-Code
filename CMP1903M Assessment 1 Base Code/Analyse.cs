using System;
using System.Collections.Generic;
using System.Linq; 
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Analyse
    {
       
        public static void Analysis(string input) //Our text file or user input
        {

            //0. Base Case, No input
            if (input == "")
            {
                Console.WriteLine("No input found"); //Error Handling
            }
            else
            {
                List<object> measurements = new List<object>(); //List to store our outputs

                //1. Number of sentences
                //Calculates sentences by the amount of full stops
                int sentence = 0;
                char fullstop = char.Parse(".");
                foreach (char c in input)
                {
                    if (c == fullstop)
                    {
                        sentence++;

                    }
                }
                measurements.Add(sentence);



                //2. Number of vowels
                int vowelcount = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    string vowel = input[i].ToString();
                    if ("aeiou".Contains(vowel)) //Weirdly written backwards
                    {
                        vowelcount++;
                    }
                }
                measurements.Add(vowelcount);



                //3. Number of consonants
                int consonantcount = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    string consonant = input[i].ToString();
                    if ("bcdfghjklmnpqrstvwxyz".Contains(consonant)) //If consonant is found
                    {
                        consonantcount++;
                    }
                }
                measurements.Add(consonantcount);



                //4. Number of upper case letters
                int uppercount = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    string upper = input[i].ToString();
                    if ("ABCDEFGHIJKLMNOPQRSTUVWXYZ".Contains(upper)) //If upper case letter is found
                    {
                        uppercount++;
                    }
                }
                measurements.Add(uppercount);



                //5. Number of lower case letters
                int lowercount = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    string lower = input[i].ToString();
                    if ("abcdefghijklmnopqrstuvwxyz".Contains(lower)) //If lower case letter is found
                    {
                        lowercount++;
                    }
                }
                measurements.Add(lowercount);

              

                //6. Most Common Character
                string[] check = input.Split(",");
                foreach (string character in check)
                {
                    var c = character.ToString().GroupBy(x => x)
                        .OrderByDescending(s => s.Count())
                        .First().Key;
                    measurements.Add(c);
                    //If two or more chars are the MCC, nothing is displayed
                }

                //7. Longest words
                string[] longest = input.Split(new[] {" "}, StringSplitOptions.None); //Creating a new string array of split words
                string word = "";
                int max = 0;
                foreach (String len in longest)
                {
                    if(len.Length > max)
                    {
                        word = len;
                        max = len.Length;
                    }
                }
                measurements.Add(word);

                //8. All words > 7 characters long, saved to .txt file.
                string longword = "";
                List<string> longwords = new List<string>();

                foreach (String seven in longest)
                {
                    if (seven.Length >= 7)
                    {
                        longword = seven;
                        max = seven.Length;
                        longwords.Add(longword);
                       
                    }
                    
                }
                Console.WriteLine("Words > 7 chars sent to /bin/Debug/net6.0/Longwords.txt\n");
                System.IO.File.WriteAllLines("Longwords.txt", longwords);


                //9. Send our list of ints and strings to Report
                Report.Reports(measurements);
            }
        

        }      
    }
}