public class Program
{
    static void Main(string[] args)
    {
        int caseNum = int.Parse(Console.ReadLine());

        int minX = int.MaxValue;
        int minY = int.MaxValue;
        int maxX = int.MinValue;
        int maxY = int.MinValue;

        for (int i = 0; i < caseNum; i++)
        {
            string[] inputs = Console.ReadLine().Split();

            int x = int.Parse(inputs[0]);
            int y = int.Parse(inputs[1]);

            if (x < minX) minX = x;
            if (y < minY) minY = y;
            if (x > maxX) maxX = x;
            if (y > maxY) maxY = y;
        }

        int area = (maxX - minX) * (maxY - minY);
        Console.WriteLine(area);
    }
}