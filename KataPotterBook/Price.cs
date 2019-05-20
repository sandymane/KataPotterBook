namespace KataPotterBook
{
    public class Price
    {
        internal double Value { get; private set; }

        public Price(double value)
        {
            Value = value;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            Price price = (Price)obj;
            return Value.Equals(price.Value);
        }

        public override int GetHashCode()
        {
            return -1937169414 + Value.GetHashCode();
        }

        public Price Add(Price price)
        {
            if(price == null)
            {
                return this;
            }
            return new Price(Value + price.Value);
        }

       
    }


}