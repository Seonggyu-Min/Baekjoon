public class Program
{
    static void Main(string[] args)
    {
        char[][] text = new char[5][];
        List<char> list = new List<char>();

        for (int i = 0; i < 5; i++)
        {
            char[] c = Console.ReadLine().ToCharArray();
            text[i] = new char[c.Length];
            
            for (int j = 0; j < c.Length; j++)
            {
                text[i][j] = c[j];
            }
        }
        
        for (int i = 0; i < 15; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (i < text[j].Length)
                    list.Add(text[j][i]);
            }
        }

        foreach (var word in list)
        {
            Console.Write(word);
        }
    }
}