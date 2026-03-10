using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Reflection.Metadata;

namespace Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine(FindDifference(new int[] {2, 2, 3}, new int[] {5, 4, 1}));
        }
        

        public static int FindDifference(int[] a, int[] b)
        {
            int totalOfA = 1;
            foreach (int i in a)
            {
                totalOfA = totalOfA * i;
            }
            int totalOfB = 1;
            foreach (int k in b)
            {
                totalOfB = totalOfB * k;
            }
            return Math.Abs(totalOfA - totalOfB);
        }
        }
    }

