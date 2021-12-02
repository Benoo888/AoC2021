namespace AoC2021
{
    internal class DataLoader
    {
        public static string[] LoadDataPerLineFromDay(string day)
        {
            return File.ReadAllLines(@$"D:\TestProjects\AoC2021\AoC2021\Input\day_{day}.txt");
        }
    }
}
