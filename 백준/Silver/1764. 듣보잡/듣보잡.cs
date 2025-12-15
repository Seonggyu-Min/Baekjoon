using System.Text;

public class Program
{
    static void Main(string[] args)
    {
        string[] inputs = Console.ReadLine().Split();

        int notHeardCount = int.Parse(inputs[0]);
        HashSet<string> notHeard = new(notHeardCount);
        for (int i = 0; i < notHeardCount; i++)
            notHeard.Add(Console.ReadLine());

        List<string> notHeardSeen = new();
        int notSeenCount = int.Parse(inputs[1]);
        for (int i = 0; i < notSeenCount; i++)
        {
            string input = Console.ReadLine();
            if (notHeard.Contains(input))
                notHeardSeen.Add(input);
        }

        notHeardSeen.Sort();

        Console.WriteLine(notHeardSeen.Count);

        StringBuilder sb = new();
        foreach (var person in notHeardSeen)
        {
            sb.AppendLine(person);
        }
        Console.Write(sb);
    }
}