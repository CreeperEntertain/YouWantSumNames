using YouWantSumNames.Main;
using YouWantSumNames.Main.NamesDir;

public class Program
{
    private static Names names = new Names();
    private static MaleFirst maleFirst = new MaleFirst();
    private static FemaleFirst femaleFirst = new FemaleFirst();
    private static Last last = new Last();
    public static void Main(string[] args)
    {
        string gender = GetGender();
        if (gender == "list")
            names.PrintSorted(last.Return());
        else ResolveFirstName(gender);
    }

    private static string GetGender()
    {
        string[] possibleAnswers = { "male", "female", "list" };
        bool loop = true;
        while (loop)
        {
            Console.WriteLine("Please type \"female\" or \"male\".");
            Console.WriteLine("Otherwise type \"list\" for a full list of last names.");
            string input = Console.ReadLine() ?? "";
            if (possibleAnswers.Contains(input))
                return input;
            else
            {
                Console.Clear();
                Console.WriteLine("Incorrect input.");
            }
        }
        return "";
    }

    private static void ResolveFirstName(string gender)
    {
        int amount = 0;
        bool loop = true;
        while (loop)
        {
            bool listedNames = false;
            Console.WriteLine("Type out how many names you need.");
            Console.WriteLine($"Otherwise, type \"list\" for a list of {gender} first names.");
            string input = Console.ReadLine() ?? "";
            try { amount = int.Parse(input); }
            catch { FirstNameHandling(input, gender, ref listedNames, out bool repeat); if (repeat) continue; }
            if (!listedNames) FirstNameGenderedList(gender, amount, out loop);
        }
    }
    private static void FirstNameHandling(string input, string gender, ref bool listedNames, out bool repeat)
    {
        repeat = false;
        if (input == "list")
        {
            listedNames = true;
            if (gender == "male") names.PrintSorted(maleFirst.Return());
            else if (gender == "female") names.PrintSorted(femaleFirst.Return());
        }
        else
        {
            repeat = true;
            Console.WriteLine("Incorrect input.");
        }
    }
    private static void FirstNameGenderedList(string gender, int amount, out bool loop)
    {
        loop = true;

        bool isMale = false;
        if (gender == "male")
            isMale = true;
        if (amount >= 1 && amount <= 100)
        {
            loop = false;
            for (int i = 0; i < amount; i++)
                Console.WriteLine(names.Get(isMale, true, i));
        }
        else
        {
            Console.Clear();
            Console.WriteLine("The number has to be between 1 and 100.");
        }
    }
}