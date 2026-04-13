public class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine()!);
        var stack = new Stack<char>();

        for (int i = 0; i < number; i++)
        {
            bool isVPS = true;
            string input = Console.ReadLine()!;

            foreach (var item in input)
            {
                if (item == '(')
                {
                    stack.Push(item);
                }
                else if (item == ')')
                {
                    if (stack.Count == 0)
                    {
                        isVPS = false;
                        break;
                    }
                    else
                    {
                        stack.Pop();
                    }
                }
            }

            if (isVPS)
            {
                if (stack.Count == 0)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
            else
            {
                Console.WriteLine("NO");
            }

            stack.Clear();
        }
    }
}