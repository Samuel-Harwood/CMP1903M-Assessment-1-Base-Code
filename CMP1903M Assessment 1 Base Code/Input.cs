using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Input
    {
        private string? _input;
        public string input { get { return (string)input; } }
        //Handles the text input for Assessment 1

        //Method: manualTextInput
        //Arguments: none
        //Returns: bool (if success or not)
        //Gets text input from the keyboard
        public bool ManualTextInput(string manual)
        {
            Console.WriteLine("Is this correct: {0}Y/N: ", manual);
            string? is_correct;

            while (true)
            {
                is_correct = Console.ReadLine();

                if (is_correct == null)
                {
                    Console.WriteLine("Input is invalid, please try again: ");
                }
                else if (is_correct == "Y")
                {
                    Console.WriteLine("\nYou entered Yes\n");
                    _input = manual;
                    return true;
                }
                else if (is_correct == "N")
                {
                    Console.WriteLine("\nYou entered No");
                    return false;
                }
            }
        }   

        //Method: fileTextInput
        //Arguments: string (the file path)
        //Returns: bool (if its a success or not)
        //Gets text input from a .txt file
        public bool FileTextInput(string path)
        {
            var file = File.ReadAllText(path);

            Console.WriteLine("Is this correct: {0}Y/N: ", file);
            string? is_correct;

            while (true)
            {
                is_correct = Console.ReadLine();

                if (is_correct == null)
                {
                    Console.WriteLine("Input is invalid, please try again: ");
                } else if (is_correct == "Y")
                {
                    Console.WriteLine("\nYou entered Yes\n");
                    _input = file;
                    return true;
                }
                else if (is_correct == "N")
                {
                    Console.WriteLine("\nYou entered No");
                    return false;
                }
            }
            
        }

    }
}
