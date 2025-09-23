using System.Text;
namespace CodingTest001
{
    public class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            HashSet<string> set = new();
            for (int i = 0; i < count; i++)
            {
                set.Add(Console.ReadLine());
            }

            var ordered = set.OrderBy(s => s.Length).ThenBy(s => s);

            StringBuilder sb = new();
            foreach (string s in ordered)
            {
                sb.AppendLine(s);
            }
            Console.WriteLine(sb.ToString());
        }
    }
}