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
            Console.WriteLine(Kata.Include(numbersList, 9));
            Console.ReadLine();
        }

        public class Kata
        {
            public static bool Include(List<int> arr, int item)
            {
                for ( int  i = 0; i < arr.Count; i++)
                    if (arr[i] == item)
                    {
                        return true;
                    }
                return false;
            }
        }
    }
}
