namespace P07.Tuple
{
    public class Tuple<T, K>
    {
        private T item1;
        private K item2;

        public Tuple(T firstItem,K secondItem)
        {
            this.item1 = firstItem;
            this.item2 = secondItem;
        }

        public override string ToString()
        {
            return $"{item1} -> {item2}";
        }
    }
}
