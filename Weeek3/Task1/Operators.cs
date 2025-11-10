namespace Weeek3;

public class Operators
{
    public void Add(int a, int b)
    {
        int sum =  a + b;
        Console.WriteLine($"Sum of {a} + {b} = {sum}");
    }

    public void Sub(int a, int b)
    {
        int subtract = a - b;
        Console.WriteLine($"Subtract of {a} - {b} = {subtract}");

    }

    public void multi(int a, int b)
    {
        int multiply = a * b;
        Console.WriteLine($"Multiply of {a} * {b} = {multiply}");
    }

    public void div(int a, int b)
    {
        int divisor = a / b;
        Console.WriteLine($"Divisibility of {a} / {b} = {divisor}");
    }

    public void OddEvenfinder(int number)
    {
        string result = (number % 2 == 0) ? "even" : "odd";
        Console.WriteLine($" {number} is an {result} number");
    }
    
}