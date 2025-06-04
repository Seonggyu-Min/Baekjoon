public class Program
{
    static void Main(string[] args)
    {
        string[] _inputs = Console.ReadLine().Split();

        int _dayHeight = int.Parse(_inputs[0]);
        int _nightHeight = int.Parse(_inputs[1]);
        int _goalHeight = int.Parse(_inputs[2]);

        int _totalHeight = _dayHeight - _nightHeight;
        int _dayNum = 1; // 1일 부터 시작
        _dayNum += ((_goalHeight - _dayHeight) + (_totalHeight - 1)) / _totalHeight; // 나머지가 있을 시 몫 + 1

        Console.WriteLine(_dayNum);
    }
}