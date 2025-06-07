public class Program
{
    static void Main(string[] args)
    {
        string[] inputs = Console.ReadLine().Split();

        int x = int.Parse(inputs[0]);
        int y = int.Parse(inputs[1]);
        int w = int.Parse(inputs[2]);
        int h = int.Parse(inputs[3]);

        int minDist = int.MaxValue;

        if (minDist > x) minDist = x;
        if (minDist > y) minDist = y;
        if (minDist > w - x) minDist = w - x;
        if (minDist > h - y) minDist = h - y;

        Console.WriteLine(minDist);
    }
}