class Program
{
    static void Main(string[] args)
    {
        string num = Console.ReadLine();
        int intNum = int.Parse(num);

        for (int i = 0; i < intNum; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                System.Console.Write('*');
            }
            System.Console.WriteLine();
        }
    }
}