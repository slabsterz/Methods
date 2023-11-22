static int SumOfEvenDigits (int number)
{
    string numberString = number.ToString();
    int evenSum = 0;

    for (int i = 0; i < numberString.Length; i++)
    {
        int digit = int.Parse(numberString[i].ToString());

        if (digit % 2 == 0)
        {
            evenSum += digit;
        }
    }
    return evenSum;
}

static int SumOfOddDigits(int number)
{
    string numberString = number.ToString();
    int oddSum = 0;

    for (int i = 0; i < numberString.Length; i++)
    {
        int digit = int.Parse(numberString[i].ToString());

        if (digit % 2 != 0)
        {
            oddSum += digit;
        }
    }
    return oddSum;
}

static int MiltiplyEvenAndOdd (int number)
{
    int evenSum = SumOfEvenDigits(number);
    int oddSum = SumOfOddDigits(number);
    int result = evenSum * oddSum; 
    return result;
} 

int number = Math.Abs(int.Parse(Console.ReadLine()));
Console.WriteLine(MiltiplyEvenAndOdd(number));
