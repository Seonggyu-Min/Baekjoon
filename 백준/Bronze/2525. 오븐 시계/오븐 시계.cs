class Program
{
    static void Main(string[] args)
    {
        string currentTimeInput = Console.ReadLine();
        string cookTimeInput = Console.ReadLine();

        string[] sCurrentTime = currentTimeInput.Split(' ');

        int currentH = int.Parse(sCurrentTime[0]);
        int currentM = int.Parse(sCurrentTime[1]);
        int cookTime = int.Parse(cookTimeInput);
        int outputH;
        int outputM;

        if (currentM + cookTime < 60)
        {
            System.Console.WriteLine("{0} {1}", currentH, currentM + cookTime);
        }
        else
        {
            int plusHour = (currentM + cookTime) / 60;

            if (plusHour + currentH >= 24)
            {
                outputH = (plusHour + currentH) - 24;
                outputM = (currentM + cookTime) % 60;
            }
            else
            {
                outputH = (plusHour + currentH);
                outputM = (currentM + cookTime) % 60;
            }
            System.Console.WriteLine("{0} {1}", outputH, outputM);

        }
    }
}