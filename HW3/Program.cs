using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string: ");
            string input = Console.ReadLine();

            string[] words = input.Split(',');

            foreach (string word in words)
            {
                string trimmed = word.Trim();
                Dictionary<char, int> result = GetFrequency(trimmed);

                int count = 0;
                foreach (var res in result)
                {
                    count++;
                    Console.Write($"{res.Key}={res.Value}");
                    if (count < result.Count)
                        Console.Write(", ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        static Dictionary<char, int> GetFrequency(string text)
        {
            Dictionary<char, int> frequency = new Dictionary<char, int>();
            Dictionary<char, char> firstLetter = new Dictionary<char, char>();

            foreach (char c in text)
            {
                if (c == ' ') { 
                    continue; 
                }

                char lowerCase = char.ToLower(c);

                if (!firstLetter.ContainsKey(lowerCase))
                {
                    firstLetter[lowerCase] = c;
                }

                if (frequency.ContainsKey(lowerCase)) { 
                    frequency[lowerCase]++;
                }
                else
                {
                    frequency[lowerCase] = 1;
                }
            }

            Dictionary<char, int> result = new Dictionary<char, int>();
            foreach (var freq in frequency)
            {
                result[firstLetter[freq.Key]] = freq.Value;
            }

            return result;
        }
    }
}
