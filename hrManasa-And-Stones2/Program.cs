namespace hrManasa_And_Stones
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        private static int _stones;
        private static int _a;
        private static int _b;
        private static List<int> _answers;

        static void Main()
        {
            int numCases = Int32.Parse(Console.ReadLine());
            while (numCases-- > 0)
            {
                _stones = Int32.Parse(Console.ReadLine()) - 1;
                _a = Int32.Parse(Console.ReadLine());
                _b = Int32.Parse(Console.ReadLine());
                _answers = new List<int>();
                if (_a > _b)
                {
                    int tmp = _a;
                    _a = _b;
                    _b = tmp;
                }
                _answers.Add(_stones * _a);
                int dif = _b - _a;
                for (int i = 1; i <= _stones; i++)
                {
                    _answers.Add(_answers[0] + (dif * i));
                }
                foreach (var answer in _answers)
                {
                    Console.Write(answer + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
