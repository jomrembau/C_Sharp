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
           Console.WriteLine(GetRealFloor(3));
        }

        public static int GetRealFloor(int n)
        {
            if (n <= 0) {
                return n;
            } else if ( n > 0 && n < 13 ) {
                return n - 1;
            } else {
                return n - 2;  
            }
        }
        

        
    }
}

