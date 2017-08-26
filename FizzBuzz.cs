using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzLibrary
{
public class FizzBuzz
{
    public FizzBuzz(){}
    public FizzBuzz(int i)
    {
        this.upperBound = i;
    }

    public int upperBound = 0;

    public void FizzBuzzer()
    {
        FizzBuzzer(upperBound);
    }
        
    public void FizzBuzzer(int upperBound)
    {   
            for (int i = 1; i <= upperBound ; i++)
            {
                if ((i % 3 == 0 ) || (i % 5 == 0))
                {
                    if (i % 3 == 0 )
                    {
                        Console.WriteLine("Fizz");
                    }
                    if (i % 5 == 0)
                    {
                        Console.WriteLine("Buzz");
                    }
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
