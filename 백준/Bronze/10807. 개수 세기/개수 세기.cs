internal class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        string s = Console.ReadLine();

        int v = int.Parse(Console.ReadLine());

        int result = 0;

        string[] sArr = s.Split(' ');

        int[] iArr = new int[n];

        for (int i = 0; i < n; i++)
        {
            iArr[i] = Convert.ToInt32(sArr[i]);
        }

        for (int i = 0; i < n; i++)
        {
            if (iArr[i] == v)
            {
                result++;
            }
        }

        Console.WriteLine(result);
    }
}