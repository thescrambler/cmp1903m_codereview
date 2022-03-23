using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    // this is an ADDITIONAL CLASS
    public class Output
    {
        // ADDITIONAL METHOD that generates the "file of long words"
        public void write_long_words(List<string> words)
        {
            File.WriteAllLines("long_words.txt", words);

            string path = Directory.GetCurrentDirectory();
            Console.WriteLine("\n\nA file of words longer than 7 chars has been created at {0}", path);
        }
    }
}
