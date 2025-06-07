public class Program
{
    static void Main(string[] args)
    {
        string[] inputs = Console.ReadLine().Split();

        int a = int.Parse(inputs[0]);
        int b = int.Parse(inputs[1]);
        int c = int.Parse(inputs[2]);

        int[] angles = { a, b, c };

        Array.Sort(angles);
        int max = angles[2];
        int sum = angles[0] + angles[1];

        if (max >= sum)
        {
            angles[2] = sum - 1;
        }

        Console.WriteLine(angles.Sum());
    }
}