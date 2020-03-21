﻿using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Application.Catalog.Products.Dtos.Manage
{
    public class ProductUpdateRequest
    {
        public int Id { get; set; }

        public decimal Price { set; get; }
        public int OriginalPrice { set; get; }
        public int Stock { set; get; }
        public int ViewCount { set; get; }
        public DateTime DateCreate { set; get; }

        public string Name { set; get; }
        public string Description { set; get; }
        public string Details { set; get; }
        public string SeoDescription { set; get; }
        public string SeoTitle { set; get; }

        public string SeoAlias { get; set; }
        public string LanguageId { set; get; }


    }



}
