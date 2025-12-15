using System.Text;

public class Program
{
    static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());

        HashSet<string> employees = new(count);

        for (int i = 0; i < count; i++)
        {
            string line = Console.ReadLine();
            int index = line.IndexOf(' ');

            string name = line.Substring(0, index);
            string action = line.Substring(index + 1);

            if (action == "enter")
                employees.Add(name);
            else
                employees.Remove(name);
        }

        List<string> result = employees.ToList();
        result.Sort();
        StringBuilder sb = new();

        for (int i = result.Count - 1; i >= 0; i--)
            sb.AppendLine(result[i]);

        Console.WriteLine(sb.ToString());
    }
}