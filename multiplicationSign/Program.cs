static void FindNegativeState(int first, int second, int third, ref string state)
{
    int negativeCounter = 0;
    if (first < 0)
    {
        negativeCounter++;
    }
    else if (second < 0)
    {
        negativeCounter++;
    }
    else if (third < 0)
    {
        negativeCounter++;
    }

    if (negativeCounter != 2)
    {
        state = "negative";
    }
}

static void FindZeroState(int first, int second, int third, ref string state)
{
    if (first == 0 || second == 0 || third == 0)
    {
        state = "zero";
    }  
}

static void FindPositiveState(int first, int second, int third, ref string state)
{
    if (first > 0 && second > 0 && third > 0)
    {
        state = "positive";
    }  
        
}

int first = int.Parse(Console.ReadLine());
int second = int.Parse(Console.ReadLine());
int third = int.Parse(Console.ReadLine());

string state = "";


FindNegativeState(first, second, third, ref state);
FindPositiveState(first, second, third, ref state);
FindZeroState(first, second, third, ref state);


Console.WriteLine(state);




