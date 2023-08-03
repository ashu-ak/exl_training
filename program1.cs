using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myApp1
{
    internal class program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the temperature in Farenheit");
            float temp = float.Parse(Console.ReadLine());
            float tempInC = (temp - 32) * 5 / 9;
            float tempInK = tempInC + 273;
            string line = $"The Temperature in celcius is {tempInC} and the tempertaure in " +
                $"kelvin is {tempInK} for given temperature {temp} ";
            Console.WriteLine(line);
        }
    }
}
