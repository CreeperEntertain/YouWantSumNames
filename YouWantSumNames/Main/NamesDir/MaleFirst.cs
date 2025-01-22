namespace YouWantSumNames.Main.NamesDir
{
    internal class MaleFirst
    {
        private string[] names = {
            "James", "John", "Robert", "Michael", "William",
            "David", "Richard", "Joseph", "Thomas", "Charles",
            "Christopher", "Daniel", "Matthew", "Anthony", "Mark",
            "Donald", "Steven", "Paul", "Andrew", "Joshua",
            "Kenneth", "Kevin", "Brian", "George", "Edward",
            "Ronald", "Timothy", "Jason", "Jeffrey", "Ryan",
            "Jacob", "Gary", "Nicholas", "Eric", "Jonathan",
            "Stephen", "Larry", "Justin", "Scott", "Brandon",
            "Benjamin", "Samuel", "Gregory", "Frank", "Alexander",
            "Patrick", "Raymond", "Jack", "Dennis", "Jerry",
            "Tyler", "Aaron", "Jose", "Adam", "Nathan",
            "Henry", "Douglas", "Zachary", "Peter", "Kyle",
            "Walter", "Ethan", "Jeremy", "Harold", "Keith",
            "Christian", "Roger", "Noah", "Gerald", "Carl",
            "Terry", "Sean", "Austin", "Arthur", "Lawrence",
            "Jesse", "Dylan", "Bryan", "Joe", "Jordan",
            "Billy", "Bruce", "Albert", "Willie", "Gabriel",
            "Logan", "Alan", "Juan", "Wayne", "Roy",
            "Ralph", "Randy", "Eugene", "Carlos", "Russell",
            "Mason", "Elija", "Hudson", "Owen", "Caleb",
            "Levi", "Lincoln", "Elias", "Julian", "Micah"
        };
        public string GetRandom() => names[RandomHandler.Get(0, names.Length - 1)];
        public string[] Return() => names;
    }
}