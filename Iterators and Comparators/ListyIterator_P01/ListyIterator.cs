using System.Collections.Generic;

namespace P01.ListyIterator
{
    public class ListyIterator<T>
    {
        private List<T> data;
        private int index;

        public ListyIterator(List<T> dataList)
        {
            this.data = dataList;
        }

        public bool Move()
        {
            if (this.HasNext())
            {
                index++;

                return true;
            }

            return false;
        }

        public bool HasNext()
        {
            if (index + 1 < data.Count)
            {
                return true;
            }

            return false;
        }

        public string Print()
        {
            if (this.data.Count == 0)
            {
                return "Invalid Operation!";
            }

            return this.data[index].ToString();
        }
    }
}
