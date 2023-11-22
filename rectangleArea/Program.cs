static int RectangleArea (int sideA, int sideB)
{
    int area = 0;
    area = sideA * sideB;
    return area;
}


int width = int.Parse(Console.ReadLine());
int lenght = int.Parse(Console.ReadLine());
Console.WriteLine(RectangleArea(width, lenght));
