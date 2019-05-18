namespace Google_P12
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            List<Person> persons = new List<Person>();

            while (true)
            {
                string[] personData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (personData[0] == "End")
                {
                    break;
                }

                string personName = personData[0];

                Person person = persons.FirstOrDefault(p => p.Name == personName);

                if (person == null)
                {
                    person = new Person(personName);

                    persons.Add(person);
                }

                string propertyToModify = personData[1];

                switch (propertyToModify)
                {
                    case "company":
                        string companyName = personData[2];
                        string department = personData[3];
                        decimal salary = decimal.Parse(personData[4]);

                        person.Company = new Company(companyName, department, salary);

                        break;

                    case "pokemon":
                        string pokemonName = personData[2];
                        string pokemonType = personData[3];

                        Pokemon newPokemon = new Pokemon(pokemonName, pokemonType);

                        person.Pokemons.Add(newPokemon);

                        break;

                    case "parents":
                        string parentName = personData[2];
                        string parentBirthDay = personData[3];

                        Parent newParent = new Parent(parentName, parentBirthDay);

                        person.Parents.Add(newParent);

                        break;

                    case"children":
                        string childName = personData[2];
                        string childBirthDay = personData[3];

                        Child newChild = new Child(childName, childBirthDay);

                        person.Children.Add(newChild);

                        break;

                    case "car":
                        string model = personData[2];
                        int carSpeed = int.Parse(personData[3]);

                        person.Car = new Car(model, carSpeed);

                        break;
                }
            }

            string personToPrintName = Console.ReadLine();

            Person personToPrint = persons.FirstOrDefault(p => p.Name == personToPrintName);

            Console.WriteLine(personToPrint.ToString());
        }
    }
}
