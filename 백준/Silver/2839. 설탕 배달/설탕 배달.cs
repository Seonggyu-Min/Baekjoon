public class Program
{
    static void Main(string[] args)
    {
        int input = int.Parse(Console.ReadLine());
        int answer = 0;

        for (int i = input / 5; i >= 0; i--)
        {
            int rest = input - 5 * i;
            if (rest % 3 == 0)
            {
                answer = i + rest / 3;
                break;
            }
        }

        Console.WriteLine(answer == 0 ? -1 : answer);
    }
}