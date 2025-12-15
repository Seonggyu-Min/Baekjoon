using System.Text;

public class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();

        int n = int.Parse(input[0]);

        Dictionary<string, int> stringKey = new(n);
        Dictionary<int, string> intKey = new(n);

        for (int i = 1; i <= n; i++)
        {
            string key = Console.ReadLine();

            stringKey.Add(key, i);
            intKey.Add(i, key);
        }

        int m = int.Parse(input[1]);

        StringBuilder sb = new();

        for (int i = 0; i < m; i++)
        {
            string question = Console.ReadLine();

            if (int.TryParse(question, out int value))
            {
                if (intKey.TryGetValue(value, out string answerString))
                {
                    sb.AppendLine(answerString);
                }
            }
            else
            {
                if (stringKey.TryGetValue(question, out int answerInt))
                {
                    sb.AppendLine(answerInt.ToString());
                }
            }
        }

        Console.Write(sb);
    }
}