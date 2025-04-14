using System.Text;
public class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            int k = int.Parse(input[0]);
            string s = input[1];

            foreach (char c in s)
            {
                for (int j = 0; j < k; j++)
                {
                    sb.Append(c);
                }
            }
            Console.WriteLine(sb);
            sb.Clear();
        }
    }
}