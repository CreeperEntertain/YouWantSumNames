namespace YouWantSumNames.Main
{
    internal class RandomHandler
    {
        private static Random random = new Random();
        public static int Get(int min, int max) => random.Next(min, max);
    }
}