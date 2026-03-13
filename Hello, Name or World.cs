using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Hello("Jomir"));
        }

        public static string Hello(string name)
    {
        if (name == ""){
            return "Hello, World!";
        } else {
            name = char.ToUpper(name[0]) + name.Substring(1).ToLower();
            return $"Hello, {name}!";
        }

    }
    }

}
