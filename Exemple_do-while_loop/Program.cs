using System;

Random random = new Random();

/* do while exemple
int current = 0;

do
{
    current = random.Next(1,11);
    Console.WriteLine(current);
} while (current != 7);
*/

int current = random.Next(1,11);

while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");

