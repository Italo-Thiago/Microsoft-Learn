// My Solutions

using System.ComponentModel;

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
4 => Microsoft Solutions.
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
// Not complete: Failed to print correctly in second loop
    case 3:

        string[] myStrings = { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

        int periodLocation;

        for (int i = 0; i < myStrings.Count(); i++)
        {
            string myString = myStrings[i];
            
            bool loop = true;

            while (loop)
            {
                periodLocation = myString.IndexOf("."); 
                if (periodLocation != -1)
                {
                    string message = myString.Substring(0, periodLocation);
                    Console.WriteLine(message); 
                }
            }
        }

        break;
// Microsoft Solutions
    case 4:
        Console.WriteLine(@"
Choose the solution
1 => Solution One;
2 => Solution Two;
3 => Solution Three;
        ");

        int choose = Convert.ToInt32(Console.ReadLine());

        switch (choose)
        {
    // Solution One
            case 1:
                string? readResult;
                string valueEntered = "";
                int numValue = 0;
                bool validNumber = false;

                Console.WriteLine("Enter an integer value between 5 and 10");

                do
                {
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        valueEntered = readResult;
                    }

                    validNumber = int.TryParse(valueEntered, out numValue);

                    if (validNumber == true)
                    {
                        if (numValue <= 5 || numValue >= 10)
                        {
                            validNumber = false;
                            Console.WriteLine($"You entered {numValue}. Please enter");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Sorry, you entered an invalid number, please try again");
                    }
                } while (validNumber == false);

                Console.WriteLine($"Your input value ({numValue}) has been accepted");

                readResult = Console.ReadLine();
                break;
    // Solution Two
            case 2:
                string? readResultTwo;
                string roleName = "";
                bool validEntry = false;

                do
                {
                    Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        roleName = readResult.Trim();
                    }

                    if (roleName.ToLower() == "administrator" || roleName.ToLower() == "manager" || roleName.ToLower() == "user")
                    {
                        validEntry = true;
                    }
                    else
                    {
                        Console.Write($"The role name that you entered, \"{roleName}\" is not valid. ");
                    }
                } while (validEntry == false);

                Console.WriteLine($"Your input value ({roleName}) has been accepted");
                readResult = Console.ReadLine();
                
                break;
            case 3:
                string[] myStringsTwo = new string[2] { "I like pizza. Iike roast chicken. I like salad", "I like all three of the menu choices"};
                int stringCount = myStringsTwo.Length;

                string myStringTwo = "";
                int periodLocationTwo = 0;

                for (int i = 0; i < stringCount; i++)
                {
                    myStringTwo = myStringsTwo[i];
                    periodLocationTwo = myStringTwo.IndexOf(".");

                    string mySentence;

                    // ING: extract sentences from each string an display them one at a time
                    // PT: extrai frases de cada string e as exibe uma de cada vez
                    while (periodLocationTwo != -1)
                    {
                        // ING: first sentence is the string value to the left of the period location
                        // PT: a primeira frase é o valor da string à esquerda da localização do ponto
                        mySentence = myStringTwo.Remove(periodLocationTwo);

                        // ING: the remainder of myStringTwo is the string value to the right of the location
                        // PT: o restante de myStringTwo é o valor da string à direita da localização
                        myStringTwo = myStringTwo.Substring(periodLocationTwo + 1);

                        // ING: remove any leading white-space from myString
                        // PT: remove qualquer espaço em branco no início de myString
                        myStringTwo = myStringTwo.TrimStart();

                        // ING: update the comma location and increment the counter
                        // PT: atualiza a localização da vírgula e incrementa o contador
                        periodLocationTwo = myStringTwo.IndexOf(".");

                        Console.WriteLine(mySentence);
                    }
                    
                    mySentence = myStringTwo.Trim();
                    Console.WriteLine(mySentence);
                }
                break;

            default:
                Console.WriteLine("End Program");
                break;
        }

        break;
    default:
        Console.WriteLine("End Program");
        break;
}
