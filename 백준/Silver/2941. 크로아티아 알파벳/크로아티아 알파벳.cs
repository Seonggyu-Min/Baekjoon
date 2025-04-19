public class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] key = { "c=", "c-", "dz=", "d-", "lj", "nj", "s=", "z=" };

        foreach (string item in key)
            input = input.Replace(item, "0");

        Console.WriteLine(input.Length);
    }
}