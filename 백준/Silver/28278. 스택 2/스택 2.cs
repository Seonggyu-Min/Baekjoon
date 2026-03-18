using System.Text;

public class Program
{
    static void Main(string[] args)
    {
        Stack<int> stack = new Stack<int>();
        int n = int.Parse(Console.ReadLine());
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();

            int command = int.Parse(input[0]);

            if (command == 1)
            {
                int x = int.Parse(input[1]);
                stack.Push(x);
            }
            else if (command == 2)
            {
                if (stack.Count == 0)
                {
                    sb.AppendLine("-1");
                }
                else
                {
                    sb.AppendLine(stack.Pop().ToString());
                }
            }
            else if (command == 3)
            {
                sb.AppendLine(stack.Count.ToString());
            }
            else if (command == 4)
            {
                sb.AppendLine(stack.Count == 0 ? "1" : "0");
            }
            else if (command == 5)
            {
                if (stack.Count == 0)
                {
                    sb.AppendLine("-1");
                }
                else
                {
                    sb.AppendLine(stack.Peek().ToString());
                }
            }
        }

        Console.Write(sb.ToString());
    }
}