namespace dotNet_challenges;

class MainMenu
{
    static void Main(string[] args)
    {
        var userFinished = false;
        while (!userFinished)
        {
            Console.WriteLine("Please select an option");
            var selectedOption = Console.ReadLine();

            switch (selectedOption)
            {
                case "1":
                    Prime.CountPrimesInRange();
                    break;
                case "end":
                    userFinished = true;
                    break;
                default:
                    Console.WriteLine("Invalid option selected. Try or again or exit");
                    break;
            }
        }
    }
}
