using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace VitecMVProduktAPI.Models
{
    public class VitecMVProduktAPIContext : DbContext
    {
        public VitecMVProduktAPIContext (DbContextOptions<VitecMVProduktAPIContext> options)
            : base(options)
        {
        }

        public DbSet<VitecMVProduktAPI.Models.Products> Products { get; set; }
    }
}
