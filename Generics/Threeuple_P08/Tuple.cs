namespace P07.Tuple
{
    public class Tuple<TFirstItem, TSecondItem, TThirdItem>
    {
        private TFirstItem item1;
        private TSecondItem item2;
        private TThirdItem item3;
        
        public Tuple(TFirstItem firstItem, TSecondItem secondItem, TThirdItem thirdItem)
        {
            this.item1 = firstItem;
            this.item2 = secondItem;
            this.item3 = thirdItem;
        }

        public override string ToString()
        {
            return $"{this.item1} -> {this.item2} -> {this.item3}";
        }
    }
}
