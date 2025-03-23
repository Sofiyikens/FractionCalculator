using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1;
class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter first fraction (a/b): ");
            Fraction fraction1 = ParseFraction(Console.ReadLine());

            Console.Write("Enter second fraction (c/d): ");
            Fraction fraction2 = ParseFraction(Console.ReadLine());

            Console.WriteLine($"Addition: {fraction1} + {fraction2} = {fraction1 + fraction2}");
            Console.WriteLine($"Subtraction: {fraction1} - {fraction2} = {fraction1 - fraction2}");
            Console.WriteLine($"Multiplication: {fraction1} * {fraction2} = {fraction1 * fraction2}");
            Console.WriteLine($"Division: {fraction1} / {fraction2} = {fraction1 / fraction2}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    static Fraction ParseFraction(string input)
    {
        string[] parts = input.Split('/');
        if (parts.Length != 2 || !int.TryParse(parts[0], out int num) || !int.TryParse(parts[1], out int den))
            throw new FormatException("Invalid fraction format. Use a/b format.");

        return new Fraction(num, den);
    }
}
