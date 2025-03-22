class Program
{
    static void Main(string[] args)
    {
        string num = Console.ReadLine();
        int intNum = int.Parse(num);
        int sum = 0;

        for (int i = 1; i <= intNum; i++)
            sum += i;
        System.Console.WriteLine(sum);

    } 
}