public class Program
{
    static void Main(string[] args)
    {
        string s = Console.ReadLine();
        bool IsPal = true;

        for (int i = 0; i < s.Length / 2; i++)
        {
            if (s[i] != s[s.Length - i - 1])
            {
                IsPal = false;
                break;
            }
        }

        if (IsPal) Console.WriteLine(1);
        else Console.WriteLine(0);
    }
}