namespace YouWantSumNames.Main.NamesDir
{
    internal class FemaleFirst
    {
        private string[] names = {
            "Mary", "Patricia", "Jennifer", "Linda", "Elizabeth",
            "Barbara", "Susan", "Jessica", "Sarah", "Karen",
            "Nancy", "Margaret", "Lisa", "Betty", "Dorothy",
            "Sandra", "Ashley", "Kimberly", "Donna", "Emily",
            "Michelle", "Carol", "Amanda", "Melissa", "Deborah",
            "Stephanie", "Rebecca", "Laura", "Sharon", "Cynthia",
            "Kathleen", "Amy", "Shirley", "Angela", "Helen",
            "Anna", "Brenda", "Pamela", "Nicole", "Emma",
            "Samantha", "Katherine", "Christine", "Debra", "Rachel",
            "Carolyn", "Janet", "Catherine", "Maria", "Heather",
            "Diane", "Ruth", "Julie", "Olivia", "Joyce",
            "Virginia", "Victoria", "Kelly", "Lauren", "Christina",
            "Joan", "Evelyn", "Judith", "Megan", "Cheryl",
            "Andrea", "Hannah", "Martha", "Jacqueline", "Frances",
            "Gloria", "Ann", "Teresa", "Kathryn", "Sara",
            "Janice", "Jean", "Alice", "Madison", "Doris",
            "Abigail", "Julia", "Judy", "Grace", "Denise",
            "Amber", "Marilyn", "Beverly", "Danielle", "Theresa",
            "Sophia", "Marie", "Diana", "Brittany", "Natalie",
            "Isabella", "Gabriella", "Charlotte", "Zoe", "Lily"
        };
        public string GetRandom() => names[RandomHandler.Get(0, names.Length - 1)];
        public string[] Return() => names;
    }
}