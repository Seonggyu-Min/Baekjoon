using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] progresses, int[] speeds) {
        var queue = new Queue<Feature>();
        var finishList = new List<int>();

        for (int i = 0; i < progresses.Length; i++)
        {
            queue.Enqueue(new(progresses[i], speeds[i]));
        }

        int count = 0;
        while (0 < queue.Count)
        {
            foreach (var feature in queue)
            {
                feature.Advance();
            }

            bool hasAnyFinished = false;
            while (0 < queue.Count)
            {
                queue.TryPeek(out var result);

                if (result.IsDone)
                {
                    if (finishList.Count == count)
                    {
                        finishList.Add(1);
                    }
                    else
                    {
                        finishList[count]++;
                    }

                    hasAnyFinished = true;
                    queue.Dequeue();
                }
                else
                {
                    break;
                }
            }

            if (hasAnyFinished)
            {
                count++;
            }
        }

        return finishList.ToArray();
    }
    
        public class Feature
    {
        public int Progress;
        public int Speed;

        public bool IsDone => 100 <= Progress;

        public Feature(int progress, int speed)
        {
            Progress = progress;
            Speed = speed;
        }

        public void Advance()
        {
            Progress += Speed;
        }
    }
}