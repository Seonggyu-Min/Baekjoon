public class Program
{
    static void Main(string[] args)
    {
        Dictionary<char, int> dic = new Dictionary<char, int>();

        dic.Add('0', 0);
        dic.Add('1', 1);
        dic.Add('2', 2);
        dic.Add('3', 3);
        dic.Add('4', 4);
        dic.Add('5', 5);
        dic.Add('6', 6);
        dic.Add('7', 7);
        dic.Add('8', 8);
        dic.Add('9', 9);
        dic.Add('A', 10);
        dic.Add('B', 11);
        dic.Add('C', 12);
        dic.Add('D', 13);
        dic.Add('E', 14);
        dic.Add('F', 15);
        dic.Add('G', 16);
        dic.Add('H', 17);
        dic.Add('I', 18);
        dic.Add('J', 19);
        dic.Add('K', 20);
        dic.Add('L', 21);
        dic.Add('M', 22);
        dic.Add('N', 23);
        dic.Add('O', 24);
        dic.Add('P', 25);
        dic.Add('Q', 26);
        dic.Add('R', 27);
        dic.Add('S', 28);
        dic.Add('T', 29);
        dic.Add('U', 30);
        dic.Add('V', 31);
        dic.Add('W', 32);
        dic.Add('X', 33);
        dic.Add('Y', 34);
        dic.Add('Z', 35);

        string[] input = Console.ReadLine().Split();
        string num = input[0];
        char[] numArr = num.ToArray();
        int numberSystem = int.Parse(input[1]);

        int sum = 0;
        int digit = 0;

        Array.Reverse(numArr);

        for (int i = 0; i < numArr.Length; i++)
        {
            dic.TryGetValue(numArr[i], out digit);
            sum += digit * (int)Math.Pow(numberSystem, i);
        }

        Console.WriteLine(sum);
    }
}