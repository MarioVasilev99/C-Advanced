namespace GenericSwap_P02
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Box<T>
    {
        public Box(T value)
        {
            this.Value = $"{value.GetType()}: {value}";
        }

        public string Value { get; private set; }


        public override string ToString()
        {
            return this.Value;
        }
    }
}
