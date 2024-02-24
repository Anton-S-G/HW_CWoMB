Console.Write("Введите строку из слов разделённых пробелом: ");
string textInput = Console.ReadLine()!;
while (textInput.Length == 0)
{
    Console.Write("Вы не ввели ни одного знака, введите не пустую строку: ");
    textInput = Console.ReadLine()!;
}
string[] word = textInput.Split(' ');
string textOut = string.Empty;
for (int i = 0; i < word.Length; i++)
{
    if (word[i].Length <= 3 && i < word.Length)
    {
        if (word[i] != "")
        {
            textOut += word[i] + " ";
        }
    }
}
string[] outText = textOut.Split(' ');
string[] finText = new string[outText.Length - 1];
for (int j = 0; j < outText.Length - 1; j++)
{
    if ((outText[j + 1] == "" || outText[j + 1] == " ") && j == outText.Length - 1)
    {
        continue;
    }
    finText[j] = outText[j];
}
Console.WriteLine($"Новая строка: [{string.Join(" ", finText)}]");
