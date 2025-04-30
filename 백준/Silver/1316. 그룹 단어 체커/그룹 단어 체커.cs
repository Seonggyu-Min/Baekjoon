public class Program
{
    static void Main(string[] args)
    {
        HashSet<char> set = new HashSet<char>();
        int count = 0;
        char prev = '0';
        int inputNum = int.Parse(Console.ReadLine());

        for (int i = 0; i < inputNum; i++)
        {
            char[] c = Console.ReadLine().ToCharArray();

            foreach (char letter in c)
            {
                if (!set.Contains(letter))
                {
                    set.Add(letter);
                    prev = letter;
                }

                else if (set.Contains(letter) && prev == letter)
                    continue;

                else if (set.Contains(letter))
                {
                    count--;
                    break;
                }
            }

            count++;
            prev = '0';
            set.Clear();
        }

        Console.WriteLine(count);
    }
}