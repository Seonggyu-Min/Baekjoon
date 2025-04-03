using System.Linq;
internal class Program
{
    static void Main(string[] args)
    {
        string[] strInput = Console.ReadLine().Split();
        int[] input = strInput.Select(int.Parse).ToArray();

        int[] basket = new int[input[0]];

        for (int i = 0; i < input[0]; i++)
        {
            basket[i] = i + 1;
        }

        for (int i = 0; i < input[1]; i++)
        {
            string[] s = Console.ReadLine().Split();
            int[] trade = s.Select(int.Parse).ToArray();

            Array.Reverse(basket, trade[0] - 1, trade[1] - trade[0] + 1);
        }

        Console.WriteLine(string.Join(" ", basket));
    }
}