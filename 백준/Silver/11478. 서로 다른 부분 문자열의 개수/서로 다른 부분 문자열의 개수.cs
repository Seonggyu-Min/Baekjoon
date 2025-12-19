public class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        HashSet<string> Set = new();

        int start;
        for (int elementLength = 1; elementLength <= input.Length; elementLength++)
        {
            start = 0;
            while (start + elementLength <= input.Length)
            {
                Set.Add(input.Substring(start, elementLength));
                start++;
            }
        }

        Console.WriteLine(Set.Count);
    }
}