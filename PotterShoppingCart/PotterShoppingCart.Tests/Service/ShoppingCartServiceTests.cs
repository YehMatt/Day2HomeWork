using Microsoft.VisualStudio.TestTools.UnitTesting;
using PotterShoppingCart.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExpectedObjects;
using PotterShoppingCart.Model;

namespace PotterShoppingCart.Service.Tests
{
    [TestClass()]
    public class ShoppingCartServiceTests
    {
        Customer customer;
        Order order;

        public ShoppingCartServiceTests()
        {
            customer = new Customer {ID=1234, Name = "Matt" };
            order = new Order();
            order.Customer = customer;
        }

        [TestMethod()]
        public void CalculateOrderNetAmountTest_第一集買了一本_其他都沒買_價格應為100元()
        {
            List<Book> books = new List<Book> {
                                        new Book {ID = 1, Name = "哈利波特1", Price = 100 }                                        
            };

            order.Books = books;

            var target = new ShoppingCartService();
            var expected = 100;
            var actual = target.CalculateOrderNetAmount(order);

            Assert.AreEqual(expected, actual);            
        }
    }
}