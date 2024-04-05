namespace triangle;

public class Triangle
{

    public string getType(int a, int b, int c)
    {
        if ((a == b && c != a) || (b == c && a != c) || (a == c && b != a))
        {
            return "Isosceles";
        }
        else if (a != c && c != b && b != a)
        {
            return "Scalene";
        }
        else
        {
            return "Equilateral";
        }

    }
}