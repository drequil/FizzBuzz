using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzLibrary
{
    public class FizzBuzzClass
    {
        public static int default_upperBound = 100;
        public static int default_value1 = 3;
        public static int default_value2 = 5;
        public static string default_string1 = "Fizz";
        public static string default_string2 = "Buzz";

        public FizzBuzzClass(){}
        public FizzBuzzClass(int upperBound, int value1, int value2)
        {
            this.upperBound = upperBound;
            this.value1 = value1;
            this.value2 = value2;
        }
        public FizzBuzzClass(int upperBound, int value1, int value2, string string1, string string2)
        {
            this.upperBound = upperBound;
            this.value1 = value1;
            this.value2 = value2;
            this.string1 = string1;
            this.string2 = string2;
        }

        protected int upperBound = FizzBuzzClass.default_upperBound;
        protected int value1 = FizzBuzzClass.default_value1;
        protected int value2 = FizzBuzzClass.default_value2;
        protected string string1 = FizzBuzzClass.default_string1;
        protected string string2 = FizzBuzzClass.default_string2;

        /* Call FizzBuzz with defaults */
        public List<string> FizzBuzz()
        {
            return FizzBuzz(upperBound, value1, value2, string1, string2);
        }
        public List<string> FizzBuzz(int upperBound, int value1, int value2)
        {
            return FizzBuzz(upperBound, value1, value2, string1, string2);
        }        
        /* FizzBuzz using provided upperBound */
        public List<string> FizzBuzz(int upperBound, int value1, int value2, string string1, string string2)
        {
            var fbString = new List<string>();

            /* Check externally-supplied input for correctness/safety */
            if ((upperBound < 1) || (value1 < 1) || (value2 < 1))
            {
                return null;
            }

            /* Save the current values to use as future defaults */
            this.upperBound = upperBound; 
            this.value1 = value1;
            this.value2 = value2;
            this.string1 = string1;
            this.string2 = string2;

            for (int fbCounter = 1; fbCounter <= upperBound ; fbCounter++)
            {
                if ((fbCounter % value1 == 0 ) || (fbCounter % value2 == 0))
                {
                    bool value1Found = false;
                    string resultString = "";

                    if ((fbCounter % value1) == 0 )
                    {
                        resultString = string1;
                        value1Found = true;
                    }
                    if ((fbCounter % value2) == 0)
                    {
                        /* Concat in order to handle multiples and powers */
                        if (value1Found) resultString = string.Concat(resultString, "-"); 
                        resultString = string.Concat(resultString, string2);
                    }
                    fbString.Add(resultString);
                }
                else
                {
                    //Console.WriteLine(i);
                    fbString.Add(fbCounter.ToString());
                }
            }
            return fbString;
        }
    }
}
