namespace DefiningClasses
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int numberOfPeopleToRead = int.Parse(Console.ReadLine());

            Family newFamily = new Family();

            for (int i = 0; i < numberOfPeopleToRead; i++)
            {
                string[] personData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string personName = personData[0];
                int personAge = int.Parse(personData[1]);

                Person newPerson = new Person(personName, personAge);

                newFamily.AddMember(newPerson);
            }

            // Print the oldest member of the family
            Person oldestPersonInFamily = newFamily.GetOldestMember();

            Console.WriteLine($"{oldestPersonInFamily.Name} {oldestPersonInFamily.Age}");
        }
    }
}
