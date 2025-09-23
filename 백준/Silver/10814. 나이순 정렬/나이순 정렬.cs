using System.Text;
namespace CodingTest001
{
    public class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            List<(int age, string name)> list = new();
            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split();
                int age = int.Parse(input[0]);
                string name = input[1];

                list.Add((age, name));
            }

            var ordered = list.OrderBy(a => a.age);

            StringBuilder sb = new();
            foreach (var s in ordered)
            {
                sb.AppendLine($"{s.age} {s.name}");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}