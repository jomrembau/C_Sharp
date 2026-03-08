using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Codewars1
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SayHello(new string[] { "JR", "Mahinay" }, "Chicago", "Illinois"));
            Console.ReadLine();
        }


        
        public static string SayHello(string[] name, string city, string state)
        {
            string text = String.Join(" ", name);
            return $"Hello, {text}! Welcome to {city}, {state}!";
        }
        

    }
}

