public class Program
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        long sum = 0;

        for (int i = 1; i < num; i++)
        {
            sum += i;
        }

        Console.WriteLine(sum);
        Console.WriteLine(2);
    }
}