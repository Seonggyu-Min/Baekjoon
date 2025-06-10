public class Program
{
    static void Main(string[] args)
    {
        int inputNum = int.Parse(Console.ReadLine());

        int endNum = 0;
        int num = 0;
        int endNumOrder = 0;

        while (endNumOrder != inputNum)
        {
            num++;
            string stringNum = num.ToString();
            
            int count = 0;

            for (int i = 0; i < stringNum.Length; i++)
            {

                if (stringNum[i] == '6')
                {
                    count++;
                }
                else
                {
                    count = 0;
                }

                if (count >= 3)
                {
                    endNumOrder++;
                    break;
                }
            }
        }

        Console.WriteLine(num);
    }
}