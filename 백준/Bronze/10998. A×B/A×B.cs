internal class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] splitInput = input.Split(' ');

        string num1 = splitInput[0];
        string num2 = splitInput[1];

        int intNum1 = int.Parse(num1);
        int intNum2 = int.Parse(num2);

        Console.WriteLine(intNum1 * intNum2); 
    }
}