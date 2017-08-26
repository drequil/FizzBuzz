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
        static void Main(string[] args)
        {
            var myFizzBuzz = new FizzBuzzClass(100);
            var fbList = new List<string>();
            fbList = myFizzBuzz.FizzBuzz();

            foreach (string fizzBuzz in fbList)
            {
                Console.WriteLine(fizzBuzz);
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