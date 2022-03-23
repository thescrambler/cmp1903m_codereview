using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Report
    {
        //Handles the reporting of the analysis
        //Maybe have different methods for different formats of output? no
        //eg.   public void outputConsole(List<int>)
        public void console_out(int[] result, int[] char_freq)
        {
            // output basic details
            Console.WriteLine("\n# of sentences: {0}\n" +
                "# of vowels: {1}\n" +
                "# of consonants: {2}\n" +
                "# of upper case characters: {3}\n" +
                "# of lower case characters: {4}\n", 
                result[0], result[1], result[2], result[3], result[4]);

            // output individual character frequencies
            Console.WriteLine("Individual character frequencies: ");

            int counter = 0;
            foreach(int i in char_freq)
            {
                if (counter % 4 == 0)
                {
                    Console.WriteLine();
                }

                Console.Write("{1} '{0}'   ", (char)(counter+97), i.ToString("D2"));
                counter++;
            }
            Console.WriteLine();
        }
    }
}
