static string RepeatString (string text , int repeat)
{
    string result = "";
    for (int i = 0; i < repeat; i++)
    {
        result += text;
    }
    return result;
} 


string input = Console.ReadLine();
int count = int.Parse(Console.ReadLine());
Console.WriteLine(RepeatString(input, count));