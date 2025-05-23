    public class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int layer = 1;
            int maxInLayer = 1;

            while (input > maxInLayer)
            {
                maxInLayer += 6 * layer;
                layer++;
            }

            Console.WriteLine(layer);
        }
    }