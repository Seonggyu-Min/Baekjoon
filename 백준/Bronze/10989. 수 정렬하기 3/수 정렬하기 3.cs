public class Program
{
    static void Main(string[] args)
    {
        using var sr = new StreamReader(Console.OpenStandardInput());
        using var sw = new StreamWriter(Console.OpenStandardOutput());

        int n = int.Parse(sr.ReadLine());

        int[] count = new int[10001];

        for (int i = 0; i < n; i++)
        {
            int x = int.Parse(sr.ReadLine());
            count[x]++;
        }

        for (int v = 1; v <= 10000; v++) 
        {
            int c = count[v];
            while (c-- > 0)
            {
                sw.WriteLine(v);
            }
        }
    }
}