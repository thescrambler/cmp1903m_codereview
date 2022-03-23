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
        string text = null;
        
        //Method: manualTextInput
        //Arguments: none
        //Returns: string
        //Gets text input from the keyboard
        public string manualTextInput()
        {
            Console.Write("Type some text: ");
            text = Console.ReadLine();

            return text;
        }

        //Method: fileTextInput
        //Arguments: string (the file path)
        //Returns: string
        //Gets text input from a .txt file
        public string fileTextInput(string fileName)
        {
            try
            {
                text = System.IO.File.ReadAllText(@fileName);
            }
            catch
            {
                Console.WriteLine("File could not be found, Ensure that the file-path is written correctly." +
                    "\n You need to re-run the program to try again.");
            }
            
            return text;
        }
    }
}
