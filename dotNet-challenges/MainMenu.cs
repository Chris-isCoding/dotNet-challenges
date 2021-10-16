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
                case "q":
                    userFinished = true;
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
