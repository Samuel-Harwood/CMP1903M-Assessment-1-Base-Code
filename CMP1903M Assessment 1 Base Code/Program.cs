//Base code project for CMP1903M Assessment 1
/*Code traversal:
Program.cs -- Handles user choice of manual or file input
Input.cs -- Checks for valid inputs
Analyse.cs -- Analyses input
Report.cs -- Sends analysis of text back to the user
*/
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Program
    {
        internal static void Main()
        {
           var input = new Input();

            Console.WriteLine("1. Enter manually\n2. Enter from text file\n1 or 2: ");
            string? key = Console.ReadLine();
            switch (key)
            {
                case "1":
                    Console.WriteLine("\nWrite your text here: ");
                    string? Manual = Console.ReadLine();
                    input.ManualTextInput(Manual);
                    break;

                case "2":
                    Console.WriteLine("\nEnter File path: "); //Default path = Text.txt
                    string? check = Console.ReadLine();
                    if (File.Exists(check))
                    {
                        var Text = System.IO.File.ReadAllText(check); //You will have to change this to where you place a text file
                        input.FileTextInput(Text);
                    }
                    else
                    {
                        Console.WriteLine("\nPath Not found\n");  
                        Main();
                    }
                    break;
                    
                    
                    

                default:
                    Console.WriteLine("\nPlease enter 1 or 2");
                    Main();
                    break;
            }
        }
  
    }
}
