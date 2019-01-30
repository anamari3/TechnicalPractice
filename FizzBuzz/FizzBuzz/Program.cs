using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main()
        {
            //Step 1 -- Print Numbers from 1 to 100

            //Step 2 -- Divisable by 3 print Fizz

            //Step 3 -- Divisable by 5 print Buzz

            //Step 4 -- Divisable by 3 & 5 print FizzBuzz

            //Step 5 -- Print the number as is if not divisable by 3 or 5


            for (int i = 1; i<=100; i++)
            {
                string results = "";
                if (i % 3 == 0)
                {
                    results="Fizz";
                }
                if (i % 5 == 0)
                {
                    //If divisable by 5 prints Buzz...and if divisable by both 3 and 5, prints Fizz and Buzz (from above)
                    results = results + "Buzz";
                }
                else
                {
                    if (results.Length == 0)
                    {
                        results = i.ToString();
                    }
                }
                Console.WriteLine(results);
            }
            Console.ReadLine();
        }
    }
}
