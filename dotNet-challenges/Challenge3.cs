namespace dotNet_challenges;

public class Fibonacci
{
    public static void DisplayFibonacci()
    {
        Console.WriteLine("Program will display fibonacci number till the limit provided.");
        Console.Write("Please enter the upper limit: ");

        var limit = Helpers.InputToInteger(Console.ReadLine(), "number");

        Console.WriteLine($"Fibonacci numbers till {limit}");

        var fib1 = 0;
        var fib2 = 1;

        while (fib1 < limit)
        {
            Console.Write($"{fib1} ");
            fib2 += fib1;
            fib1 = fib2 - fib1;
        }

    }
}
