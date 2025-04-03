internal class Program
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());

        string[] s = Console.ReadLine().Split();
        float[] scores = s.Select(float.Parse).ToArray();

        SelectionSort(num, scores);

        float max = scores[num - 1];

        Console.WriteLine(NewAverage(scores, max));
    }

    public static void Swap(float[] array, int a, int b)
    {
        float temp = array[a];
        array[a] = array[b];
        array[b] = temp;
    }

    public static void SelectionSort(int num, float[] scores)
    {
        for (int i = 0; i < num; i++)
        {
            int minIndex = i;
            for (int j = i; j < num; j++)
            {
                if (scores[j] < scores[minIndex])
                    minIndex = j;
            }
            Swap(scores, i, minIndex);
        }
    }

    public static float NewAverage(float[] scores, float max)
    {
        for (int i = 0; i < scores.Length; i++)
        {
            scores[i] = scores[i] / max * 100;
        }

        float sum = 0;
        
        for (int i = 0; i < scores.Length; i++)
        {
            sum += scores[i];
        }

        return sum / scores.Length;
    }
}