public class Program
{
    static void Main(string[] args)
    {
        string[] counts = Console.ReadLine().Split();
        int setNCount = int.Parse(counts[0]);
        int setMCount = int.Parse(counts[1]);

        HashSet<string> setN = new(setNCount);

        for (int i = 0; i < setNCount; i++)
            setN.Add(Console.ReadLine());

        int count = 0;
        
        for (int i = 0; i < setMCount; i++)
            if (setN.Contains(Console.ReadLine())) count++;

        Console.WriteLine(count);
    }
}