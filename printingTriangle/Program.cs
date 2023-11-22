static void PrintRows( int end)
{
    
    for (int i = 1; i <= end; i++)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
}

static void PrintColumns (int end)
{
    for (int increaseRows = 1; increaseRows <= end; increaseRows++)
    {
        PrintRows( increaseRows );
    }

    for (int decreaseRows = end; decreaseRows > 0; decreaseRows-- )
    {
        PrintRows(decreaseRows-1);
    }
}

int number = int.Parse(Console.ReadLine());
PrintColumns(number);