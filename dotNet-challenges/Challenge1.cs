
using dotNet_challenges;

var counter = 0;
var currentNum = 0;
while (currentNum <= 100)
{
    if (PrimeHelper.IsPrime(currentNum))
    {
        counter++;
    }
    currentNum++;
}

Console.WriteLine($"There are {counter} Prime Numbers in the range from 0 to 100");
