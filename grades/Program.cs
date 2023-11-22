static void GradeChecker (double grade)
{
    switch (grade)
    {
        case var n when n >= 2 && n < 3:
            Console.WriteLine("Fail"); break;
        case var n when n >= 3 && n < 3.50:
            Console.WriteLine("Average"); break;
        case var n when n >= 3.50 && n < 4.50:
            Console.WriteLine("Good"); break;
        case var n when n >= 4.50 && n < 5.50:
            Console.WriteLine("Very good"); break;
        default: Console.WriteLine("Excellent"); break;
    }
}

double grade = double.Parse(Console.ReadLine());
GradeChecker(grade);