using System;
using System.Collections.Generic;

class Solution {
    public int solution(int[,] maps) {
        int rowCount = maps.GetLength(0);
        int colCount = maps.GetLength(1);

        var visited = new bool[rowCount, colCount];

        // 각 방향 배열
        int[] rowDirections = { -1, 1, 0, 0 };
        int[] colDirections = { 0, 0, -1, 1 };

        var queue = new Queue<(int row, int col, int distance)>();

        // 시작 위치를 큐에 넣기
        queue.Enqueue((0, 0, 1));
        // 시작 위치 방문 처리
        visited[0, 0] = true;

        while (queue.Count > 0)
        {
            var (row, col, distance) = queue.Dequeue();

            // 목적지인지 확인
            if (row == rowCount - 1 && col == colCount - 1)
            {
                return distance;
            }

            for (int i = 0; i < 4; i++)
            {
                int nextRow = row + rowDirections[i];
                int nextCol = col + colDirections[i];

                // 맵 범위 밖이면 continue
                if (nextRow < 0 || rowCount <= nextRow || nextCol < 0 || colCount <= nextCol) continue;

                // 벽이면 continue
                if (maps[nextRow, nextCol] == 0) continue;

                // 이미 방문했다면 continue
                if (visited[nextRow, nextCol]) continue;

                // 방문 처리
                visited[nextRow, nextCol] = true;
                // 큐에 다음 위치와 distance + 1 넣기
                queue.Enqueue((nextRow, nextCol, distance + 1));
            }
        }

        return -1;
    }
}