// My Solution
int hpHero = 10, hpMoster = 10;
Random random = new Random();

do
{
    int damage = random.Next(1, 10);
    hpMoster -= damage;
    Console.WriteLine($"Monster was damaged and lost {damage} health and now has {hpMoster} health.");
    if (hpHero <= 0)   
    {
        Console.WriteLine("Monster wins!");
        break;
    }

    damage = random.Next(1, 10);
    hpHero -= damage;
    Console.WriteLine($"Hero was damaged and lost {damage} health and now has {hpHero} health");
    if (hpMoster <= 0)
    {
        Console.WriteLine("Hero wins!");
        break;
    }
} while (true);

// Microsoft Learn Solution
int hero = 10;
int monster = 10;

Random dice = new Random();

do
{
    int roll = dice.Next(1,11);
    monster -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

    if (monster <= 0) continue;

    roll = dice.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health");

} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");