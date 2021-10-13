namespace dotNet_challenges;

public static class PrimeHelper
{
    public static bool IsPrime(int num)
    {
        if (num < 2)
        {
            return false;
        }
        if (num % 2 == 0)
        {
            return num == 2;
        }
        // div * div > num
        for (int divisor = 3; num / divisor >= divisor; divisor += 2)
        {
            if (num % divisor == 0)
            {
                return false;
            }
        }
        return true;
    }
}
