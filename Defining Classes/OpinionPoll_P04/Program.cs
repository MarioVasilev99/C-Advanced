namespace OpinionPoll_P04
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());

            List<Person> people = new List<Person>();

            for (int i = 0; i < numberOfPeople; i++)
            {
                string[] personData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = personData[0];
                int age = int.Parse(personData[1]);

                Person newPerson = new Person(name, age);

                people.Add(newPerson);
            }

            // Find People Older than 30 years old.
            List<Person> peopleOlderThanThirty = people.Where(x => x.Age > 30)
                .OrderBy(p => p.Name)
                .ToList();

            foreach (var person in peopleOlderThanThirty)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
