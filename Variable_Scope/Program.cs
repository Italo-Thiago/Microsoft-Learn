/* Exemple
-------------------------------------------------------------
bool flag = true;
int value = 0;
if (flag)
{
    Console.WriteLine($"Inside the code block: {value}");
}
value = 10;
Console.WriteLine($"Outside the code block: {value}");
-------------------------------------------------------------
Inside the code block: 0
Outside the code block: 10
*/

/* Code sample 1
-------------------------------------------------------------
bool flag = true;
int value;

if (flag)
{
    value = 10;
    Console.WriteLine($"Inside the code block: {value}");
}

Console.WriteLine($"Outside the code block: {value}");
-------------------------------------------------------------
Build failure
*/

/*  Code sample 2
-------------------------------------------------------------

int value;

if (true)
{
    value = 10;
    Console.WriteLine($"Inside the code block: {value}");
}

Console.WriteLine($"Outside the code block: {value}");
-------------------------------------------------------------
Inside the code block: 10
Outside the code block: 10
*/

/*
bool flag = true;
if (flag)
{  
    Console.WriteLine(flag);
}
// True
*/

// bool flag = true;
// if (flag)
// {
//     Console.WriteLine(flag);
// }
// True

// bool flag = true;
// if (flag)
//     Console.WriteLine(flag);
// True

// bool flag = true;
// if (flag) Console.WriteLine(flag); => True

// Check readability

// string name = "steve";
// if (name == "bob") Console.WriteLine("Found Bob");
// else if (name == "steve") Console.WriteLine("Found Steve");
// else Console.WriteLine("Found Chuck");
// Found Steve

string name = "steve";

if (name == "bob")
    Console.WriteLine("Found Bob");
else if (name == "steve")
    Console.WriteLine("Found Steve");
else  
    Console.WriteLine("Found Chuck");
// Found Steve