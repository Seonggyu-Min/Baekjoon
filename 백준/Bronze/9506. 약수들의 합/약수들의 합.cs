using System.Text;
public class Program
{
    static void Main(string[] args)
    {
        List<int> _list = new();
        StringBuilder _sb = new();

        while (true)
        {
            _list.Clear();
            _sb.Clear();

            int _input = int.Parse(Console.ReadLine());

            if (_input == -1)
            {
                break;
            }

            for (int i = 1; i <= _input / 2; i++)
            {
                if (_input % i == 0)
                {
                    _list.Add(i);
                }
            }

            int _addStroage = 0;

            foreach (int i in _list)
            {
                _addStroage += i;
            }

            if (_addStroage == _input)
            {
                for (int i = 0; i < _list.Count; i++)
                {
                    if (i == 0)
                    {
                        _sb.Append(_input);
                        _sb.Append(" = ");
                    }

                    if (i == _list.Count - 1)
                    {
                        _sb.Append(_list[i]);
                        break;
                    }

                    _sb.Append(_list[i]);
                    _sb.Append(" + ");
                }
            }
            else
            {
                _sb.Append(_input);
                _sb.Append(" is NOT perfect.");
            }

            Console.WriteLine(_sb.ToString());
        }
    }
}