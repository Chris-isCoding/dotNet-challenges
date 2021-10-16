namespace dotNet_challenges;

public class Diamond
{
    public static void PrintDiamond()
    {
        Console.WriteLine("Welcome to Diamond Maker.");
        Console.Write("Please enter the size: ");
        var size = Helpers.InputToInteger(Console.ReadLine());
        Console.WriteLine();

        var isOdd = size % 2 != 0;
        var stars = isOdd ? "*" : "**";
        var limit = isOdd ? (int)Math.Floor((double)size / 2) : size
        / 2 - 1;
        var numOfSpaces = limit;
        for (var i = 0; i <= limit; i++)
        {
            Console.WriteLine(new string(' ', numOfSpaces) + stars);
            stars += "**";
            numOfSpaces--;
        }

        numOfSpaces = 0;

        for (var i = stars.Length - 4; i > 0; i -= 2)
        {
            numOfSpaces++;
            Console.WriteLine(new string(' ', numOfSpaces) + stars.Substring
            (0, i));
        }
    }

}
