using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    // ADDITIONAL TEST CLASS
    public class Test
    {
        private string test_text = "Object Oriented programming is a programming paradigm that relies on the concept of classes and objects. " +
            " A class is an abstract blueprint used to create more specific, concrete objects. " +
            "Classes often represent broad categories, like Car or Dog that share attributes. " +
            "These classes define what attributes an instance of this type will have, like colour, but not the value of those attributes for a specific object. " +
            "Classes can also contain functions, called methods available only to objects of that type. " +
            "These functions are defined within the class and perform some action helpful to that specific type of object.";

        private int[] test_data = new int[] { 6,506,189,9,497 };
        // sentences, total characters, vowels, upper case, lower case

        // ADDITIONAL METHOD
        // test to compare generated values with expected values
        public void test()
        {
            Analyse a = new Analyse();
            a.analyseText(test_text);

            int[] values = a.get_values();

            if (values[0] == test_data[0]) Console.WriteLine("sentences correct.");
            else Console.WriteLine("test failed");

            if (values[1] == test_data[2]) Console.WriteLine("vowels correct");
            else Console.WriteLine("test failed");

            if (values[2] == test_data[1] - test_data[2]) Console.WriteLine("consonants correct");
            else Console.WriteLine("test failed");

            if (values[3] == test_data[3]) Console.WriteLine("upper case count correct");
            else Console.WriteLine("test failed");

            if (values[4] == test_data[4]) Console.WriteLine("lower case count correct");
            else Console.WriteLine("test failed");
        }
    }
}
