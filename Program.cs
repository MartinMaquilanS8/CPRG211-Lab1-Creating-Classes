namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person(1, "Ian", "Brooks", "Red", 30, true);
            Person person2 = new Person(2, "Gina", "James", "Red", 18, false);
            Person person3 = new Person(3, "Mike", "Briscoe", "Blue", 45,  true);
            Person person4 = new Person(4, "Mary", "Beals", "Yellow", 28,  true);

            string ginasInfo = person2.DisplayPersonInfo();
            Console.WriteLine(ginasInfo);

            string mikesInfo = person3.ToString();
            Console.WriteLine(mikesInfo);

            person1.ChangeFavoriteColour();
            string iansInfo = person1.DisplayPersonInfo();
            Console.WriteLine(iansInfo);

            int marysAgeTenYears = person4.GetAgeInTenYears();
            Console.WriteLine($"Mary's Beal's Age in 10 years is: {marysAgeTenYears}\n");

            Relation relation1 = new Relation("Sisterhood", person2, person4);
            Relation relation2 = new Relation("Brotherhood", person1, person3);

            Console.WriteLine(relation1.ToString());
            Console.WriteLine(relation2.ToString());

            List<Person> people = new List<Person>();

            people.Add(person1);
            people.Add(person2);
            people.Add(person3);
            people.Add(person4);

            int sum = 0;

            foreach (Person person in people)
            {
                sum += person.Age;
            }

            double average = sum / (double)people.Count;

            Console.WriteLine($"Average age is: {average}\n");



            foreach (Person person in people)
            {
                if (person.FirstName.StartsWith("M"))
                {
                    Console.WriteLine($"Person whose first name starts with 'M': {person.FirstName} {person.LastName}");
                }

                if (person.FavoriteColour.Equals("Blue", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(person.ToString());
                }
            }
        }
    }
}