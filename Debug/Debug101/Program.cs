/*  
This code instantiates a value and then calls the ChangeValue method
to update the value. The code then prints the updated value to the console.
*/
// My Solution
int x = 5;

ChangeValue(x);

void ChangeValue(int value) 
{
    value = 10;
    Console.WriteLine(value);
}
// Microsoft Learn Solution
x = 5;
x = ChangeValue(x);
Console.WriteLine(x);

void ChangeValue(int value) 
{
    value = 10;
    return value;
}