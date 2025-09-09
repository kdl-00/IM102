using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter string: ");
                string str = Console.ReadLine();

                if (str == "*")
                {
                    break;
                }

                string lowerCase = str.ToLower();

                string reversed = "";
                for (int x = lowerCase.Length - 1; x >= 0; x--)
                {
                    reversed += lowerCase[x];
                }

                bool isPalindrome = (lowerCase == reversed);

                Console.WriteLine("\nOriginal String\t\tReversed String\t\tPalindrome?");
                Console.WriteLine("  {0}\t\t\t{1}\t\t\t{2}\n",
                    str,
                    reversed,
                    isPalindrome ? "Yes" : "No"
                );
            }
        }
    }
}
