using System.Numerics;

public class Program
{
    static void Main(string[] args)
    {
        HashSet<Vector2> set = new HashSet<Vector2>();

        int num = int.Parse(Console.ReadLine());

        for (int i = 0; i < num; i++)
        {
            string input = Console.ReadLine();
            string[] dist = input.Split();

            int leftDist = int.Parse(dist[0]);
            int downDist = int.Parse(dist[1]);

            for (int j = leftDist; j < leftDist + 10; j++)
            {
                for (int k = downDist; k < downDist + 10; k++)
                {
                    Vector2 vector2 = new Vector2();
                    vector2.X = j;
                    vector2.Y = k;
                    set.Add(vector2);
                }
            }
        }

        int count = 0;

        foreach (Vector2 vector in set)
        {
            set.Remove(vector);
            count++;
        }

        Console.WriteLine(count);
    }
}