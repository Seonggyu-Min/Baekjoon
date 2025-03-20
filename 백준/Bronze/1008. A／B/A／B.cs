internal class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ');

        double A = double.Parse(input[0]);
        double B = double.Parse(input[1]);

        Console.WriteLine(A / B);
    }
}