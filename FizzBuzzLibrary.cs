using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzLibrary
{
    public class FizzBuzzClass
    {
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

        protected int upperBound = 100;
        protected int value1 = 3;
        protected int value2 = 5;
        protected string string1 = "Fizz";
        protected string string2 = "Buzz";

        /* Call FizzBuzz with defaults */
        public List<string> FizzBuzz()
        {
            return FizzBuzz(upperBound, value1, value2);
        }
        
        /* FizzBuzz using provided upperBound */
        public List<string> FizzBuzz(int upperBound, int value1, int value2)
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

            for (int fbCounter = 1; fbCounter <= upperBound ; fbCounter++)
            {
                if ((fbCounter % value1 == 0 ) || (fbCounter % value2 == 0))
                {
                    if ((fbCounter % (value1*value2)) == 0)
                    {
                        fbString.Add(string1 + "-" + string2);
                    }
                    else if ((fbCounter % value1) == 0 )
                    {
                        //Console.WriteLine("Fizz");
                        fbString.Add(string1);
                    }
                    else if ((fbCounter % value2) == 0)
                    {
                        //Console.WriteLine("Buzz");
                        fbString.Add(string2);
                    }
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
