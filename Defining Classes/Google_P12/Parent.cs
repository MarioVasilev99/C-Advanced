namespace Google_P12
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Parent
    {
        public Parent(string name, string birthDate)
        {
            this.Name = name;
            this.BirthDate = birthDate;
        }

        public string Name { get; set; }

        public string BirthDate { get; set; }
    }
}
