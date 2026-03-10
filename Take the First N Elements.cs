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
            Console.WriteLine(string.Join(", ", Kata.Take(new int[] { 0, 1, 2, 3, 5, 8, 13 }, 3)));
            Console.ReadLine();
        }

        public static class Kata
        {
            public static int[] Take(int[] arr, int n)
            {
                List<int> newList = new List<int>();
                for (int i = 0; i < n; i++)
                {
                    newList.Add(arr[i]);
                    
                }
                return newList.ToArray();
            }
        }
    }
}
