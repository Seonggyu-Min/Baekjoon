internal class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        int[] infor = input.Select(int.Parse).ToArray();

        // 바구니
        int[] bask = new int[infor[0]];
        for (int i = 0; i < infor[0]; i++)
        {
            bask[i] = i + 1;
        }

        // 바구니 안의 공 교체
        for (int i = 0; i < infor[1]; i++)
        {
            string[] strChange = Console.ReadLine().Split();
            int[] chg = strChange.Select(int.Parse).ToArray();

            int temp = bask[chg[0] - 1];
            bask[chg[0] - 1] = bask[chg[1] - 1];
            bask[chg[1] - 1] = temp;
        }

        Console.WriteLine(string.Join(" ", bask));
    }
}