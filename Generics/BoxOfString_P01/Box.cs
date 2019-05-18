namespace BoxOfString_P01
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Box<T>
    {
        public Box(string value)
        {
            this.Value = value;
        }

        public string Value { get; set; }

        public override string ToString()
        {
            return $"{this.Value.GetType()}: {this.Value}";
        }
    }
}
