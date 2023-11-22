using System.Diagnostics.Metrics;

static int FindVowelCount (string input)
{
    int counter = 0;
    for (int i = 0; i < input.Length; i++)
    {
        string currentLetter = input[i].ToString();
        
        switch (currentLetter)
        {
            case "a": counter++; break;
            case "e": counter++; break;
            case "i": counter++; break;
            case "o": counter++; break;
            case "u": counter++; break;
        }       
    }
    return counter;
}

string input = Console.ReadLine().ToLower();
Console.WriteLine(FindVowelCount(input));