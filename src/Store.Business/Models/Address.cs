using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Business.Models
{
    public class Address: Entity
    {
        public Guid SupplierId { get; set; }

        public string Street { get; set; }
        public string Number { get; set; }
        public string Complement { get; set; }
        public string ZipCode { get; set; }
        public string Neighborhood { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public bool Active { get; set; }
        public Supplier Supplier { get; set; }


    }
}
