class Program
{
    static void Main(string[] args)
    {
        string caseNum = Console.ReadLine();
        int intCaseNum = int.Parse(caseNum);

        for (int i = 0; i < intCaseNum; i++)
        {
            string num = Console.ReadLine();
            string[] s = num.Split(' ');
            int num1 = int.Parse(s[0]);
            int num2 = int.Parse(s[1]);

            System.Console.WriteLine(num1 + num2);
        }
    } 
}