using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersList = new List<int> { 22, -6, 32, 82, 9, 25 };
            foreach (int number in MultipleOfIndex(numbersList))
                {
                Console.WriteLine(number);
            }
            Console.ReadLine();

        }

        public static List<int> MultipleOfIndex(List<int> xs)
        {
            List<int> multiples = new List<int>();
            for (int i = 1; i < xs.Count; i++)
            {
                if (xs[i] % i == 0)
                {
                    multiples.Add(xs[i]);
                }
                
            }
            return multiples;
        }
    }
}
