static double CalculateTotalPrice(string product, int quantity)
{
    double total;
    
    switch (product) 
    {
        case "coffee": total = quantity * 1.5; break;
        case "water": total = quantity * 1; break;
        case "coke": total = quantity * 1.4; break;
        default: total = quantity * 2; break;
    }

    return total;
}

string product = Console.ReadLine();
int quantity = int.Parse(Console.ReadLine());
double total = CalculateTotalPrice(product, quantity);

Console.WriteLine($"{total:f2}");
