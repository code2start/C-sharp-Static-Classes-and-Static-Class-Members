namespace staticclassesandmembers
{
    public static class TemperatureConvertor
    {
        public static double celsiusToFahrenheit(string temperaturCelsius)
        {
            double celsius = double.Parse(temperaturCelsius);
            double fahrenheit = (celsius * 9 / 5) + 32;
            return fahrenheit;
        }

        public static double FahrenheitToCelsius(string temperatureFahrenheit)
        {
            double fahrenheit = double.Parse(temperatureFahrenheit);
            double celsius = (fahrenheit - 32) * 5 / 9;
            return celsius;
        }
    }
}