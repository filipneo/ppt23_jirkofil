while (true)
{
    int random_number = Random.Shared.Next(1, 101);

    Console.Clear();
    Console.WriteLine($"Guess number from 1 to 100! [{random_number}]");

    while (true)
    {
        string? input = Console.ReadLine();

        if (input == "exit") break;

        if (!int.TryParse(input, out int guess))
        {
            Console.WriteLine("Write number!");
            continue;
        }

        if (guess == random_number)
        {
            Console.WriteLine($"Congrats you guessed it right! My number was {random_number}.");
            break;
        }

        else
        {
            string hint = random_number < guess ? "smaller" : "bigger";
            Console.WriteLine($"My number is {hint}...");
        }
    }

    Console.WriteLine("\nDo you want to play again? [y/n]");
    string? answer = Console.ReadLine();

    if (answer == "y" || answer == "yes") continue;

    else break;
}