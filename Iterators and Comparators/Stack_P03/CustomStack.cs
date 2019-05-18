using System;
using System.Collections;
using System.Collections.Generic;

namespace P03.Stack
{
    public class CustomStack<T> : IEnumerable<T>
    {
        private List<T> data;

        public CustomStack()
        {
            this.data = new List<T>();
        }

        public void Push(T element)
        {
            this.data.Add(element);
        }

        public string Pop()
        {
            if (this.data.Count == 0)
            {
                throw new ArgumentException("No elements");
            }

            T removedElement = data[data.Count - 1];

            data.RemoveAt(data.Count - 1);

            return removedElement.ToString();
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.data.Count - 1; i >= 0; i--)
            {
                yield return this.data[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
            => this.GetEnumerator();
    }
}
