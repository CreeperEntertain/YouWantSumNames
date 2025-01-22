using YouWantSumNames.Main.NamesDir;

namespace YouWantSumNames.Main
{
    internal class Names
    {
        private MaleFirst maleFirst = new MaleFirst();
        private FemaleFirst femaleFirst = new FemaleFirst();
        private Last last = new Last();

        public string Get(bool gender, bool showCount = false, int counter = 1)
        {
            string firstName;
            if (gender)
                firstName = maleFirst.GetRandom();
            else
                firstName = femaleFirst.GetRandom();
            string lastName = last.GetRandom();
            string final = $"{firstName} {lastName}";
            if (showCount)
                final = $"{counter + 1}. {final}";
            return final;
        }
        public void PrintSorted(string[] names)
        {
            int iteration = 0;
            foreach (string name in names.OrderBy(n => n))
            {
                iteration++;
                Console.WriteLine($"{iteration}. {name}");
            }
        }
    }
}