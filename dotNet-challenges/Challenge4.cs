namespace dotNet_challenges;

public class Pyramid
{
    public static void DisplayPyramid()
    {
        Console.WriteLine("Welcome to Pyramid of Numbers printer.");
        Console.Write("Please enter a number: ");

        var num = Helpers.InputToInteger(Console.ReadLine(), "number");

        var numCounter = 0;
        var lineCounter = 1;

        for (var i = 1; i <= num; i++)
        {
            Console.Write($"{i} ");
            numCounter++;
            if (numCounter == lineCounter)
            {
                Console.WriteLine();
                numCounter = 0;
                lineCounter++;
            }
        }
    }
}
