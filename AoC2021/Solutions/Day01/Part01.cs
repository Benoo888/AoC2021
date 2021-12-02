namespace AoC2021.Solutions.Day01
{
    internal class Part01
    {
        public static void Execute()
        {
            var input = DataLoader.LoadDataPerLineFromDay("01");

            int increased = 0;


            Console.WriteLine($"{input.Length} total records");

            for (int i = 1; i < input.Length - 2; i++)
            {
                if (int.Parse(input[i]) > int.Parse(input[i - 1]))
                {
                    increased++;
                }
            }

            PrettyConsolewriter.WriteLine($"Day 1 part 1: {increased} higher than previous");
        }
    }
}
