using System.Text.RegularExpressions;

namespace AoC2021.Solutions.Day02
{
    internal class Part02
    {
        public static void Execute()
        {
            var input = DataLoader.LoadDataPerLineFromDay("02");

            var regex = new Regex(@"\d+");

            var horizontalPosition = input.Where(s => s.Contains("forward")).Sum(i => int.Parse(regex.Match(i).Value));

            Console.WriteLine($"{ horizontalPosition } horizontal position");

            int aim = 0;
            int depth = 0;

            for (int i = 0; i < input.Length; i++)
            {
                var line = input[i];
                                
                if (line.Contains("up"))
                {
                    aim -= int.Parse(regex.Match(line).Value);
                }

                if (line.Contains("down"))
                {
                    aim += int.Parse(regex.Match(line).Value);
                }

                if (line.Contains("forward"))
                {
                    var forward = int.Parse(regex.Match(line).Value);
                    depth += (aim * forward);
                }
            }

            Console.WriteLine($"{ depth } depth");

            PrettyConsolewriter.WriteLine($"Day 2 part 2:{ depth * horizontalPosition } depth times horizontalposition");
        }
    }
}
