using System;
using static System.Console;
class FahrenheitToCelsiusInteractive
{
    static void Main()
    {
        string Fahrenheit;
        double inputNumber;
        double Celsius;
        Write("Enter Fahrenheit degrees >> ");
        Fahrenheit = ReadLine();
        inputNumber = Convert.ToDouble(Fahrenheit);
        Celsius = (inputNumber - 32) * 5 / 9;
        string Celsius1 = Celsius.ToString("F1");
        WriteLine(Fahrenheit + " degrees Fahrenheit is " + Celsius1 + " degrees Celsius");
    }
}