﻿using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class Product
    {
        public int Id { set; get; }

        public decimal Price { set; get; }
        public int OriginalPrice { set; get; }
        public int Stock { set; get; }
        public int ViewCount { set; get; }
        public DateTime DateCreate { set; get; }

        public List<ProductInCategory> ProductInCategories { set; get; }

        public List<OrderDetail> OrderDetails { set; get; }
    }
}
