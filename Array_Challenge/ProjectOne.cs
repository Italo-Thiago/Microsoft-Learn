using System.Diagnostics.Contracts;
using System.Globalization;
using Microsoft.VisualBasic;

Console.Clear();
Console.WriteLine(@"
Select Program
1 => ProjectOne
2 => ProjectTwo
");
int choose = Convert.ToInt32(Console.ReadLine());

switch (choose)
{
    case 1:
        CultureInfo.CurrentCulture = new CultureInfo("en-US");

        string[] values = { "12.3", "45", "ABC", "11", "DEF"};
        string message = "";

        decimal numbers = 0;
        decimal total;

        foreach (string value in values)
        {
            if (decimal.TryParse(value, out total))
                numbers += total;
            else
                message += value;
        }
        Console.WriteLine($"Message: {message}");
        Console.WriteLine($"Total {numbers}");

        break;
    case 2:
        int value1 = 11;
        decimal value2 = 6.2m;
        float value3 = 4.3f;

        // My Solution => int result1 = value1 / (int) value2; => 1
        // Solution is
        int result1 = Convert.ToInt32(value1 / value2);

        // Your code here  to set result1
        // Hint: You need to round the result to nearest integer (don't just truncate)
        Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

        decimal result2 = value2 / (decimal)value3;
        // Your code her to set result2 
        Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

        float result3 = value3 / value1;
        // Your code here to set result3
        Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");

        break;
    default:
        Console.WriteLine("Exit to Program");
        break;
}   


