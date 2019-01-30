using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfAnArray
{
    class Program
    {
        static int sum(int[] arr, int n)
        {
            int sum = 0; //initialize sum

            //Loop through each element and add each to the sum
            for (int i = 0; i < n; i++)
                sum += arr[i];

            return sum;

        }

        static void Main()
        {
            int[] arr = { 3250, 2560, 5670};
            int n = arr.Length;
            Console.WriteLine("The sum of the given array is " + sum(arr, n));
            Console.ReadKey();

        }
    }
}
