using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using KataPotterBook;

namespace KataPotterBookTest
{
    [TestClass]
    public class BookTest
    {
        [TestMethod]
        public void OneBookPriceShouldBe8()
        {
            Book book = new Book("Harry Potter à l'école des sorciers");
            Price bookPrice = new Price(BookShop.BookPrice);
            book.Price.Equals(bookPrice).Should().BeTrue();
        }

    }
}
