//Base code project for CMP1903M Assessment 1
/*Code traversal:
Program.cs
Input.cs
Analyse.cs
Report.cs
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

            try
            {
                //Create 'Input' object
                //Get either manually entered text, or text from a file
                Console.WriteLine("1. Enter manually\n2. Enter from text file\n1 or 2: ");
                var input = Convert.ToString(Console.ReadLine());
                if (input == "1")
                {
                    Console.WriteLine("\nWrite your text here: ");
                    string Manual = Console.ReadLine();
                    Input.manualTextInput(Manual);

                }
                
                else if (input == "2")
                {
                    string Text = System.IO.File.ReadAllText("Text.txt"); //You will have to change this to where you place a text file
                    Input.fileTextInput(Text);

                }
                else if (input != "2" || input != "1") //If input is not 1 or 2, Program resets
                {
                    Console.WriteLine("\nPlease enter 1 or 2");
                    Program.Main();
                }
            }
            catch(Exception ex) //If user creates an error, that error is sent to the console
            {
                Console.WriteLine(ex.ToString()); //Error Handling
            }
    
           
        }
        
        
    
    }
}
