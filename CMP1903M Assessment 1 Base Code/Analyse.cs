using System;
using System.Collections.Generic;
using System.Linq; 
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


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
                int[] count = new int[128]; //Possible ASCII chars (Extended ASCII uses 256), feel free to change it.
                int maximum = 0;
                Char result = Char.MinValue; //Char is initialised with a 0.
                Array.Clear(count, 0, count.Length); //Zeroes out all the elements.

                foreach( Char c in input)
                {
                    if (c != ' ' && ++count[c] > maximum) //If total count > maximum and not a null value.
                    {
                        maximum = count[c];
                        result = c;
                        //If Two or more characters appear the same amount, the first alphabetically will display.

                    }
                   
                }
                measurements.Add(result);
          


                //7. All words > 7 characters long, saved to .txt file.
                input = Regex.Replace(input, @"[^\w\d\s]", ""); //Removes all punctuation, no longer counted as a letter, used for error handling.
                string[] longest = input.Split(new[] { " " }, StringSplitOptions.None); //Creating a new string array of split words
                string longword = "";
                int max = 0;
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
                Console.WriteLine("Words >= 7 chars long are sent to /bin/Debug/net6.0/Longwords.txt\n");
                System.IO.File.WriteAllLines("Longwords.txt", longwords); //Creates Longwords.txt, sent to /bin/Debug/net6.0/



                //8. Send our list of ints and strings to Report
                Report.Reports(measurements);
            }
        

        }      
    }
}