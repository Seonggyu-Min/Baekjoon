public class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            string[] inputs = Console.ReadLine().Split();

            int a = int.Parse(inputs[0]);
            int b = int.Parse(inputs[1]);
            int c = int.Parse(inputs[2]);

            if (a == 0 && b == 0 && c == 0)
            {
                break;
            }

            if (!(a + b > c && a + c > b && b + c > a))
            {
                Console.WriteLine("Invalid");
            }
            else if (a == b && b == c)
            {
                Console.WriteLine("Equilateral");
            }
            else if (a == b || b == c || a == c)
            {
                Console.WriteLine("Isosceles");
            }
            else
            {
                Console.WriteLine("Scalene");
            }
        }
    }
}