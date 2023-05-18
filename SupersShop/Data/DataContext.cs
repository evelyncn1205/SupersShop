using Microsoft.EntityFrameworkCore;
using SuperShop.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperShop.Data
{
    public class DataContext : DbContext
    {
                
        public DbSet<Product> Products { get; set; } // propriedade que liga a tabela product

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        
    }
}
