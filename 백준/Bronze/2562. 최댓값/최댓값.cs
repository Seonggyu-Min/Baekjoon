using System.Linq;
internal class Program
{
    static void Main(string[] args)
    {
        string[] s = new string[9];

        for (int i = 0; i < 9; i++)
        {
            s[i] = Console.ReadLine();
        }
        int[] num = s.Select(int.Parse).ToArray();

        int max = 0;
        int index = 0;

        for (int i = 0; i < 9; i++)
        {
            if (num[i] > max)
            {
                max = num[i];
                index = i;
            }
        }
        Console.WriteLine(max);
        Console.WriteLine(index + 1);
    }
}