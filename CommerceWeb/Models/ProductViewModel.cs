﻿using CommerceDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CommerceWeb.Models
{
    public class ProductViewModel
    {
        public ProductViewModel()
        {
        }

        public ProductViewModel(DiscountedProduct product)
        {
            this.Name = product.Name;
            this.UnitPrice = product.UnitPrice;
        }

        public string Name { get; set; }

        public string SummaryText
        {
            get
            {
                return string.Format("{0} ({1:C})",
                    this.Name, this.UnitPrice);
            }
        }

        public decimal UnitPrice { get; set; }
    }
}