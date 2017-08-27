using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzzLibrary;

namespace ConsoleApplication1
{
    class ConsoleProgram
    {
        const string consoleNullStringWarning = "FB string not produced.";
        static void Main(string[] args)
        {
            var myFizzBuzz = new FizzBuzzClass();
            var fbList = new List<string>();
            
            /* Call the FB producer */
            fbList = myFizzBuzz.FizzBuzz();

            /* Consume by writing to console */
            if (fbList != null)
            {
                foreach (string fizzBuzz in fbList)
                {
                    if (fizzBuzz != null)
                    {
                        Console.WriteLine(fizzBuzz);
                    }
                }
            }
            else
            {
                Console.WriteLine(consoleNullStringWarning);
            }
        }
    }
}


/*
// 1.) Remove dependency on Console.Write, just return the data;
//
// 2.) Unit Testing - Nunit testing cases, including the 15 test case.
// 
// 3.) Make 3 & 5 Fizz & Buzz as parameters.
 * 
 * Github repo & send to Rayne
*/