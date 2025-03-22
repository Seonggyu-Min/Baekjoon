internal class Program
{
    static void Main(string[] args)
    {
        string inputTotalPrice = Console.ReadLine();
        int totalPrice = int.Parse(inputTotalPrice);

        string inputTotalQntt = Console.ReadLine();
        int totalQntt = int.Parse(inputTotalQntt);

        int sum = 0;

        for (int i = 0; i < totalQntt; i++)
        {
            string inputEachPrice = Console.ReadLine();
            string[] sEachPrice = inputEachPrice.Split(' ');
            int intEachPrice = int.Parse(sEachPrice[0]);
            int intEachQntt = int.Parse(sEachPrice[1]);

            sum += intEachPrice * intEachQntt;
        }

        if (sum == totalPrice)
            System.Console.WriteLine("Yes");
        else
            System.Console.WriteLine("No");
    }
}