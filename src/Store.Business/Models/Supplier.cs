using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Business.Models
{
    public class Supplier : Entity
    {
        public string Name { get; set; }
        public string Doc { get; set; }
        public TypeSupplier TypeSupplier { get; set; }
        public Address Address { get; set; }
        public bool Active { get; set; }

        public IEnumerable<Product> Products { get; set; }
    }

    
}
