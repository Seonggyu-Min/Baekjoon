using System;

public class Example
{
    public static void Main()
    {
        var input = Console.ReadLine().Split(' ');
        var y = int.Parse(input[0]);
        var x = int.Parse(input[1]);

        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                Console.Write('*');
            }

            Console.WriteLine();
        }
    }
}