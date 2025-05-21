public class Program
{
    static void Main(string[] args)
    {
        int testCase = int.Parse(Console.ReadLine());

        for (int i = 0; i < testCase; i++)
        {
            int money = int.Parse(Console.ReadLine());

            int quater = money / 25;
            money %= 25;

            int dime = money / 10;
            money %= 10;

            int nickel = money / 5;
            money %= 5;

            int penny = money / 1;
            money %= 1;

            Console.WriteLine($"{quater} {dime} {nickel} {penny}");
        }
    }
}