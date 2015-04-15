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
        private static HashSet<int> _answers;

        static void Main()
        {
            int numCases = Int32.Parse(Console.ReadLine());
            while (numCases-- > 0)
            {
                _stones = Int32.Parse(Console.ReadLine()) - 1;
                _a = Int32.Parse(Console.ReadLine());
                _b = Int32.Parse(Console.ReadLine());
                _answers = new HashSet<int>();
                Solve(0, 0);
                foreach (var answer in _answers.OrderBy(x => x))
                {
                    Console.Write(answer + " ");
                }
                Console.WriteLine();
            }
        }

        private static void Solve(int curVal, int depth)
        {
            if (depth == _stones)
            {
                _answers.Add(curVal);
            }
            else
            {
                Solve(curVal + _a, depth + 1);
                Solve(curVal + _b, depth + 1);
            }
        }
    }
}
