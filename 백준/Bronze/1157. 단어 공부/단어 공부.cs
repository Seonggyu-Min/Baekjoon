public class Program
{
    static void Main(string[] args)
    {
        // 입력 받기
        string s = Console.ReadLine().ToUpper();
        // A-Z 배열
        int[] counts = new int[26];
        // 최댓값 저장
        int max = 0;

        for (int i = 0; i < s.Length; i++)
        {
            counts[s[i] - 'A']++;
        }

        // 최댓값 인덱스 구하기
        for (int i = 1; i < 26; i++)
        {
            if (counts[max] < counts[i])
                max = i;
        }

        // 최댓값이 몇 번 나오는지 세기
        int maxCount = 0;

        for (int i = 0; i < 26; i++)
        {
            if (counts[i] == counts[max])
                maxCount++;
        }

        if (maxCount > 1)
        {
            Console.WriteLine("?");
            return;
        }

        Console.WriteLine((char)(max + 'A'));
    }
}