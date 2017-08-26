using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzLibrary
{
public class FizzBuzzLibrary
{
    public FizzBuzzLibrary(){}
    public FizzBuzzLibrary(int i)
    {
        this.upperBound = i;
    }

    protected int upperBound = 0;

    public void FizzBuzz()
    {
        FizzBuzz(upperBound);
    }
        
    public void FizzBuzz(int upperBound)
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
