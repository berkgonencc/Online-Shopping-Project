using Microsoft.EntityFrameworkCore;
using MiniShopAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShopAPI.Persistence.Contexts
{
    public class MiniShopAPIDbContext : DbContext
    {
        public MiniShopAPIDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }

    }
}
