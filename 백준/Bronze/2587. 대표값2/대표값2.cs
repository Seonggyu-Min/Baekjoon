public class Program
{
    static void Main(string[] args)
    {
        List<int> list = new();
        for (int i = 0; i < 5; i++)
        {
            int num = int.Parse(Console.ReadLine());
            list.Add(num);
        }

        int average = list.Sum() / 5;
        list.Sort();

        Console.WriteLine(average); // 평균
        Console.WriteLine(list[2]); // 중앙
    }
}