namespace Google_P12
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Child
    {
        public Child(string name, string birthDay)
        {
            this.Name = name;
            this.BirthDay = birthDay;
        }

        public string Name { get; set; }

        public string BirthDay { get; set; }
    }
}
