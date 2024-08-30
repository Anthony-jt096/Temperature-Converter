using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Temperature Converter");
        Console.WriteLine("1. Celsius to Fahrenheit");
        Console.WriteLine("2. Fahrenheit to Celsius");
        Console.WriteLine("3. Celsius to Kelvin");
        Console.WriteLine("4. Kelvin to Celsius");
        Console.WriteLine("5. Fahrenheit to Kelvin");
        Console.WriteLine("6. Kelvin to Fahrenheit");
        Console.Write("Enter your choice [1] [2] [3] [4] [5] [6]: ");

        int choice = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter temperature: ");
        double temp = Convert.ToDouble(Console.ReadLine());

        double result;

        switch (choice)
        {
            case 1:
                result = (temp * 9 / 5) + 32;
                Console.WriteLine($"{temp}°C is {result}°F");
                break;
            case 2:
                result = (temp - 32) * 5 / 9;
                Console.WriteLine($"{temp}°F is {result}°C");
                break;
            case 3:
                result = temp + 273.15;
                Console.WriteLine($"{temp}°C is {result}K");
                break;
            case 4:
                result = temp - 273.15;
                Console.WriteLine($"{temp}K is {result}°C");
                break;
            case 5:
                result = (temp - 32) * 5 / 9 + 273.15;
                Console.WriteLine($"{temp}°F is {result}K");
                break;
            case 6:
                result = (temp - 273.15) * 9 / 5 + 32;
                Console.WriteLine($"{temp}K is {result}°F");
                break;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }

}