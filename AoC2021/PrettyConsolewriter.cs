namespace AoC2021
{
    internal static class PrettyConsolewriter
    {
        public static void WriteLine(string line)
        {
            var formatString = new string('-', line.Length + 4);

            Console.WriteLine(formatString);
            Console.WriteLine($"| {line} |");
            Console.WriteLine(formatString);
        }
    }
}
