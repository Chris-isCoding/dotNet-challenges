namespace dotNet_challenges;

public class Even
{
    public static void DisplayEvenNumsInRange()
    {
        Console.WriteLine("Even numbers in range 0 - 1000 are: ");
        var num = 0;
        do
        {
            if (num % 2 == 0)
            {
                Console.WriteLine(num);
            }

            num++;
        } while (num <= 1000);
    }
}
