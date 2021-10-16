namespace dotNet_challenges;

public class LeastCommonMultiple
{
    public static void FindLcm()
    {
        Console.WriteLine("Find the least common multiple for two numbers.");
        Console.WriteLine("Please enter the first number:");
        var firstNum = Helpers.InputToInteger(Console.ReadLine());
        Console.WriteLine("Please enter the second number:");
        var secondNum = Helpers.InputToInteger(Console.ReadLine());

        int lesserValue, greaterValue;
        if (firstNum >= secondNum)
        {
            lesserValue = firstNum;
            greaterValue = secondNum;

        }
        else
        {
            lesserValue = secondNum;
            greaterValue = firstNum;
        }
        for (var i = lesserValue; i <= firstNum * secondNum; i += lesserValue)
        {
            if (i % greaterValue == 0)
            {
                Console.WriteLine(i);
                break;
            }
        }
    }
}
