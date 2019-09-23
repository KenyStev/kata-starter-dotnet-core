using System.Linq;

namespace Kata
{
    public class Calculator
    {
        public int Add(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }

            var numbers = s.Split(",").Select(int.Parse).ToArray();
            var sum = numbers[0];

            return numbers.Length == 2 ? sum + numbers[1] : sum;
        }
    }
}