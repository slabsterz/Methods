internal class Program
{
    private static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        


        for (int i = 1; i <= number; i++)
        {
            int digit1 = 0;
            int digit2 = 0;
            int digit3 = 0;

            string numberString = number.ToString();
          
            for (int j = 0; j < numberString.Length; j++)
            {
                int digit = int.Parse(numberString[j].ToString());

                switch (digit)
                {
                    case 1: digit1 += digit; break;
                    case 2: digit2 += digit; break;
                    case 3: digit3 += digit; break;
                }
            }
            if (digit1 * digit2 * digit3 == number)
            {
                Console.Write($"{digit1}{digit2}{digit3} ");
            }

        }
    }
}