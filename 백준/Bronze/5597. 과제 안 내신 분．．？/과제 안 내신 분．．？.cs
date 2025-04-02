internal class Program
{
    static void Main(string[] args)
    {
        int[] students = new int[30];

        for (int i = 0; i < students.Length - 2; i++)
        {
            int student = int.Parse(Console.ReadLine());
            students[student - 1] = student;
        }

        int firstStudent = 0;
        int secondStudent = 0;

        for (int i = 0; i < students.Length; i++)
        {
            if (!students.Contains(i + 1))
            {
                firstStudent = i + 1;
                break;
            }
        }

        for (int i = 30; i > 0; i--)
        {
            if (!students.Contains(i))
            {
                secondStudent = i;
                break;
            }
        }
        Console.WriteLine(firstStudent);
        Console.WriteLine(secondStudent);
    }
}