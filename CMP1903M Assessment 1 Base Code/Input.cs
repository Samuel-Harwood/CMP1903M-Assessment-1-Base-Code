using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Input
    {
        //Handles the text input for Assessment 1

        //Method: manualTextInput
        //Arguments: none
        //Returns: string
        //Gets text input from the keyboard
        public static void ManualTextInput(string Manual)
        {

            Console.WriteLine("\nIs this correct: {0} Y/N: ", Manual);
            var isCorrect = Console.ReadLine();
            isCorrect = isCorrect.ToUpper(); 
            if (isCorrect == "Y")
            {
                Console.WriteLine("\nYou entered Yes\n");
                Analyse.Analysis(Manual);
            }
            else if (isCorrect == "N")
            {
                Console.WriteLine("\nYou entered No\n");
                Program.Main();
            }
            else if (isCorrect != "N" || isCorrect != "Y")
            {
                Console.WriteLine("\nNot correct");
                Program.Main();
            }
        }   

        //Method: fileTextInput
        //Arguments: string (the file path)
        //Returns: string
        //Gets text input from a .txt file
        public static void FileTextInput(string File)
        {
            
            Console.WriteLine("Is this correct: {0}Y/N: ", File);
            var isCorrect = Console.ReadLine();
            isCorrect = isCorrect.ToUpper(); 
            if (isCorrect == "Y")
            {
                Console.WriteLine("\nYou entered Yes\n");
                Analyse.Analysis(File);
            }
            else if (isCorrect == "N")
            {
                Console.WriteLine("\nYou entered No\n");
                Program.Main();
            }
            
            
        }

    }
}
