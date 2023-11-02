Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay())
{
    PlayGame();
}

void PlayGame()
{
    bool play = true;

    while (play)
    {
        int target = GetTarget();
        int roll = RollDice();

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(target, roll));
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}

bool ShouldPlay()
{
    string? answer = Console.ReadLine();
    do
    {
        answer = answer.Trim().ToLower();
        if (answer == "y")
            return true;
        else if (answer == "n")
            return false;
        else
        {
            ClearCurrentConsoleLine();
            answer = Console.ReadLine();
        }

    } while (answer != "n" || answer != "y");
    return false;
}

int GetTarget()
{
    return random.Next(1, 6);
}

int RollDice()
{
    return random.Next(1, 7);
}

string WinOrLose(int target, int roll)
{
    return (roll > target) ? "You Win!" : "You Lose";
}



void ClearCurrentConsoleLine()
{
    int currentLineCursor = Console.CursorTop;
    Console.SetCursorPosition(0, Console.CursorTop - 1);
    Console.Write(new string(' ', Console.WindowWidth));
    Console.SetCursorPosition(0, currentLineCursor - 1);
}