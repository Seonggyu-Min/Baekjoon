public class Program
{
    static void Main(string[] args)
    {
        string[] inputs = Console.ReadLine().Split();
        int cardsQuantity = int.Parse(inputs[0]);
        int dealerNum = int.Parse(inputs[1]);

        int[] cards = new int[cardsQuantity];
        string[] cardsString = Console.ReadLine().Split();

        for (int i = 0; i < cardsQuantity; i++)
        {
            cards[i] = int.Parse(cardsString[i]);
        }

        int sum = 0;

        for (int i = 0; i < cardsQuantity - 2; i++)
        {
            for (int j = i + 1; j < cardsQuantity - 1; j++)
            {
                for (int k = j + 1; k < cardsQuantity; k++)
                {
                    int tempSum = cards[i] + cards[j] + cards[k];
                    if (tempSum <= dealerNum && tempSum > sum)
                    {
                        sum = tempSum;
                    }
                }
            }
        }

        Console.WriteLine(sum);
    }
}