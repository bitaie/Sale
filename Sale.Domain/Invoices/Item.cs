﻿using Sale.Domain.BaseEntities;
using Sale.Domain.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sale.Domain.Invoices
{
    public class Item :BaseEntity
    {

        public int InvoiceId { get; set; }
        public Invoice Invoice { get; set; }
        [Display(Name = "Product")]
        public int ProductId { get; set; }

        public Product Product{ get; set; }

        public int Quantity { get; set; }
        public int Price { get; set; }

    }
}
