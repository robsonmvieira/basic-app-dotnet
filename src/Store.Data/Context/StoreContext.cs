using Microsoft.EntityFrameworkCore;
using Store.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Data.Context
{
    class StoreContext: DbContext
    {
        public StoreContext(DbContextOptions options): base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
    }
}
