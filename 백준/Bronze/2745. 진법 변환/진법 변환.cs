public class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();

        string value = input[0];
        int binary = int.Parse(input[1]);

        int result = 0;
        int tmp = 1;

        for (int i = value.Length - 1; i >= 0; i--)
        {
            char c = value[i];

            if (c >= 'A' && c <= 'Z')
            {
                result += (c - 55) * tmp;
            }
            else
            {
                result += (c - 48) * tmp;
            }

            tmp *= binary;
        }

        Console.WriteLine(result);
    }
}