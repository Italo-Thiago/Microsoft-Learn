
static bool IsNumeric(string? value)
{
    double result;
    return double.TryParse(value, out result);
}
Console.Clear();
Console.WriteLine("""
Choose an option.
1 => Project One;
2 => Project Two;
3 => Project Three;
""");
int choice = Convert.ToInt32(Console.ReadLine());

switch (choice)
{
// Project One
    case 1:
        bool condition = true;
        do
        {   
            Console.WriteLine("Enter an integer value between 5 and 10");

            string? input = Console.ReadLine();
            input.Trim();

            if (String.IsNullOrEmpty(input))
                Console.WriteLine("Type something please");
            else if (IsNumeric(input))
            {
                int number = Convert.ToInt32(input);
                
                if (number >= 5 && number <= 10)
                {
                    Console.WriteLine($"Your input value ({number}) has been accepted");
                    condition = false;
                }
                else
                    Console.WriteLine("Sorry, you entered an invalid number, please try again");
            }
        } while (condition);
        break;

// Project Two
    case 2:
        Console.WriteLine("Enter your role name (Administrator, Manager, or User)");

        bool conditionTwo = true;

        while (conditionTwo)
        {
            string? level = Console.ReadLine();
            level.Trim();

            if (level.ToLower() == "administrator")
            {
                Console.WriteLine("Your input value (Administrator) has been accepted");
                break;
            }
            else if (level.ToLower() == "manager")
            {
                Console.WriteLine("Your input value (Administrator) has been accepted");
                break;
            }
            else if (level.ToLower() == "user")
            {
                Console.WriteLine("Your input value (User) has been accepted");
                break;
            }
            else
                Console.WriteLine("The role name that you entered, " + level + " is not valid. Enter your role name (Administrator, Manager, or User)");
        }
        break;

// Project Three
    case 3:

        // Declarar um array de Strings    
        string[] myStrings = { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

        int periodLocation;

        // For que separa as duas Strings
        for (int i = 0; i < myStrings.Count(); i++)
        {
            // Separação das suas strings
            string myString = myStrings[i];

            // Pega o index do sinal de "."
            periodLocation = myString.IndexOf(".");
            
            do 
            {
                // Separar as palavras a partir do sinal de ponto e 

                // Guardar em uma substring
                
                // imprimir na tela
                Console.WriteLine();
            } while (periodLocation != -1);
        }

        break;

    default:
        Console.WriteLine("End Program");
        break;
}
