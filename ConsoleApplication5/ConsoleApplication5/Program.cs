using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            for (int i = 1; i <= 42; i++)
            {
                numbers.Add(i);
            }


            Random rand = new Random();
            for (int i = 0; i < 6; i++)
            {
                int r = rand.Next(1, numbers.Count);
                Console.WriteLine(numbers[r]);


                numbers.RemoveAt(r);
            }
            Console.ReadKey();
        }

    }
}

