using System.Text;

class Program
{
    static void Main(string[] args)
    {
        int T = int.Parse(Console.ReadLine());
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < T; i++)
        {
            string[] input = Console.ReadLine().Split();
            int A = int.Parse(input[0]);
            int B = int.Parse(input[1]);
            sb.AppendLine((A + B).ToString());
        }
        Console.Write(sb.ToString());
    }
}