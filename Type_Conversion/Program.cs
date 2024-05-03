// Error
// int first = 2;
// string second = "4";
// int result  = first + second;
// Console.WriteLine(result);

// Incorrect = 24
// int first = 2;
// string second = "4";
// string result = first + second;
// Console.WriteLine(result);

// int myInt = 3;
// Console.WriteLine($"int: {myInt}");

// decimal myDecimal = myInt;
// Console.WriteLine($"decimal: {myDecimal}");

// int: 3
// decimal: 3

// Coercion
// decimal myDecimal = 3.14m;
// Console.WriteLine($"decimal: {myDecimal}");

// int myInt = (int)myDecimal;
// Console.WriteLine($"int: {myInt}");

// decimal: 3,14
// int: 3

// decimal myDecimal = 1.234566789m;
// float myFloat = (float)myDecimal;

// Console.WriteLine($"Decimal: {myDecimal}");
// Console.WriteLine($"Float  : {myFloat}");

// Decimal: 1,234566789
// Float  : 1,2345668

// int first = 5;
// int second = 7;
// string message = first.ToString() + second.ToString();
// Console.WriteLine(message);
// Output => 57

// int value = (int)1.5m; // casting truncates
// Console.WriteLine(value);

// int value2 = Convert.ToInt32(1.5m); // converting rounds up
// Console.WriteLine(value2);

// Error
// string name = "Bob";
// Console.WriteLine(int.Parse(name));

// string value = "102";
// int result = 0;
// if (int.TryParse(value, out result))
//     Console.WriteLine($"Measurement: {result}");
// else 
//     Console.WriteLine("Unable to report the measurement");
// Console.WriteLine($"Measurement (w/ offset): {50 + result}");

string value = "bad";
int result = 0;
if (int.TryParse(value, out result))
    Console.WriteLine($"Measurement: {result}");
else
    Console.WriteLine("Unable to report the measurement");

if (result > 0)
    Console.WriteLine($"Measurement (w/ offset): {50 + result}");

// Output => Unable to report the measurement