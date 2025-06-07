public class Program
{
    static void Main(string[] args)
    {
        int x = 0;
        int y = 0;

        for (int i = 0; i < 3; i++)
        {
            string[] inputs = Console.ReadLine().Split();
            x ^= int.Parse(inputs[0]);
            y ^= int.Parse(inputs[1]);
        }

        Console.WriteLine($"{x} {y}");
    }
}