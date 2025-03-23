class Program
{
    static void Main(string[] args)
    {
        string caseNum = Console.ReadLine();
        int intCaseNum = int.Parse(caseNum);

        for (int i = 0; i < intCaseNum; i++)
        {
            string[] plusNum = Console.ReadLine().Split();
            int num1 = int.Parse(plusNum[0]);
            int num2 = int.Parse(plusNum[1]);

            System.Console.WriteLine($"Case #{i + 1}: {num1} + {num2} = {num1 + num2}");
        }
    }
}