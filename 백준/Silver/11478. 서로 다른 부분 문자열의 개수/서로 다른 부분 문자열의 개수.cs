public class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        HashSet<string> Set = new();

        int count = 0;
        for (int elementLength = 1; elementLength <= input.Length; elementLength++)
        {
            Set.Clear();

            for (int index = 0; index + elementLength <= input.Length; index++)
            {
                Set.Add(input.Substring(index, elementLength));
            }

            count += Set.Count;
        }

        Console.WriteLine(count);
    }
}