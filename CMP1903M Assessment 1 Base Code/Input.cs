using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Input
    {
       

        public void ManualTextInput(string Manual) //Non-Static Method
        {
            var analysis = new Analyse(); //Analysis objects

            Console.WriteLine("\nIs this correct: {0} Y/N: ", Manual);
            string? isCorrect = Console.ReadLine()?? string.Empty; //fallback value of null
            isCorrect = isCorrect.ToUpper(); //Could be performed on the line above but lead to Warning CS8602
            switch (isCorrect)
            {
                case "Y":
                    Console.WriteLine("\nYou entered Yes\n");
                    analysis.Analysis(Manual);
                    break;

                case "N":
                    Console.WriteLine("\nYou entered No\n");
                    Program.Main();
                    break;

                default:
                    Console.WriteLine("\nNot correct");
                    Program.Main();
                    break;
            }
        }

        public void FileTextInput(string File) //Non-Static Method
        {
            var analysis = new Analyse(); //Analysis objects

            Console.WriteLine("Is this correct: {0}Y/N: ", File);
            string? isCorrect = Console.ReadLine() ?? string.Empty; //fallback value of null
            isCorrect = isCorrect.ToUpper(); //Could be performed on the line above but lead to Warning CS8602
            switch (isCorrect)
            {
                case "Y":
                    Console.WriteLine("\nYou entered Yes\n");
                    analysis.Analysis(File);
                    break;

                case "N":
                    Console.WriteLine("\nYou entered No\n");
                    Program.Main(); //Resets user
                    break;

                default: //!= (Y || N)
                    Console.WriteLine("\nNot a valid option");
                    Program.Main();
                    break;
            }
        }
    }
}
