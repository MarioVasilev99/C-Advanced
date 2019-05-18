namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Person
    {
        public Person(string nameToSet, int ageToSet)
        {
            this.Name = nameToSet;
            this.Age = ageToSet;
        }

        public Person(int ageToSet) : this("No name", ageToSet)
        {
        }

        public Person() : this("No name", 1)
        {
        }

        public string Name { get; set; }

        public int Age { get; set; }
    }
}
