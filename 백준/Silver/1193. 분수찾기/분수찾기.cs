public class Program
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        int floor = 1;

        while (num > 0)
        {
            num -= floor;

            if (num <= 0)
            {
                break;
            }

            floor++;
        }

        if (floor % 2 == 0)
        {
            Console.WriteLine($"{floor + num}/{1 - num}");
        }
        else
        {
            Console.WriteLine($"{1 - num}/{floor + num}");
        }
    }
}