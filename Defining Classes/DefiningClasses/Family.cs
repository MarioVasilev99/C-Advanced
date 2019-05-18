namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Family
    {
        private List<Person> people = new List<Person>();

        public Family()
        {
            this.people = new List<Person>();
        }

        public void AddMember(Person newMember)
        {
            this.people.Add(newMember);
        }

        public Person GetOldestMember()
        {
            if (this.people.Any())
            {
                Person oldestPerson = this.people.OrderByDescending(p => p.Age).First();

                return oldestPerson;
            }
            else
            {
                throw new InvalidOperationException("Family Empty! No persons in the family");
            }
        }
    }
}
