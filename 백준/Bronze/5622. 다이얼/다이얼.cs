public class Program
{
    static void Main(string[] args)
    {
        int count = 0;

        string s = Console.ReadLine();

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] >= 'A' && s[i] <= 'C')
            {
                count += 3;
            }
            else if (s[i] >= 'D' && s[i] <= 'F')
            {
                count += 4;
            }
            else if (s[i] >= 'G' && s[i] <= 'I')
            {
                count += 5;
            }
            else if (s[i] >= 'J' && s[i] <= 'L')
            {
                count += 6;
            }
            else if (s[i] >= 'M' && s[i] <= 'O')
            {
                count += 7;
            }
            else if (s[i] >= 'P' && s[i] <= 'S')
            {
                count += 8;
            }
            else if (s[i] >= 'T' && s[i] <= 'V')
            {
                count += 9;
            }
            else if (s[i] >= 'W' && s[i] <= 'Z')
            {
                count += 10;
            }
        }

        Console.WriteLine(count);
    }
}