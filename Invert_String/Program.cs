/*
PT
1. Crio um array com cada palavra separada chamado "words"
2. Percorro cada palavra e a transformo em um array do tipo char 
3. Inverto o Array do tipo char e converto novamente para uma string
4. E por fim faço um Join para juntar todas as palavras em uma frase e apresento no terminal

EN
1. I Create an array with each word separated called "words"
2. I go through each word and transform it into an array of type char
3. I invert the char Array and convert it back to a string
4. And finally I do a Join to all the words into a sentence and present it in the terminal
*/
// My Solution
string pangram = "The quick brown fox jumps over the lazy dog";

string[] words = pangram.Split(' ');

for (int i = 0; i < words.Length; i++)
{

    char[] word = words[i].ToCharArray();
    Array.Reverse(word);
    words[i] = new string(word);
}

string invertedWords = String.Join(" ", words);
Console.WriteLine(invertedWords);

// Microsoft Learn Solution
// Step 1 
string[] message = pangram.Split(' ');

// Step 2
string[] newMessage = new string[message.Length];

// Step 3
for (int i = 0; i < message.Length; i++)
{
    char[] letters = message[i].ToCharArray();
    Array.Reverse(letters);
    newMessage[i] = new string(letters);
}

// Step 4
string result = String.Join(" ", newMessage);
Console.WriteLine(result);