using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter row: ");
            int row = int.Parse(Console.ReadLine());

            Console.Write("Enter col: ");
            int col = int.Parse(Console.ReadLine());

            List<List<double>> darray = new List<List<double>>();

            for (int x = 0; x < row; x++)
            {
                Console.WriteLine($"Row {x + 1}");
                List<double> rows = new List<double>();

                for (int y = 0; y < col; y++)
                {
                    Console.Write($"Enter number{y + 1}: ");
                    double num = double.Parse(Console.ReadLine());
                    rows.Add(num);
                }
                darray.Add(rows);
            }

            Console.WriteLine("\nThe numbers are:");
            double sum = 0;
            int count = 0;

            foreach (var rows in darray)
            {
                foreach (var num in rows)
                {
                    Console.Write($"{num:0.0} ");
                    sum += num;
                    count++;
                }
                Console.WriteLine();
            }

            double average = sum / count;

            Console.WriteLine($"\nSum: {sum}; Average: {average}");
        }
    }
}
