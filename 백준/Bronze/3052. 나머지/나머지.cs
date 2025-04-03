using System.Linq;
internal class Program
{
    static void Main(string[] args)
    {
        int[] arr = new int[10];
        for (int i = 0; i < 10; i++)
        {
            int input = int.Parse(Console.ReadLine());
            arr[i] = input % 42;
        }

        Console.WriteLine(arr.Distinct().Count());
    }
}