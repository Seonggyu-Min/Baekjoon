public class Program
{
    static void Main(string[] args)
    {
        var stack = new Stack<int>();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int input = int.Parse(Console.ReadLine());

            if (input == 0)
            {
                stack.Pop();
            }
            else
            {
                stack.Push(input);
            }
        }

        Console.WriteLine(stack.Sum());
    }
}