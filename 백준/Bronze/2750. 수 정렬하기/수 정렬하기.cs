using System.Text;
public class Program
{
    static void Main(string[] args)
    {
        // 입력
        using var sr = new StreamReader(Console.OpenStandardInput());
        int quantity = int.Parse(sr.ReadLine());

        List<int> list = new();
        for (int i = 0; i < quantity; i++)
        {
            int num = int.Parse(sr.ReadLine());
            list.Add(num);
        }

        // 정렬
        int n = list.Count;
        for (int i = 0; i < n; i++)
        {
            int key = list[i];
            int j = i - 1;

            while (j >= 0 && list[j] > key)
            {
                list[j + 1] = list[j];
                j--;
            }

            list[j + 1] = key;
        }

        // 출력
        StringBuilder sb = new();
        foreach (var item in list)
        {
            sb.AppendLine(item.ToString());
        }
        Console.Write(sb.ToString());
    }
}