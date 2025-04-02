internal class Program
{
    static void Main(string[] args)
    {
        string[] inputBasketArr = Console.ReadLine().Split();
        int[] numOfBasketArr = inputBasketArr.Select(int.Parse).ToArray();

        // 바구니 수
        int[] numOfBasket = new int[numOfBasketArr[0]];

        for (int i = 0; i < numOfBasketArr[1];  i++)
        {
            // 바구니 넣는 거 배열 초기화
            string[] arrNum = Console.ReadLine().Split();
            int[] intArrNum = arrNum.Select(int.Parse).ToArray();

            int startBask = intArrNum[0] - 1;
            int endBask = intArrNum[1] - 1;
            // 바구니 2 - 바구니 1
            int sub = endBask - startBask;

            for (int j = startBask; j <= endBask; j++)
            {
                numOfBasket[j] = intArrNum[2];
            }
        }

        // null을 0으로
        for (int i = 0; i < numOfBasket.Length;  i++)
        {
            Console.Write($"{numOfBasket[i]} ");
        }
    }
}