internal class Program
{
    static void Main(string[] args)
    {
        
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        int b100 = b / 100;
        int b10 = (b / 10) % 10;
        int b1 = b % 100 % 10;

        Console.WriteLine(a * b1);
        Console.WriteLine(a * b10);
        Console.WriteLine(a * b100);
        Console.WriteLine(a * b);
    }
}