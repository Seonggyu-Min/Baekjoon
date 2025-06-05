public class Program
{
    static void Main(string[] args)
    {
        int _firstNum = -1;
        int _secondNum = -1;

        while (true)
        {
            string[] _inputs = Console.ReadLine().Split();
            _firstNum = int.Parse(_inputs[0]);
            _secondNum = int.Parse(_inputs[1]);

            if (_firstNum == 0 && _secondNum == 0)
            {
                break;
            }

            if (_firstNum % _secondNum == 0)
            {
                Console.WriteLine("multiple");
            }
            else if (_secondNum % _firstNum == 0)
            {
                Console.WriteLine("factor");
            }
            else
            {
                Console.WriteLine("neither");
            }
        }
    }
}