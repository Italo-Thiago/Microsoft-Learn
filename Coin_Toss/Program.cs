// My solution
// Random random = new Random();
// int Face = random.Next(1,10);
// Console.WriteLine($"Coin is :{(Face >= 5 ? "heads" : "tails")}");

// Course Solution
Random coin = new Random();
Console.WriteLine($"Coin is: {(coin.Next(0,2) == 0 ? "heads" : "tails")}");
