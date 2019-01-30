using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        static void Main()
        {
            string s = "Hello World";
            Console.WriteLine("Hello World! becomes " + Reverse(s));
            Console.ReadKey();

        }
    }
}
