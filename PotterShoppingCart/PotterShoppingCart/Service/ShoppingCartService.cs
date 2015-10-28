using PotterShoppingCart.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PotterShoppingCart.Service
{
    public class ShoppingCartService
    {
        public ShoppingCartService()
        {
                
        }

        //將購買書籍加入購物車
        public int AddBooks(List<Book> books) {

            int booksCount = 0;



            return booksCount;
        }

        public int CalculateOrderNetAmount(Order order)
        {
            double netAmount = 0;

            var p = from book in order.Books
                    group book by new { book.ID, book.Price } into g
                    select new Book { ID = g.Key.ID, Price = g.Key.Price };

            netAmount += CalculateDiscount(p.ToList());

            return 0;
        }

        private double CalculateDiscount(List<Book> _books)
        {
            double discountAmount = _books.Sum(item => item.Price);

            switch (_books.Count)
            {
                case 1:
                    discountAmount *= 1.0;
                    break;
                case 2:
                    discountAmount *= 0.95;
                    break;
                
            }
            return discountAmount;
        }
    }
}  