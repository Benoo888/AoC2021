using System.Text.RegularExpressions;

namespace AoC2021.Solutions.Day02
{
    internal class Part01
    {
        private static int forward;
        private static int up;
        private static int down;

        public static void Execute()
        {
            var input = DataLoader.LoadDataPerLineFromDay("02");
            var regex = new Regex(@"\d+");

            forward = input.Where(s => s.Contains("forward")).Sum(i => int.Parse(regex.Match(i).Value));
            up = input.Where(s => s.Contains("up")).Sum(i => int.Parse(regex.Match(i).Value));
            down = input.Where(s => s.Contains("down")).Sum(i => int.Parse(regex.Match(i).Value));

            PrettyConsolewriter.WriteLine($"Day 2 part 1: {Math.Abs(down - up) * forward} depth times forward");
        }
    }
}
