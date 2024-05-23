// My Solution
string[,] corporate = 
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external = 
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "@hayworth.com";
string corporateDomain = "@contoso.com";

for (int i = 0; i < corporate.GetLength(0); i++) 
{
    emailFormat(i,corporate,corporateDomain);
}

for (int i = 0; i < external.GetLength(0); i++) 
{
    emailFormat(i,external,externalDomain);
}

void emailFormat(int index, string[,] array, string email)
{
    string firstName = array[index,0].ToLower();
    string firstTwoCharacter = firstName.Remove(2);

    string secondName = array[index,1].ToLower();

    Console.WriteLine(firstTwoCharacter + secondName + email);
}

// Microsoft Learn Solution
/*
string[,] corporate = 
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}};

string[,] external = 
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";

for (int i = 0; i < corporate.GetLength(0); i++) 
{
    DisplayEmail(first: corporate[i,0], last: corporate[i,1]);
}

for (int i = 0; i < external.GetLength(0); i++) 
{
    DisplayEmail(first: external[i,0], last: external[i,1], domain: externalDomain);
}

void DisplayEmail(string first, string last, string domain = "contoso.com") 
{
    string email = first.Substring(0, 2) + last;
    email = email.ToLower();
    Console.WriteLine($"{email}@{domain}");
}
*/