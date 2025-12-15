public class Program
{
    static void Main(string[] args)
    {
        string[] inputs = Console.ReadLine().Split();

        int setACount = int.Parse(inputs[0]);
        int setBCount = int.Parse(inputs[1]);

        HashSet<int> setA = new(setACount);
        HashSet<int> setB = new(setBCount);

        string[] setAInput = Console.ReadLine().Split();
        string[] setBInput = Console.ReadLine().Split();

        for (int i = 0; i < setAInput.Length; i++)
            setA.Add(int.Parse(setAInput[i]));

        for (int i = 0; i < setBInput.Length; i++)
            setB.Add(int.Parse(setBInput[i]));

        int count = 0;
        foreach (int i in setA)
        {
            if (!setB.Contains(i))
                count++;
        }

        foreach (int i in setB)
        {
            if (!setA.Contains(i))
                count++;
        }

        Console.WriteLine(count);
    }
}