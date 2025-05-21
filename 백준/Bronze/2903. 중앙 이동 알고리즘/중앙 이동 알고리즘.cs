    public class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine(Math.Pow((Math.Pow(2, num) + 1), 2));
        }
    }