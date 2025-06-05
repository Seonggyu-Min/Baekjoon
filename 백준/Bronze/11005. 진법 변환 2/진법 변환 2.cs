using System.Text;
public class Program
{
    static void Main(string[] args)
    {
        string[] _inputs = Console.ReadLine().Split();

        int _inputNum = int.Parse(_inputs[0]);
        int _numSys = int.Parse(_inputs[1]);

        StringBuilder _sb = new();
        StringBuilder _sb2 = new();

        while (_inputNum > 0)
        {
            _sb.Append(ConvertIntToChar(_inputNum % _numSys));
            _inputNum /= _numSys;
        }

        string _tmp = _sb.ToString();

        for (int i = _tmp.Length - 1; i >= 0; i--)
        {
            _sb2.Append(_tmp[i]);
        }
        
        Console.WriteLine(_sb2.ToString());
    }

    private static char ConvertIntToChar(int value)
    {
        if (value >= 0 && value < 10)
        {
            char c = (char)(value + '0');
            return c;
        }
        else
        {
            char c = (char)(value + ('A' - 10));
            return c;
        }
    }
}