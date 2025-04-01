using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        string[] s = Console.ReadLine().Split(' ');
        string[] v = Console.ReadLine().Split(' ');

        int[] a = s.Select(int.Parse).ToArray();
        int[] b = v.Select(int.Parse).ToArray();

        Queue<int> q = new Queue<int>();

        int count = 0;

        for (int i = 0; i < b.Length; i++)
        {
            if (a[1] > b[i])
            {
                q.Enqueue(b[i]);
                count++;
            }

        }
        for (int i = 0; i < count; i++)
        {
            Console.Write($"{q.Dequeue()} ");
        }
    }
}