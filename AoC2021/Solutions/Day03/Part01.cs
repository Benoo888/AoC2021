using System.Text.RegularExpressions;

namespace AoC2021.Solutions.Day03
{
    internal class Part01
    {
        public static void Execute()
        {
            var input = DataLoader.LoadDataPerLineFromDay("03");

            var intArray = input.Select(input => input.Select(x => (int)char.GetNumericValue(x)).ToArray());

            var gamma = new int[12];
            var epsilon = new int[12];

            for (int i = 0; i < 12; i++)
            {
                var digit = intArray.Select(item => item[i]);
                var digitzero = digit.Where(d => d == 0).Count();
                var digitone = digit.Where(d => d == 1).Count();

                gamma[i] = digitzero > digitone ? 0 : 1;
                epsilon[i] = digitzero > digitone ? 1 : 0;
            }

            var gammaValue = Convert.ToInt32(string.Join("", gamma.Select(x => x.ToString())),2);
            var epsilonValue = Convert.ToInt32(string.Join("", epsilon.Select(x => x.ToString())),2);
                                                
            PrettyConsolewriter.WriteLine($"Day 3 part 1: {gammaValue * epsilonValue} gamma times epsilon");
        }
    }
}
