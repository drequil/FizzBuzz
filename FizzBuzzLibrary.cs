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
        public FizzBuzzClass(int i)
        {
            this.upperBound = i;
        }

        protected int upperBound = 0;

        /* Call FizzBuzz with default upperBound */
        public List<string> FizzBuzz()
        {
            return FizzBuzz(upperBound);
        }
        
        /* FizzBuzz using provided upperBound */
        public List<string> FizzBuzz(int upperBound)
        {
            var fbString = new List<string>();

            for (int fbCounter = 1; fbCounter <= upperBound ; fbCounter++)
            {
                if ((fbCounter % 3 == 0 ) || (fbCounter % 5 == 0))
                {
                    if ((fbCounter % (3*5)) == 0)
                    {
                        fbString.Add("Fizz-Buzz!");
                    }
                    else if ((fbCounter % 3) == 0 )
                    {
                        //Console.WriteLine("Fizz");
                        fbString.Add("Fizz");
                    }
                    else if ((fbCounter % 5) == 0)
                    {
                        //Console.WriteLine("Buzz");
                        fbString.Add("Buzz");
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
