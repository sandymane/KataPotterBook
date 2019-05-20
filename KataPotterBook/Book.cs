namespace KataPotterBook
{
    public class Book
    {
        public Price Price { get; private set; }
        public string Name { get; private set; }

        public Book(string name)
        {
            Price = new Price(BookShop.BookPrice);
            Name = name;
        }

        public double GetPrice()
        {
            return Price.Value;
        }
    }
}