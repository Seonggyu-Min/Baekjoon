internal class Program
{
    static void Main(string[] args)
    {
        string s = Console.ReadLine();
        int[] result = new int[26];

        for (int i = 0; i < 26; i++)
            result[i] = -1;

        for (int i = 0; i < s.Length; i++)
        {
            for (int j = 97; j < 123; j++)
            {
                if (s[i] == Convert.ToChar(j))
                {
                    if (result[j - 97] != -1)
                        break;

                    result[j - 97] = i;
                    break;
                }
            }
        }
        Console.WriteLine(string.Join(" ", result));
    }
}