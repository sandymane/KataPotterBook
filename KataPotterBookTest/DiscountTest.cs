using System;
using FluentAssertions;
using KataPotterBook;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KataPotterBookTest
{
    [TestClass]
    public class DiscountTest
    {
        [TestMethod]
        public void DiscountOf5PercentShouldBeApplyWhenBasketContains2DifferentsBooks()
        {
            Basket basket = new Basket();
            Book book1 = new Book("Harry Potter à l'école des sorciers");
            Book book2 = new Book("Harry Potter et la chambre des secrets");
            basket.Add(book1);
            basket.Add(book2);

            Price basketPrice = basket.GetBestBasketPrice();
            double total = 2 * 8 - (2 * 8 * 0.05);
            Price priceOf2booksWithDiscount = new Price(total);

            basketPrice.Equals(priceOf2booksWithDiscount).Should().BeTrue();
        }

        [TestMethod]
        public void DiscountOf10PercentShouldBeApplyWhenBasketContains3DifferentsBooks()
        {
            Basket basket = new Basket();
            Book book1 = new Book("Harry Potter à l'école des sorciers");
            Book book2 = new Book("Harry Potter et la chambre des secrets");
            Book book3 = new Book("Harry Potter et le prisonnier d'Azkaban");
            basket.Add(book1);
            basket.Add(book2);
            basket.Add(book3);

            Price basketPrice = basket.GetBestBasketPrice();
            Price priceOf3booksWithDiscount = new Price(21.6);

            basketPrice.Equals(priceOf3booksWithDiscount).Should().BeTrue();
        }

        [TestMethod]
        public void DiscountOf20PercentShouldBeApplyWhenBasketContains4DifferentsBooks()
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

            Price basketPrice = basket.GetBestBasketPrice();
            Price priceOf4booksWithDiscount = new Price(25.6);

            basketPrice.Equals(priceOf4booksWithDiscount).Should().BeTrue();
        }

        [TestMethod]
        public void DiscountOf25PercentShouldBeApplyWhenBasketContains5DifferentsBooks()
        {
            Basket basket = new Basket();
            Book book1 = new Book("Harry Potter à l'école des sorciers");
            Book book2 = new Book("Harry Potter et la chambre des secrets");
            Book book3 = new Book("Harry Potter et le prisonnier d'Azkaban");
            Book book4 = new Book("Harry Potter et la coupe de feu");
            Book book5 = new Book("Harry Potter et l\'ordre du Phoenix");
            basket.Add(book1);
            basket.Add(book2);
            basket.Add(book3);
            basket.Add(book4);
            basket.Add(book5);

            Price basketPrice = basket.GetBestBasketPrice();
            Price priceOf5booksWithDiscount = new Price(30);

            basketPrice.Equals(priceOf5booksWithDiscount).Should().BeTrue();
        }

        [TestMethod]
        public void Discount6BooksWith2Identical()
        {
            Basket basket = new Basket();
            Book book1 = new Book("Harry Potter à l'école des sorciers");
            Book book6 = new Book("Harry Potter à l'école des sorciers");
            Book book2 = new Book("Harry Potter et la chambre des secrets");
            Book book3 = new Book("Harry Potter et le prisonnier d'Azkaban");
            Book book4 = new Book("Harry Potter et la coupe de feu");
            Book book5 = new Book("Harry Potter et l\'ordre du Phoenix");
            basket.Add(book1);
            basket.Add(book2);
            basket.Add(book3);
            basket.Add(book4);
            basket.Add(book5);
            basket.Add(book6);

            Price basketPrice = basket.GetBestBasketPrice();
            Price priceOf6booksWithDiscount = new Price(38);

            basketPrice.Equals(priceOf6booksWithDiscount).Should().BeTrue();
        }

        [TestMethod]
        public void Discount8BooksWith3setsOf2Identicals()
        {
            Basket basket = new Basket();
            Book book1 = new Book("Harry Potter à l'école des sorciers");
            Book book2 = new Book("Harry Potter à l'école des sorciers");
            Book book3 = new Book("Harry Potter et la chambre des secrets");
            Book book4 = new Book("Harry Potter et la chambre des secrets");
            Book book5 = new Book("Harry Potter et le prisonnier d'Azkaban");
            Book book6 = new Book("Harry Potter et le prisonnier d'Azkaban");
            Book book7 = new Book("Harry Potter et la coupe de feu");
            Book book8 = new Book("Harry Potter et l\'ordre du Phoenix");
            basket.Add(book1);
            basket.Add(book2);
            basket.Add(book3);
            basket.Add(book4);
            basket.Add(book5);
            basket.Add(book6);
            basket.Add(book7);
            basket.Add(book8);

            Price basketPrice = basket.GetBestBasketPrice();
            Price priceWithDiscount = new Price(51.2);

            basketPrice.Equals(priceWithDiscount).Should().BeTrue();
        }

        [TestMethod]
        public void Discount9BooksWith1setsOf4IdenticalsAnd1SetOf2Identicals()
        {
            Basket basket = new Basket();
            Book book1 = new Book("Harry Potter à l'école des sorciers");
            Book book2 = new Book("Harry Potter et la chambre des secrets");
            Book book3 = new Book("Harry Potter et le prisonnier d'Azkaban");
            Book book4 = new Book("Harry Potter et le prisonnier d'Azkaban");
            Book book5 = new Book("Harry Potter et la coupe de feu");
            Book book6 = new Book("Harry Potter et la coupe de feu");
            Book book7 = new Book("Harry Potter et la coupe de feu");
            Book book8 = new Book("Harry Potter et la coupe de feu");
            Book book9 = new Book("Harry Potter et l\'ordre du Phoenix");
            basket.Add(book1);
            basket.Add(book2);
            basket.Add(book3);
            basket.Add(book4);
            basket.Add(book5);
            basket.Add(book6);
            basket.Add(book7);
            basket.Add(book8);
            basket.Add(book9);

            Price basketPrice = basket.GetBestBasketPrice();
            Price priceWithDiscount = new Price(61.2);

            basketPrice.Equals(priceWithDiscount).Should().BeTrue();
        }

        [TestMethod]
        public void Discount8BooksWith1setsOf3IdenticalsAnd1SetOf2Identicals()
        {
            Basket basket = new Basket();
            Book book1 = new Book("Harry Potter à l'école des sorciers");
            Book book2 = new Book("Harry Potter et la chambre des secrets");
            Book book3 = new Book("Harry Potter et le prisonnier d'Azkaban");
            Book book4 = new Book("Harry Potter et le prisonnier d'Azkaban");
            Book book5 = new Book("Harry Potter et la coupe de feu");
            Book book6 = new Book("Harry Potter et la coupe de feu");
            Book book7 = new Book("Harry Potter et la coupe de feu");
            Book book8 = new Book("Harry Potter et l\'ordre du Phoenix");
            basket.Add(book1);
            basket.Add(book2);
            basket.Add(book3);
            basket.Add(book4);
            basket.Add(book5);
            basket.Add(book6);
            basket.Add(book7);
            basket.Add(book8);

            Price basketPrice = basket.GetBestBasketPrice();
            Price priceWithDiscount = new Price(53.20);

            basketPrice.Equals(priceWithDiscount).Should().BeTrue();
        }


        [TestMethod]
        public void Discount23BooksWith3setsOf5IdenticalsAnd2SetOf4Identicals()
        {
            Basket basket = new Basket();
            Book book1 = new Book("Harry Potter à l'école des sorciers");
            Book book2 = new Book("Harry Potter à l'école des sorciers");
            Book book3 = new Book("Harry Potter à l'école des sorciers");
            Book book4 = new Book("Harry Potter à l'école des sorciers");
            Book book5 = new Book("Harry Potter à l'école des sorciers");
            Book book6 = new Book("Harry Potter et la chambre des secrets");
            Book book7 = new Book("Harry Potter et la chambre des secrets");
            Book book8 = new Book("Harry Potter et la chambre des secrets");
            Book book9 = new Book("Harry Potter et la chambre des secrets");
            Book book10 = new Book("Harry Potter et la chambre des secrets");
            Book book11 = new Book("Harry Potter et le prisonnier d'Azkaban");
            Book book12 = new Book("Harry Potter et le prisonnier d'Azkaban");
            Book book13 = new Book("Harry Potter et le prisonnier d'Azkaban");
            Book book14 = new Book("Harry Potter et le prisonnier d'Azkaban");
            Book book15 = new Book("Harry Potter et la coupe de feu");
            Book book16 = new Book("Harry Potter et la coupe de feu");
            Book book17 = new Book("Harry Potter et la coupe de feu");
            Book book18 = new Book("Harry Potter et la coupe de feu");
            Book book19 = new Book("Harry Potter et la coupe de feu");
            Book book20 = new Book("Harry Potter et l\'ordre du Phoenix");
            Book book21 = new Book("Harry Potter et l\'ordre du Phoenix");
            Book book22 = new Book("Harry Potter et l\'ordre du Phoenix");
            Book book23 = new Book("Harry Potter et l\'ordre du Phoenix");
            basket.Add(book1);
            basket.Add(book2);
            basket.Add(book3);
            basket.Add(book4);
            basket.Add(book5);
            basket.Add(book6);
            basket.Add(book7);
            basket.Add(book8);
            basket.Add(book9);
            basket.Add(book10);
            basket.Add(book11);
            basket.Add(book12);
            basket.Add(book13);
            basket.Add(book14);
            basket.Add(book15);
            basket.Add(book16);
            basket.Add(book17);
            basket.Add(book18);
            basket.Add(book19);
            basket.Add(book20);
            basket.Add(book21);
            basket.Add(book22);
            basket.Add(book23);

            Price basketPrice = basket.GetBestBasketPrice();
            Price priceWithDiscount = new Price(3 * (8 * 5 * 0.75) + 2 * (8 * 4 * 0.8));

            basketPrice.Equals(priceWithDiscount).Should().BeTrue();
        }
    }
}
