using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string: ");
            string str = Console.ReadLine();
            string[] arrays = str.Split(' ');

            int count = 1;
            foreach (string arr in arrays)
            {
                int num = int.Parse(arr);
                if (IsPrime(num))
                {
                    Console.WriteLine($"{count}. {num,5}   Prime");
                }
                else
                {
                    Console.WriteLine($"{count}. {num,5}   Composite");
                }
                count++;
            }

            Console.Write("\nEnter currency in ($): ");
            string currency = Console.ReadLine();
            string[] dollars = currency.Split(',');

            Console.WriteLine("\nDollar($)\tPhil Peso(P)\tJpn Yen (Y)");

            foreach (string oneDollar in dollars)
            {
                double dollar = double.Parse(oneDollar.Trim());
                var (peso, yen) = ConvertCurrency(dollar);

                Console.WriteLine($"{dollar:N0}\t\t{peso:N2}\t\t{yen:N2}");
            }
        }

        static bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }
            else
            {
                for (int i = 2; i <= number / 2; i++)
                {
                    if (number % i == 0)
                    {
                        return false; 
                    }
                }
                return true;
            }
        }

        static (double peso, double yen) ConvertCurrency(double dollar)
        {
            double pesoRate = 57.17;
            double yenRate = 146.67;

            double peso = dollar * pesoRate;
            double yen = dollar * yenRate;

            return (peso, yen);
        }
    }
}