using System.Linq;
using System.Text.RegularExpressions;

namespace AoC2021.Solutions.Day02
{
    internal class Part02
    {
        public static void Execute()
        {
            var input = DataLoader.LoadDataPerLineFromDay("02");

            var regex = new Regex(@"\d+");

            // phased out the RegEx
            //var horizontalPosition = input.Where(s => s.Contains("forward")).Sum(i => int.Parse(regex.Match(i).Value));
            //Console.WriteLine($"{ horizontalPosition } horizontal position");

            int aim = 0;
            int depth = 0;

            IEnumerable<(string direction, int value)> notebook = input.Select(s => s.Split(' ', 2)).Select(s => (s[0], int.Parse(s[1])));

            var horizontalPosition = notebook.Where(line => line.direction == "forward").Sum(line => line.value);

            foreach(var line in notebook)
            {
                switch (line.direction)
                {
                    case "up":
                        aim -= line.value; break;
                    case "down":
                        aim += line.value; break;
                    case "forward":
                        depth += (aim * line.value); break;
                }
            }

            Console.WriteLine($"{ depth } depth");

            PrettyConsolewriter.WriteLine($"Day 2 part 2:{ depth * horizontalPosition } depth times horizontalposition");
        }
    }
}
