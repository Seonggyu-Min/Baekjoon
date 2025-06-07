public class Program
{
    static void Main(string[] args)
    {
        string[] inputs = Console.ReadLine().Split();

        int a = int.Parse(inputs[0]);
        int b = int.Parse(inputs[1]);
        int c = int.Parse(inputs[2]);
        int d = int.Parse(inputs[3]);
        int e = int.Parse(inputs[4]);
        int f = int.Parse(inputs[5]);

        int denominator = a * e - b * d;

        int x = (c * e - b * f) / denominator;
        int y = (a * f - c * d) / denominator;

        Console.WriteLine($"{x} {y}");
    }
}