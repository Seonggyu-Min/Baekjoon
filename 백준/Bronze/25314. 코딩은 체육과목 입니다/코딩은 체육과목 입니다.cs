class Program
{
    static void Main(string[] args)
    {
        string nByte = Console.ReadLine();
        int intNByte = int.Parse(nByte);

        for (int i = 0; i < intNByte / 4; i++)
            System.Console.Write("long ");
        System.Console.Write("int");
    }
}