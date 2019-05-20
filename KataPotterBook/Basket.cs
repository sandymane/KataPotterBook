using System;
using System.Collections.Generic;
using System.Linq;

namespace KataPotterBook
{
    public class Basket
    {
        private readonly List<Book> _books;

        public Basket()
        {
            _books = new List<Book>();
        }

        public int GetNumberOfBooks()
        {
            return _books.Count;
        }

        public void Add(Book book)
        {
            _books.Add(book);
        }

        public Price GetPrice()
        {
            List<Price> bookPrices = _books.Select(b => b.Price).ToList();

            return bookPrices.Aggregate(func: Total);
        }

        public Price ApplyDiscount()
        {
            List<int> numberOfBookGroupByName = _books.GroupBy(b => b.Name)
               .Select(group => group.Count()).ToList();
            double total = 0;
            double discount = 0;
            int numberOfDifferentBook = numberOfBookGroupByName.Count();
           
            while (BookShop.Discounts.TryGetValue(numberOfDifferentBook, out discount))
            {
                int numberOfBook = numberOfBookGroupByName.Sum();
                total += numberOfDifferentBook * BookShop.BookPrice - (discount * numberOfDifferentBook * BookShop.BookPrice);

                for (int i = 0; i < numberOfBookGroupByName.Count; ++i)
                {
                    numberOfBookGroupByName[i] = Math.Max(0, numberOfBookGroupByName[i] - 1);
                }
                numberOfBookGroupByName.RemoveAll(b => b == 0);
                numberOfBook = numberOfBookGroupByName.Sum();
                numberOfDifferentBook = numberOfBookGroupByName.Count();
            }

            total += numberOfBookGroupByName.Sum() * BookShop.BookPrice;

            return new Price(total);
        }

        public Price GetBestBasketPrice()
        {
            List<Price> basketPrices = new List<Price>();

            List<int> numberOfBookGroupByName = _books.GroupBy(b => b.Name)
               .Select(group => group.Count()).ToList();

            int numberOfDifferentBook = numberOfBookGroupByName.Count();
            while(numberOfDifferentBook > 1)
            {
                basketPrices.Add(GetBasketPrice(numberOfDifferentBook));
                numberOfDifferentBook--;
            }

            return basketPrices.OrderBy(b => b.Value).FirstOrDefault();
        }

        public Price GetBasketPrice(int numberOfDifferentBook)
        {
            List<int> numberOfBookGroupByName = _books.GroupBy(b => b.Name)
               .Select(group => group.Count()).ToList();
            double total = 0;
            double discount = 0;

            while (BookShop.Discounts.TryGetValue(numberOfDifferentBook, out discount))
            {
                int numberOfBook = numberOfBookGroupByName.Sum();
                total += numberOfDifferentBook * BookShop.BookPrice - (discount * numberOfDifferentBook * BookShop.BookPrice);
                int numberOfBookInsSet = 0;
                while (numberOfBookInsSet < numberOfDifferentBook)
                {
                    numberOfBookGroupByName[numberOfBookInsSet] = Math.Max(0, numberOfBookGroupByName[numberOfBookInsSet] - 1);
                    numberOfBookInsSet++;
                }

                numberOfBookGroupByName.RemoveAll(b => b == 0);
                numberOfBook = numberOfBookGroupByName.Sum();
                numberOfDifferentBook = numberOfBookGroupByName.Count();
            }

            total += numberOfBookGroupByName.Sum() * BookShop.BookPrice;

            return new Price(total);
        }

  
        private static Price Total(Price price1, Price price2)
        {
            return price1.Add(price2);
        }

    }
}
