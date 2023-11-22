static string CompareStrings (string a, string b)
{
    int result = string.Compare(a, b);

    if (result > 0)
    {
        return a;
    }
    else
    {
        return b;
    }
}

static char CompareChars (char a, char b)
{
    if (a > b)
    {
        return a;
    }
    else
    {
        return b;
    }
}

static int CompareInt (int a, int b)
{
    if (a > b)
    {
        return a;
    }
    else
    {
        return b;
    }
}


string type = Console.ReadLine();
if (type == "string")
{
    string firstString = Console.ReadLine();
    string secondString = Console.ReadLine();
    string result = CompareStrings(firstString, secondString);
    Console.WriteLine(result);
}
else if (type == "int")
{
    int firstNumber = int.Parse(Console.ReadLine());
    int secondNumber = int.Parse(Console.ReadLine());
    int result = CompareInt(firstNumber, secondNumber);
    Console.WriteLine(result);
}
else if (type == "char")
{
    char firstChar = char.Parse(Console.ReadLine());
    char secondChar = char.Parse(Console.ReadLine());
    char result = CompareChars(firstChar, secondChar);
    Console.WriteLine(result);
}

