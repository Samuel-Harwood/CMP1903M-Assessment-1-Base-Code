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
       
        private Dictionary<string, int> _measurements = new(); //READ-ONLY (Encapsulation)
        public Dictionary<string, int> Measurements { get { return _measurements; } } //Omitting the set accessor makes the property read-only

        public void Analysis(string input) //Non-Static Method
        {
             //To call report later on.

            switch (input)
            {
                case "": //If no input found
                    Console.WriteLine("No input found"); //Error Handling
                    break; 

                default:


                    //1. Number of sentences
                    //Calculates sentences by the amount of full stops
                    int sentence = 0;
                    for (int i = 0; i < input.Length; i++)
                    {
                        string sentences = input[i].ToString();
                        if (".?!".Contains(sentences)) //Weirdly written backwards
                        {
                            sentence++;
                        }
                    }
                    Measurements.Add("sentence", sentence);



                    //2. Number of vowels
                    int vowelcount = 0;
                    for (int i = 0; i < input.Length; i++)
                    {
                        string vowel = input[i].ToString().ToLower();
                        if ("aeiou".Contains(vowel)) //Weirdly written backwards
                        {
                            vowelcount++;
                        }
                    }
                    Measurements.Add("vowelcount", vowelcount);



                    //3. Number of consonants
                    int consonantcount = 0;
                    for (int i = 0; i < input.Length; i++)
                    {
                        string consonant = input[i].ToString().ToLower();
                        if ("bcdfghjklmnpqrstvwxyz".Contains(consonant)) //If consonant is found
                        {
                            consonantcount++;
                        }
                    }
                    Measurements.Add("consonantcount", consonantcount);



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
                    Measurements.Add("uppercount", uppercount);



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
                    Measurements.Add("lowercount", lowercount);


                    //6. Most Common Character
                    int[] count = new int[128]; //Possible ASCII chars (Extended ASCII uses 256), feel free to change it.
                    int maximum = 0;
                    Char result = Char.MinValue; //Char is initialised with a 0.
                    Array.Clear(count, 0, count.Length); //Zeroes out all the elements.

                    foreach (Char c in input)
                    {
                        if (c != ' ' && ++count[c] > maximum) //If total count > maximum and not a null value.
                        {
                            maximum = count[c];
                            result = c;
                            //If Two or more characters appear the same amount, the first alphabetically will display.

                        }

                    }
                    //Result is a char value and cannot be inserted into our int dictionary.
                    //So we create a new dictionary are parse it into our report class.
                    Dictionary <string, char> mcc = new(); 
                    mcc.Add("result", result);
                    
                    LongCharacters(input);
                    


                    //7. Send our list of ints and strings to Report
                    Report.Reports(Measurements, mcc); //Report is a static method in a Abstracted class
                    break; //End Default Switch statement

            }
        }
        //8. All words > 7 characters long, saved to .txt file.
        //LongCharacters is not sent to Report and so is a seperate method
        private void LongCharacters(string input) //Additional method
        {
            //Removes all punctuation, prevents words ending in punctuation from
            //being considered 1 char longer(incorrect additions to Longwords.txt e.g. Abacus!)
            input = Regex.Replace(input, @"[^\w\d\s]", ""); 
            string[] longest = input.Split(new[] { " " }, StringSplitOptions.None); //Creating a new string array of split words
            List<string> longwords = new();

            foreach (String seven in longest)
            {

                if (seven.Length >= 7)
                {

                    string longword = seven;
                    longwords.Add(longword);

                }

            }
            System.IO.File.WriteAllLines("Longwords.txt", longwords); //Creates Longwords.txt, sent to /bin/Debug/net6.0/
        }
    }
}