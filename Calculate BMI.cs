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
            Console.WriteLine($"BMI: {Bmi(88.12, 1.71)}");
            Console.ReadLine();
        }

        public static string Bmi(double weight, double height)
        {
            double bmi = weight / (height * height);

            if (bmi <= 18.5) {
                return "Underweight";
            } else if (bmi <= 25.0) {
                return "Normal";
            } else if (bmi <= 30.0) {
                return "Overweight"; 
            } else {
                return "Obese";
            }
        }


    }
}
