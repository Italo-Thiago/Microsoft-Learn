// Method Return

Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay()) 
{
    PlayGame();
}

void PlayGame() 
{
    var play = true;

    while (play) 
    {
        var target = new Random();
        var roll = new Random();

        int t = target.Next(1,5);
        int r = roll.Next(1,6);

        Console.WriteLine($"Roll a number greater than {t} to win!");
        Console.WriteLine($"You rolled a {r}");
        Console.WriteLine(WinOrLose(t, r));
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}

bool ShouldPlay()
{
    string choice = Console.ReadLine().ToLower();
    
    if (choice == "y")
    {
        return true;
    }
    else 
    { 
        return false;
    }
}

string WinOrLose(int target, int roll)
{
    if (target < roll)
    {
        return "You win!";
    }
    else
    {
        return "You lose!";
    }
}
// Microsoft Learn Solution
// Random random = new Random();

// Console.WriteLine("Would you like to play? (Y/N)");
// if (ShouldPlay()) 
// {
//     PlayGame();
// }

// bool ShouldPlay() 
// {
//     string response = Console.ReadLine();
//     return response.ToLower().Equals("y");
// }

// void PlayGame() 
// {
//     var play = true;

//     while (play) {
//         var target = GetTarget();
//         var roll = RollDice();

//         Console.WriteLine($"Roll a number greater than {target} to win!");
//         Console.WriteLine($"You rolled a {roll}");
//         Console.WriteLine(WinOrLose(roll, target));
//         Console.WriteLine("\nPlay again? (Y/N)");

//         play = ShouldPlay();
//     }
// }

// int GetTarget() 
// {
//     return random.Next(1, 6);
// }

// int RollDice() 
// {
//     return random.Next(1, 7);
// }

// string WinOrLose(int roll, int target) 
// {
//     if (roll > target) 
//     {
//         return "You win!";
//     }
//     return "You lose!";
// }