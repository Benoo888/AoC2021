namespace AoC2021.Solutions.Day03
{
    internal class Part02
    {
        public static void Execute()
        {
            var input = DataLoader.LoadDataPerLineFromDay("03");

            var intArray = input.Select(input => input.Select(x => (int)char.GetNumericValue(x)).ToArray());

            var OxygenRate = GetSingleRate(intArray.ToList(), 1, Preference.MostCommon);
            var Co2Rate = GetSingleRate(intArray.ToList(), 0, Preference.LeastCommon);

            var oxygenValue = Convert.ToInt32(string.Join("", OxygenRate.Select(x => x.ToString())), 2);
            var co2Value = Convert.ToInt32(string.Join("", Co2Rate.Select(x => x.ToString())), 2);

            PrettyConsolewriter.WriteLine($"Day 3 part 2: {oxygenValue * co2Value} oxygen rate times co2 rate");
        }

        private static int[] GetSingleRate(List<int[]> array, int preferredBit, Preference preference)
        {
            for (int i = 0; i < array.First().Length; i++)
            {
                if (array.Count == 1) break;
                array = GetRates(array, i, preferredBit, preference);
            }

            return array.Single();
        }

        private static List<int[]> GetRates(List<int[]> array, int index, int preferredBit, Preference preference)
        {
            var digit = array.Select(item => item[index]);
            var digitPreferred = digit.Where(d => d == preferredBit).Count();
            var digitSecondary = digit.Where(d => d != preferredBit).Count();

            if ((preference == Preference.MostCommon && digitPreferred >= digitSecondary) ||
              (preference == Preference.LeastCommon && digitPreferred <= digitSecondary))
            {
                return array.Select(item => item).Where(b => b[index] == preferredBit).ToList();
            }
            else
            {
                return array.Select(item => item).Where(b => b[index] != preferredBit).ToList();
            }
        }

        private enum Preference
        {
            MostCommon,
            LeastCommon
        }
    }
}
