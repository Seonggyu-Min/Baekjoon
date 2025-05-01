public class Program
{
    static void Main(string[] args)
    {
        bool[,] paper = new bool[100, 100];

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            int x = int.Parse(input[0]);
            int y = int.Parse(input[1]);

            for (int dx = 0; dx < 10; dx++)
            {
                for (int dy = 0; dy < 10; dy++)
                {
                    paper[x + dx, y + dy] = true;
                }
            }
        }

        int count = 0;
        foreach (bool covered in paper)
        {
            if (covered) count++;
        }

        Console.WriteLine(count);
    }
}