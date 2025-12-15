public class Program
{
    static void Main(string[] args)
    {
        string[] fInput = Console.ReadLine().Split();

        int f1 = int.Parse(fInput[0]);
        int f0 = int.Parse(fInput[1]);
        int c = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());


        if ((f1 - c) <= 0 && ((f1 - c) * n + f0) <= 0)
        {
            Console.WriteLine(1);
        }
        else
        {
            Console.WriteLine(0);
        }
    }
}