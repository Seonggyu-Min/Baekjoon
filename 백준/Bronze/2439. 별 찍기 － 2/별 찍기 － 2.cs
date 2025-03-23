class Program
{
    static void Main(string[] args)
    {
        string num = Console.ReadLine();
        int intNum = int.Parse(num);

        for (int i = 0; i < intNum; i++)
        {
            for (int j = 1; j < intNum - i; j++)
            {
                System.Console.Write(' ');
            }
            for (int k = 0; k <= i; k++)
            {
                System.Console.Write('*');
            }
            System.Console.WriteLine();
        }
    }
}