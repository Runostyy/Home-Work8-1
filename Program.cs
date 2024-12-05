using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть значення x:");

        string input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Потрібно було ввести число");
            return;
        }

        if (double.TryParse(input, out double x))
        {
            Func<double, double> calculateFunction = x > 0 ? PositiveFunction : NonPositiveFunction;
            double result = calculateFunction(x);
            Console.WriteLine($"F({x}) = {result}");
        }
        else
        {
            Console.WriteLine("Потрібно було ввести число");
        }
    }

    static double PositiveFunction(double x)
    {
        return x * x + 4;
    }

    static double NonPositiveFunction(double x)
    {
        return 0;
    }
}
