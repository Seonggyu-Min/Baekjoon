using System.Text;

public class Program
{
    static void Main(string[] args)
    {
        int ownedCardCount = int.Parse(Console.ReadLine());

        HashSet<int> ownedCardsSet = new();

        string[] ownedCards = Console.ReadLine().Split();
        for (int i = 0; i < ownedCardCount; i++)
        {
            ownedCardsSet.Add(int.Parse(ownedCards[i]));
        }


        int checkCardCount = int.Parse(Console.ReadLine());
        string[] checkCards = Console.ReadLine().Split();
        StringBuilder sb = new();

        for (int i = 0; i < checkCardCount; i++)
        {
            if (ownedCardsSet.Contains(int.Parse(checkCards[i])))
            {
                sb.Append("1 ");
            }
            else
            {
                sb.Append("0 ");
            }
        }

        Console.WriteLine(sb.ToString().Trim());
    }
}