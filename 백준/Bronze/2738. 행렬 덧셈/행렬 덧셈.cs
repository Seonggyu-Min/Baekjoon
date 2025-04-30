public class Program
{
    static void Main(string[] args)
    {
        string[] s = Console.ReadLine().Split();

        int row = int.Parse(s[0]);
        int column = int.Parse(s[1]);

        int[,] arr = new int[row * 2, column];

        for (int i = 0; i < row * 2; i++)
        {
            string[] sInput = Console.ReadLine().Split();
            
            for (int j = 0; j < column; j++)
            {
                arr[i, j] = int.Parse(sInput[j]);
            }
        }

        int[,] sumArr = new int[row, column];

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                sumArr[i, j] = arr[i, j] + arr[i + row, j];
            }
        }

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                Console.Write($"{sumArr[i, j]} ");
            }

            Console.WriteLine();
        }
    }
}