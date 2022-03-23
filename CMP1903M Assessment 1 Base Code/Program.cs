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
            // create input object
            var input = new Input();


            //Create 'Input' object
            //Get either manually entered text, or text from a file
            Console.WriteLine("1. Enter manually\n2. Enter from text file\n1 or 2: ");

            while (true)
            {
                var input_mode = Convert.ToString(Console.ReadLine());
                if (input_mode == "1")
                {
                    Console.WriteLine("\nWrite your text here: ");
                    string? manual;
                    while (true)
                    {
                        manual = Console.ReadLine();

                        if (manual == null)
                        {
                            Console.WriteLine("The input is invalid, please try again: ");
                        }
                        else
                        {
                            var success = input.ManualTextInput(manual);

                            if (success)
                            {
                                break;
                            } else
                            {
                                Console.WriteLine("Please try again: ");
                            }
                        }
                    }

                    break;
                }

                else if (input_mode == "2")
                {
                    Console.WriteLine("\nPlease enter the path to file input: ");

                    // ask user for a valid path
                    string? file_path;
                    while (true)
                    {
                        file_path = Console.ReadLine();

                        // different errors that could happen
                        if (file_path == null)
                        {
                            Console.WriteLine("Input is invalid, please try again: ");
                        }
                        else if (!File.Exists(file_path))
                        {
                            Console.WriteLine("File doesn't exist, please input a valid file: ");
                        }
                        else
                        {
                            var input_success = input.FileTextInput(file_path);
                            if (input_success) {
                                break;
                            } else
                            {
                                Console.WriteLine("Please try again: ");
                            }
                        }
                    }

                    input.FileTextInput(file_path);

                    break;
                }
                else if (input_mode != "2" || input_mode != "1") //If input is not 1 or 2, Program resets
                {
                    Console.WriteLine("Invalid input, please try again: ");
                }
            }
        }
    }
}
