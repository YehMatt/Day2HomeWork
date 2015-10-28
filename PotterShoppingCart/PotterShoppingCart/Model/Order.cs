using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PotterShoppingCart.Model
{
    public class Order
    {
        public Customer Customer { get; set; }

        public List<Book> Books { get; set; }

        /// <summary>
        /// 總交易金額
        /// </summary>
        public int TotalAmount { get; set; }

        /// <summary>
        /// 折扣金額
        /// </summary>
        public int Discount { get; set; }

        /// <summary>
        /// 實際收款金額
        /// </summary>
        public int NetAmount { get; set; }
    }
}