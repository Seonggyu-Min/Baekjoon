using System;

public class Solution {
    public int[] solution(int[,] arr) {
        // 1 <= arr.GetLength(0) == arr.GetLength(1) <= 1024
        // 각 length는 2의 거듭제곱
        // n <= 1,048,576
        // O(n) 고려

        var result = new int[2];

        DFS(0, 0, arr.GetLength(0));

        return result;


        void DFS(int row, int col, int size)
        {
            // 현재 영역이 전부 같은지 검사
            int checkSame = arr[row, col];
            for (int i = row; i < row + size; i++)
            {
                for (int j = col; j < col + size; j++)
                {
                    // 다르면 압축 재시도
                    // 행과 열이 같고 2의 거듭제곱이라 항상 2로 나눠짐
                    if (arr[i, j] != checkSame)
                    {
                        var half = size / 2;

                        DFS(row, col, half);
                        DFS(row + half, col, half);
                        DFS(row, col + half, half);
                        DFS(row + half, col + half, half);

                        return;
                    }
                }
            }

            // 압축이 되었거나 하나의 셀이라면 0이나 1 ++
            result[checkSame]++;
        }
    }
}