class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] sInput = input.Split(' ');
        int h = int.Parse(sInput[0]);
        int m = int.Parse(sInput[1]);

        TimeOfAlarm(h, m);
    }

    static void TimeOfAlarm(int h, int m)
    {
        if (m < 45)
        {
            h--;
            m += 15;
            if (h < 0)
            { 
                h = 23;
            }
            System.Console.WriteLine("{0} {1}", h, m);
        }
        
        else
        {
            m -= 45;
            System.Console.WriteLine("{0} {1}", h, m);
        }
    }
}