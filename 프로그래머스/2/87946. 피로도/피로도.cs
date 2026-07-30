using System;

public class Solution {
    private static int[,] _dungeons;
    private static bool[] _visited;
    private static int _answer;
    
    public int solution(int k, int[,] dungeons) {
        _dungeons = dungeons;
        _visited = new bool[dungeons.GetLength(0)];
        _answer = 0;

        DFS(k, 0);

        return _answer;
    }
    
    private void DFS(int fatigue, int count)
    {
        _answer = Math.Max(_answer, count);

        int dungeonCount = _dungeons.GetLength(0);

        for (int i = 0; i < dungeonCount; i++)
        {
            int requiredFatigue = _dungeons[i, 0];
            int consumedFatigue = _dungeons[i, 1];

            if (_visited[i]) continue;

            if (fatigue < requiredFatigue) continue;

            _visited[i] = true;

            DFS(fatigue - consumedFatigue, count + 1);

            _visited[i] = false;
        }
    }
}