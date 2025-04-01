using System.Linq;
internal class Program
{
    static void Main(string[] args)
    {
        string n = Console.ReadLine();
        string[] s = Console.ReadLine().Split(' ');
        int[] i = s.Select(int.Parse).ToArray();

        int min = i.Min();
        int max = i.Max();

        Console.WriteLine($"{min} {max}");
    }
}