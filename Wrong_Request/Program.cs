/*
PT
1. Separar cada palavra pelo sinal "," usando .Split e colocar dentro de um array de string;
2. Percorre cada elemento usando um loop for, e transforma cada palavra em um array de char;
3. Se o tamanho for menor ou maior que 4 usamos o Array.Length para comparar o tamanho;
4. Transformamos o array de char em uma String Novamente e usamos o Console.WriteLine() para colocar no terminal.

EN
1. Separate each word by the "," sign using .Split and place it inside a string array;
2. Loop through each element using a for loop, and transform each word into a char array;
3. If the size is less than or greater than 4 we use Array.Length to compare the size;
4. We transform the char array into a String again and use Console.WriteLine() to place it in the terminal.
*/
// My Solution
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

string[] orders = orderStream.Split(",");
Array.Sort(orders);

for (int i = 0; i < orders.Length; i++)
{
    char[] letters = orders[i].ToCharArray();
    if (letters.Length != 4)
        {
            string word = new string(letters);
            Console.WriteLine($"{word}\tError");
        }
    else
        Console.WriteLine(letters);
}

Console.WriteLine("");

// Microsoft Learn Solution
string[] items = orderStream.Split(',');
Array.Sort(items);

foreach (var item in items)
{
    if (item.Length == 4)
    {
        Console.WriteLine(item);
    }
    else
    {
        Console.WriteLine(item + "\t- Error");
    }
}