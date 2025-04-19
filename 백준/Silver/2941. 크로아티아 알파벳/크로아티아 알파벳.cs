public class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        if (input.Contains("c="))
            input = input.Replace("c=", "0");

        if (input.Contains("c-"))
            input = input.Replace("c-", "0");

        if (input.Contains("dz="))
            input = input.Replace("dz=", "0");

        if (input.Contains("d-"))
            input = input.Replace("d-", "0");

        if (input.Contains("lj"))
            input = input.Replace("lj", "0");

        if (input.Contains("nj"))
            input = input.Replace("nj", "0");

        if (input.Contains("s="))
            input = input.Replace("s=", "0");

        if (input.Contains("z="))
            input = input.Replace("z=", "0");

        Console.WriteLine(input.Length);
    }
}