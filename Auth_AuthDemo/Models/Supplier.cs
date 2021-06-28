using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Auth_AuthDemo.Models
{
    public enum StateName { Delhi, Calcutta, HP, MP };
    public class Supplier
    {
        public int SupplierId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public StateName State { get; set; }
        public ICollection<Product> Products { get; set; }

    }
}