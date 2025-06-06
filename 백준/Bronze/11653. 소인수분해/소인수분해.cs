public class Program
{
    static void Main(string[] args)
    {
        int inputNum = int.Parse(Console.ReadLine());

        if (inputNum == 1)
        {
            return;
        }

        for (int i = 2; i * i <= inputNum; i++)
        {
            while (inputNum % i == 0)
            {
                Console.WriteLine(i);
                inputNum /= i;
            }
        }

        if (inputNum > 1)
        {
            Console.WriteLine(inputNum);
        }
    }
}