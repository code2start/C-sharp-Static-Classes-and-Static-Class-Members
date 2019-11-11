using System;

namespace staticclassesandmembers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(Math.Abs(-20));
            Console.WriteLine("Please select the Convertor direction");
            Console.WriteLine("1. from celsius to fahrenheit");
            Console.WriteLine("2. from fahrenheit to celsius");
            string selection = Console.ReadLine();
            double f, c = 0;
            switch (selection)
            {
                case "1":
                    Console.WriteLine("Please enter the celsius temprature");
                    f = TemperatureConvertor.celsiusToFahrenheit(Console.ReadLine());
                    Console.WriteLine($"Temperature in fahrenheit {f} f");
                    break;
                case "2":
                    Console.WriteLine("Please enter the fahrenheit temprature");
                    c = TemperatureConvertor.FahrenheitToCelsius(Console.ReadLine());
                    Console.WriteLine($"Temperature in celsius {c} C");
                    break;
                default:
                    Console.WriteLine("Please select a convertor");
                    break;
            }
        }
    }
}
