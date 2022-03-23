//Base code project for CMP1903M Assessment 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Program
    {
        static void Main()
        {
            // manual toggle to run the test method
            bool test = false;
            if (test)
            {
                Test t = new Test();
                t.test();
            }

            //Create 'Input' object
            //Get either manually entered text, or text from a file
            string option;
            while (true)
            {
                Console.Write("Select option (\"1\" or \"2\"): ");
                option = Console.ReadLine();

                if (option.Equals("1") | option.Equals("2"))
                {
                    break;
                }
                Console.WriteLine("Wrong input.");
            }

            Input i = new Input();
            string text;
            if (option.Equals("1"))
            {
                text = i.manualTextInput();
            }
            else
            {
                Console.Write("Type in file path: ");
                string path = Console.ReadLine();
                text = i.fileTextInput(path);
            }

            if (text != null)
            {
                //Create an 'Analyse' object
                //Pass the text input to the 'analyseText' method
                Analyse a = new Analyse();
                a.analyseText(text);

                //Receive a list of integers back

                //Report the results of the analysis
                Report r = new Report();
                r.console_out( a.get_values() , a.get_char_freq() );

                if (option.Equals("2"))
                {
                    Output o = new Output();
                    o.write_long_words( a.get_long_words() );
                }
            }
            else
            {
                Console.WriteLine("Input cannot be null.");
            }  
        }
    }
}
