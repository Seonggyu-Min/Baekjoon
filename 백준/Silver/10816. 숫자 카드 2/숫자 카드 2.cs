using System.Text;

public class Program
{
    static void Main(string[] args)
    {
        int ownedCardCount = int.Parse(Console.ReadLine());

        Dictionary<int, int> ownedCardDict = new(ownedCardCount);

        string[] ownedCardArr = Console.ReadLine().Split();
        for (int i = 0; i < ownedCardArr.Length; i++)
        {
            int card = int.Parse(ownedCardArr[i]);

            if (ownedCardDict.TryGetValue(card, out int count))
            {
                ownedCardDict[card] = count + 1;
            }
            else
            {
                ownedCardDict[card] = 1;
            }
        }

        int checkCardCount = int.Parse(Console.ReadLine());
        StringBuilder sb = new();

        string[] checkCardArr = Console.ReadLine().Split();
        for (int i = 0; i < checkCardArr.Length; i++)
        {
            int card = int.Parse(checkCardArr[i]);

            if (ownedCardDict.TryGetValue(card, out int count))
                sb.Append(count);
            else
                sb.Append('0');

            if (i < checkCardCount - 1)
                sb.Append(' ');
        }

        Console.Write(sb);
    }
}