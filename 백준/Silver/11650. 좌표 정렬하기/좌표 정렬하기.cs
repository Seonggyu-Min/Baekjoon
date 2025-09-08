using System.Text;
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

        Array.Sort(points);
        var sb = new StringBuilder();
        for (int i = 0; i < n; i++)
        {
            sb.Append(points[i].X).Append(' ').Append(points[i].Y).Append('\n');
        }
        Console.Write(sb.ToString());
    }
}