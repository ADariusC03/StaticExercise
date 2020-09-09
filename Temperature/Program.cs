using System;

namespace Temperature
{
    class Program
    {
        static void Main(string[] args)
        {
           var celsius = TempConverter.FahrenheitToCelsius(80); //output 26.6
            var fahrenheit = TempConverter.CelsiusToFahrenheit(38); // output 100.4

            Console.WriteLine("Results of Converting:");
            Console.WriteLine();
            Console.WriteLine($"Celcius {celsius}");
            Console.WriteLine();
            Console.WriteLine($"Fahrenheit {fahrenheit}");
        }
    }
}
