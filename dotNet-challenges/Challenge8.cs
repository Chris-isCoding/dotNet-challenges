namespace dotNet_challenges;

public class Reverse
{
    public static void ReverseString()
    {
        Console.WriteLine("Please enter a string to reverse it:");

        var inputString = Console.ReadLine();
        var reversed = "";
        if (inputString != null)
            for (var i = inputString.Length - 1; i >= 0; i--)
            {
                reversed += inputString[i];
            }

        Console.WriteLine("\nReversed string is:");
        Console.WriteLine(reversed);
    }
}
