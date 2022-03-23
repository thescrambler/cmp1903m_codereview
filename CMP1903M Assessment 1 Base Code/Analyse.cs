using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Analyse
    {
        // I hope this counts as data abstraction    
        private int[] values = Enumerable.Repeat(0, 5).ToArray();
        private int[] char_freq = Enumerable.Repeat(0, 26).ToArray();
        private List<string> long_words = new List<string>();
        
        // handles the analysis of text
        // changed to void to allow for more outputs, i.e. the attributes above this comment
        public void analyseText(string input)
        {
            // values[sentences, vowels, consonants, upper case, lower case]

            // this exists to prevent a potential error
            // this has to do with how individual words are read
            input += " ";

            int word_end, difference = 0;
            Regex r = new Regex(@"[euioaEUIOA]");

            // iterates through all characters in input and updates values[]
            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];    

                if (char.IsLetter(c))
                {
                    // check if vowel and update values[]
                    if (r.IsMatch( c.ToString() )) values[1]++;
                    else values[2]++;

                    // checks letter case, updates values[] and updates char_freq[] using ascii codes
                    if (char.IsUpper(c))
                    {
                        char_freq[(int)c - 65]++;
                        values[3]++;
                    }
                    else
                    {
                        char_freq[(int)c - 97]++;
                        values[4]++;
                    }
                    // difference marks individual word length, see else statement
                    difference++;
                }
                else
                {
                    // full-stops are interpreted as a sentence
                    if (c.Equals('.')) values[0]++;

                    // check word length and store if longer than 7 characters
                    word_end = i;
                    if (difference > 7)
                    {
                        long_words.Add(input[ (word_end-difference)..word_end] );
                    }
                    difference = 0;
                }
            }
        }

        // private attribute access from outside class (ADDITIONAL METHODS)
        // this class forms a single unit (example of ENCAPSULATION)
        public int[] get_values()
            { return values; }
        public int[] get_char_freq()
            { return char_freq; }
        public List<string> get_long_words()
            { return long_words; }
    }
}
