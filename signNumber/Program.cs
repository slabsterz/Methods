using System.Diagnostics;
static void CheckNumberSign(int number)
{
    switch (number)
    {
        case var n when n < 0:
            Console.WriteLine($"The number {number} is negative."); break;
        case var n when n == 0:
            Console.WriteLine($"The number {number} is zero."); break;
        default: Console.WriteLine($"The number {number} is positive."); break;
    }
}

int number = int.Parse(Console.ReadLine());
CheckNumberSign(number);




