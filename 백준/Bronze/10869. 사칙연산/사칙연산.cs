internal class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] splitInput = input.Split(' ');

        int intNum1 = int.Parse(splitInput[0]);
        int intNum2 = int.Parse(splitInput[1]);

        Console.WriteLine(intNum1 + intNum2);
        Console.WriteLine(intNum1 - intNum2);
        Console.WriteLine(intNum1 * intNum2);
        Console.WriteLine(intNum1 / intNum2);
        Console.WriteLine(intNum1 % intNum2);

    }
}