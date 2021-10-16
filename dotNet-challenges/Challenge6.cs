namespace dotNet_challenges;

public static class Sum
{
    public static void Floats()
    {
        double sum = 0;
        for (var i = 1; i < 20; i++)
        {
            Console.WriteLine(i);
            sum += 1.0 / i;
        }
        Console.WriteLine($"Sum is: {sum}.");
    }
}
