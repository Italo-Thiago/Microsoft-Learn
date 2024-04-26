// Increment
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}

// Decrement
for (int i = 10; i >= 0; i--)
{
    Console.WriteLine(i);
}

// From 3 to 3
for (int i = 0; i < 10; i += 3)
{
    Console.WriteLine(i);
}

// Break
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    if (i == 7 ) break;
}

// Array
string[] names = {"Alex", "Eddie", "David", "Michael"};
for (int i = names.Length - 1; i >= 0; i--)
{
    Console.WriteLine(names[i]);
}

// Limitations
// foreach (var name in names)
// {
//     // Can't do this:
//     if (name == "David") name = "Sammy";
// }

// Without the pattern
for (int i = 0; i < names.Length; i++)
    if (names[i] == "David") names[i] = "Sammy";

foreach (var name in names) Console.WriteLine(name);

// With the standard
for (int i = 0; i < names.Length; i++)
{
    if (names[i] == "David")
    {
        names[i] = "Sammy";
    }
}

foreach (var name in names)
{
    Console.WriteLine(name);
}
