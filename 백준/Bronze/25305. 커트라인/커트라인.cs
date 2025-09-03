public class Program
{
    static void Main(string[] args)
    {
        string[] line1 = Console.ReadLine().Split();

        int all = int.Parse(line1[0]);
        int winnerCount = int.Parse(line1[1]);

        string[] line2 = Console.ReadLine().Split();
        List<int> list = new();
        for (int i = 0; i < all; i++)
        {
            int score = int.Parse(line2[i]);
            list.Add(score);
        }

        for (int i = 0; i < list.Count - 1; i++)
        {
            for (int j = 0; j < list.Count - i - 1; j++)
            {
                if (list[j] < list[j + 1])
                {
                    int temp = list[j];
                    list[j] = list[j + 1];
                    list[j + 1] = temp;
                }
            }
        }

        Console.WriteLine(list[winnerCount - 1]);
    }
}