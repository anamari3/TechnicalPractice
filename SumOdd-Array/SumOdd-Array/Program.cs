using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOdd_Array
{
    class Program
    {
        static void Main()
        {
            int[] arr = new int[6] {1, 2, 3, 4, 5, 6};
            int sum = 0;

            //Loop to find odd numbers
            for (int i = 0; i < arr.Length; i++)
            {
                //If the remainder of each index's is not 0 
                //add that integer to the new array and find 
                //the sum of the array
                if (arr[i] % 2 != 0)
                    sum += arr[i];
            }
            Console.WriteLine("Odd numbers sum: " + sum);
            Console.ReadKey();

        }
    }
}
