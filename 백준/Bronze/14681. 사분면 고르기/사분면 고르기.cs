class Program
{
    static void Main(string[] args)
    {
        string input1 = Console.ReadLine();
        string input2 = Console.ReadLine();

        int num1 = int.Parse(input1);
        int num2 = int.Parse(input2);

        if (num1 > 0){
            if (num2 > 0)
            System.Console.WriteLine('1');
            else if(num2 < 0)
            System.Console.WriteLine('4');
        }
        else if (num1 < 0){
            if (num2 > 0)
            System.Console.WriteLine('2');
            else if(num2 < 0)
            System.Console.WriteLine('3');
        }
    }
}