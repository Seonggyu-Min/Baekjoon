using System.Text;

public class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string[] coords = Console.ReadLine().Split();
        
        int[] arr = new int[n];
        int[] sorted = new int[n];

        for (int i = 0; i < n; i++)
        {
            int parsed = int.Parse(coords[i]);
            arr[i] = parsed;
            sorted[i] = parsed;
        }

        Array.Sort(sorted);

        Dictionary<int, int> rank = new(n);
        int r = 0;

        for (int i = 0; i < n; i++)
        {
            int v = sorted[i];
            if (!rank.ContainsKey(v))
            {
                rank[v] = r++;
            }
        }

        StringBuilder sb = new();
        for (int i = 0; i < n; i++)
        {
            sb.Append(rank[arr[i]]);
            if (i + 1 < n) sb.Append(' ');
        }
        Console.WriteLine(sb.ToString());
    }
}