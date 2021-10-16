namespace dotNet_challenges;

public class Pow
{
    public static void DisplayPowOf3()
    {
        for (var i = 1; i < 20; i++)
        {
            Console.Write($"{Math.Pow(i, 3)} ");
        }
    }
}
