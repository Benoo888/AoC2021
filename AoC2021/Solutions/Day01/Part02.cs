namespace AoC2021.Solutions.Day01
{
    internal class Part02
    {
        public static void Execute()
        {
            var input = DataLoader.LoadDataPerLineFromDay("01");

            int increased = 0;

            for (int i = 0; i < input.Length - 3; i++)
            {
                var a = int.Parse(input[i]) + int.Parse(input[i + 1]) + int.Parse(input[i + 2]);
                var b = int.Parse(input[i + 1]) + int.Parse(input[i + 2]) + int.Parse(input[i + 3]);

                if (b > a)
                {
                    increased++;
                }
            }

            PrettyConsolewriter.WriteLine($"Day 1 part 2: {increased} higher than previous");
        }
    }
}
