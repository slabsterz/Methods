static int NumberOfPower (int number, int power)
{
    int powered = 1;
    for (int i = 0; i < power; i++)
    {
        powered *= number;
    }
    return powered;
}


int baseNumber = int.Parse(Console.ReadLine());
int power = int.Parse(Console.ReadLine());

int poweredNumber = NumberOfPower(baseNumber, power);

Console.WriteLine(poweredNumber);