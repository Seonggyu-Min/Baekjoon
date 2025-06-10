public class Program
{
    static void Main(string[] args)
    {
        string[] inputs = Console.ReadLine().Split();
        int row = int.Parse(inputs[0]);
        int col = int.Parse(inputs[1]);

        // 흰색부터 시작하는 보드 선언
        string[] whiteFirst = new string[8];

        string white = "WBWBWBWB";
        string black = "BWBWBWBW";

        for (int i = 0; i < 8; i++)
        {
            if (i % 2 == 0)
            {
                whiteFirst[i] = white;
            }
            else
            {
                whiteFirst[i] = black;
            }
        }

        // 몇 개가 다른지 저장할 변수 선언
        int minDiff = int.MaxValue;

        // row개의 행을 가진 배열을 선언하고
        string[] boards = new string[row];

        // row번 배열에 받기
        for (int i = 0; i < boards.Length; i++)
        {
            boards[i] = Console.ReadLine();
        }

        // 비교를 하되, 행이 8을 초과하면 초과한만큼 반복하여 모든 경우의 수 검사
        for (int i = 0; i <= row - 8; i++)
        {
            // 동일하게 열도 8을 초과하면 초과한만큼 반복
            for (int j = 0; j <= col - 8; j++)
            {

                // 흰색부터 시작하는 보드의 차이 수 저장할 변수 선언
                int diff = 0;

                for (int k = 0; k < 8; k++) // 행
                {
                    for (int l = 0; l < 8; l++) // 열
                    {
                        if (boards[k + i][j + l] != whiteFirst[k][l])
                        {
                            diff++;
                        }
                    }
                }

                // 최솟값 갱신
                if (minDiff > diff)
                {
                    minDiff = diff;
                }

                // 검은색부터 시작하는 보드의 최솟값 갱신
                if (minDiff > 64 - diff)
                {
                    minDiff = 64 - diff;
                }
            }
        }

        Console.WriteLine(minDiff);
    }
}