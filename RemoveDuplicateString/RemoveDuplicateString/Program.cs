using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicateString
{
    class Program
    {
        static void Main()
        {
            string myString = "mmmaaarrriiieeeeee";
            HashSet<char> myStringNoDups = new HashSet<char>(myString);
            foreach (char c in myStringNoDups)
            {
                Console.WriteLine(c);
            }
            Console.ReadKey();

        }
    }
}
