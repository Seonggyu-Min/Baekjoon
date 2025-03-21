class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] sInput = input.Split(' ');
        int num1 = int.Parse(sInput[0]);
        int num2 = int.Parse(sInput[1]);


        if (num1 > num2)
        System.Console.WriteLine('>');
        else if (num1 < num2)
        System.Console.WriteLine('<');
        else if (num1 == num2)
        System.Console.WriteLine("==");
    }
}
