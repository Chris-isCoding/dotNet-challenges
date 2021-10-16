namespace dotNet_challenges;

public class Binary
{
    public static void ConvertToBinary()
    {
        Console.WriteLine("Please enter a number to convert to binary representation");
        var inputAsInt = Helpers.InputToInteger(Console.ReadLine());

        Console.WriteLine($"Binary: { Convert.ToString(inputAsInt, 2)}");
    }
}
