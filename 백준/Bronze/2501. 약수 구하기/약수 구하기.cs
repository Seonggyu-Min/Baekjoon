public class Program
{
    static void Main(string[] args)
    {
        string[] _inputs = Console.ReadLine().Split();

        int _n = int.Parse(_inputs[0]);
        int _k = int.Parse(_inputs[1]);

        List<int> _subsList = new();

        for (int i = 1; i <= _n; i++)
        {
            if (_n % i == 0)
            {
                _subsList.Add(i);
            }
        }

        if (_subsList.Count < _k)
        {
            Console.WriteLine(0);
        }
        else
        {
            Console.WriteLine(_subsList[_k - 1]);
        }
    }
}