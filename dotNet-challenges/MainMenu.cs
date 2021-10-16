namespace dotNet_challenges;

class MainMenu
{
    static void Main(string[] args)
    {
        var userFinished = false;
        while (!userFinished)
        {
            Console.WriteLine("Please select an option");
            Console.WriteLine("1 - to see solution to Challenge 1");
            Console.WriteLine("2 - to see solution to Challenge 2");
            Console.WriteLine("3 - to see solution to Challenge 3");
            Console.WriteLine("4 - to see solution to Challenge 4");
            Console.WriteLine("5 - to see solution to Challenge 5");
            Console.WriteLine("6 - to see solution to Challenge 6");
            Console.WriteLine("7 - to see solution to Challenge 7");
            Console.WriteLine("8 - to see solution to Challenge 8");
            Console.WriteLine("9 - to see solution to Challenge 9");
            Console.WriteLine("q - to quit the program");
            var selectedOption = Console.ReadLine();

            switch (selectedOption)
            {
                case "1":
                    Prime.CountPrimesInRange();
                    break;
                case "2":
                    Even.DisplayEvenNumsInRange();
                    break;
                case "3":
                    Fibonacci.DisplayFibonacci();
                    break;
                case "4":
                    Pyramid.DisplayPyramid();
                    break;
                case "5":
                    Pow.DisplayPowOf3();
                    break;
                case "6":
                    Sum.Floats();
                    break;
                case "7":
                    Diamond.PrintDiamond();
                    break;
                case "8":
                    Reverse.ReverseString();
                    break;
                case "9":
                    Binary.ConvertToBinary();
                    break;
                case "q":
                    return;
                default:
                    Console.WriteLine("Invalid option selected. Try or again or exit");
                    break;
            }
            Console.WriteLine("\n\nPress enter key to continue or q to quit");
            if (Console.ReadLine() == "q")
            {
                userFinished = true;
            }

        }
    }
}
