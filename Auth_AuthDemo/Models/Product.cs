using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Auth_AuthDemo.Models
{
    
    public class Product
    {
        
        public int ProductId { get; set; }
         
        public string Name { get; set; }
        public int QtyStock { get; set; }
        public DateTime DateOfPurchase { get; set; }

        public Supplier Supplier { get; set; }

    }
}