public class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, float> Grade = new Dictionary<string, float>();

        Grade.Add("A+", 4.5f);
        Grade.Add("A0", 4.0f);
        Grade.Add("B+", 3.5f);
        Grade.Add("B0", 3.0f);
        Grade.Add("C+", 2.5f);
        Grade.Add("C0", 2.0f);
        Grade.Add("D+", 1.5f);
        Grade.Add("D0", 1.0f);
        Grade.Add("F", 0.0f);

        float sum = 0f;
        float totalCredit = 0f;

        for (int i = 0; i < 20; i++)
        {
            string[] input = Console.ReadLine().Split().ToArray();

            if (!Grade.TryGetValue(input[2], out float gradePoint))
                continue;

            float credit = float.Parse(input[1]);

            sum += gradePoint * credit;
            totalCredit += credit;
        }

        Console.WriteLine(sum / totalCredit);
    }
}