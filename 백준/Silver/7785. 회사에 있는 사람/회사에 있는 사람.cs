public class Program
{
    static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());

        HashSet<string> employees = new(count);

        for (int i = 0; i < count; i++)
        {
            string[] log = Console.ReadLine().Split();

            if (log[1] == "enter")
                employees.Add(log[0]);
            else
                employees.Remove(log[0]);
        }

        List<string> result = employees.ToList();
        result.Sort();

        for (int i = result.Count - 1; i >= 0; i--)
            Console.WriteLine(result[i]);
    }
}