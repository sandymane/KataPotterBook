using FluentAssertions;
using KataPotterBook;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KataPotterBookTest
{

    [TestClass]
    public class BasketTest
    {
        [TestMethod]
        public void NumberOfBooksInTheBasketShouldBeEqualsToZEroAtInitialization()
        {
            Basket basket = new Basket();

            int booksNumber = basket.GetNumberOfBooks();

            booksNumber.Should().Be(0);
        }

        [TestMethod]
        public void NumberOfBooksInTheBasketShouldBeOneWhenAddingOneBook()
        {
            Basket basket = new Basket();

            Book book = new Book("Harry Potter à l'école des sorciers");

            basket.Add(book);

            int booksNumber = basket.GetNumberOfBooks();

            booksNumber.Should().Be(1);
        }

        [TestMethod]
        public void NumberOfBooksInTheBasketShouldBeFourWhenAddingFourBooks()
        {
            Basket basket = new Basket();
            Book book1 = new Book("Harry Potter à l'école des sorciers");
            Book book2 = new Book("Harry Potter et la chambre des secrets");
            Book book3 = new Book("Harry Potter et le prisonnier d'Azkaban");
            Book book4 = new Book("Harry Potter et la coupe de feu");
            basket.Add(book1);
            basket.Add(book2);
            basket.Add(book3);
            basket.Add(book4);

            int booksNumber = basket.GetNumberOfBooks();

            booksNumber.Should().Be(4);
        }


        [TestMethod]
        public void BasketPriceShouldBeEqualOfEightWhenAddingOneBook()
        {
            Basket basket = new Basket();
            Book book = new Book("Harry Potter et la coupe de feu");
            basket.Add(book);
            
            Price basketPrice = basket.GetPrice();
            Price bookPrice = new Price(8);

            basketPrice.Equals(bookPrice).Should().BeTrue();
        }

        [TestMethod]
        public void BasketPriceShouldBeEqualOf24WhenAddingThreeBook()
        {
            Basket basket = new Basket();
            Book book1 = new Book("Harry Potter à l'école des sorciers");
            Book book2 = new Book("Harry Potter et la chambre des secrets");
            Book book3 = new Book("Harry Potter et le prisonnier d'Azkaban");
            basket.Add(book1);
            basket.Add(book2);
            basket.Add(book3);

            Price basketPrice = basket.GetPrice();
            Price priceOf3Books = new Price(24);

            basketPrice.Equals(priceOf3Books).Should().BeTrue();
        }
    }

}
