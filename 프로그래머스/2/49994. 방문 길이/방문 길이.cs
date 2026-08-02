using System;
using System.Collections.Generic;
using System.Numerics;

public class Solution {
    public int solution(string dirs) {
        // 문제에서 요구하는 것
        // 이미 지난 선분인지 확인
        // 주어진 좌표평면 (5,5) ~ (-5,-5)를 벗어나면 무시
        // 이동하면 이동한 선분 기록
        // 현재 위치 기록

        var curPos = Vector2.Zero;
        var set = new HashSet<Line>(500);

        foreach (var c in dirs)
        {
            var dir = GetDirection(c);
            var nextPos = GetNextPos(curPos, dir);

            if (IsWithinBounds(nextPos))
            {
                set.Add(new Line(curPos, nextPos));
                curPos = nextPos;
            }
        }

        return set.Count;
    }
    
        public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    }

    public static Direction GetDirection(char c)
    {
        return c switch
        {
            'U' => Direction.Up,
            'D' => Direction.Down,
            'L' => Direction.Left,
            'R' => Direction.Right,
            _ => throw new ArgumentException("Invalid direction character")
        };
    }

    public static Vector2 GetNextPos(Vector2 currentPos, Direction dir)
    {
        switch (dir)
        {
            case Direction.Up:
                return new Vector2(currentPos.X, currentPos.Y + 1);
            case Direction.Down:
                return new Vector2(currentPos.X, currentPos.Y - 1);
            case Direction.Left:
                return new Vector2(currentPos.X - 1, currentPos.Y);
            case Direction.Right:
                return new Vector2(currentPos.X + 1, currentPos.Y);
            default:
                throw new ArgumentException("Invalid direction");
        }
    }

    public static bool IsWithinBounds(Vector2 vector2)
    {
        return vector2.X >= -5 && vector2.X <= 5 && vector2.Y >= -5 && vector2.Y <= 5;
    }

    public readonly struct Line
    {
        public readonly Vector2 V1;
        public readonly Vector2 V2;

        public Line(Vector2 v1, Vector2 v2)
        {
            if (Compare(v1, v2) <= 0)
            {
                V1 = v1;
                V2 = v2;
            }
            else
            {
                V1 = v2;
                V2 = v1;
            }
        }

        private static int Compare(Vector2 a, Vector2 b)
        {
            int xComparison = a.X.CompareTo(b.X);
            return xComparison != 0 ? xComparison : a.Y.CompareTo(b.Y);
        }
    }
}