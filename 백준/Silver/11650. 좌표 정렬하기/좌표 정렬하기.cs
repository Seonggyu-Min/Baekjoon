public class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        var points = new(int X, int Y)[n];

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            points[i] = (int.Parse(input[0]), int.Parse(input[1]));
        }

        var sorted = points.OrderBy(x => x).ThenBy(y => y);
        foreach (var point in sorted)
        {
            Console.WriteLine($"{point.X} {point.Y}");
        }
    }
}