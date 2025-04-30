public class Program
{
    static void Main(string[] args)
    {
        int[,] arr = new int[9, 9];

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            string[] s = Console.ReadLine().Split();

            for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[i, j] = int.Parse(s[j]);
            }
        }

        int max = int.MinValue;
        int row = 0;
        int column = 0;

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (arr[i, j] > max)
                {
                    max = arr[i, j];

                    row = i;
                    column = j;
                }
            }
        }

        Console.WriteLine(max);
        Console.WriteLine($"{row + 1} {column + 1}");
    }
}