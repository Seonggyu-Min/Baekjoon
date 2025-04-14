public class Program
{
    static void Main(string[] args)
    {
        string s = Console.ReadLine().Trim();
        int count = 0;

        if (s == "")
        {
            Console.WriteLine(0);
            return;
        }

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == ' ')
            {
                count++;
            }
        }

        Console.WriteLine(count + 1);
    }
}