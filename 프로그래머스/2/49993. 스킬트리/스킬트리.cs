using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string skill, string[] skill_trees) {
        // 1 <= skill.Length <= 26
        // 2 <= skill_trees.Length <= 20
        // 2 <= skill_trees 원소의 Length <= 26

        // e.g. 
        // "CBD"
        // ["BACDE", "CBADF", "AECB", "BDA"]

        var set = new HashSet<char>(skill);
        int count = 0;

        // 2 <= n <= 520
        foreach (var userSkillTree in skill_trees)
        {
            var queue = new Queue<char>(skill);

            bool isValid = true;
            foreach (var userSkill in userSkillTree)
            {
                // 선행 스킬과 관계없는 스킬이면 무시
                if (!set.Contains(userSkill))
                {
                    continue;
                }

                // 현재 배워야 할 선행 스킬과 다르면 잘못된 스킬트리
                if (userSkill != queue.Dequeue())
                {
                    isValid = false;
                    break;
                }
            }

            if (isValid)
            {
                count++;
            }
        }

        return count;
    }
}