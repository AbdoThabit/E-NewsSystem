using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace D3.Models
{
    public class NewsContext : DbContext
    {
        public DbSet<Catalog> catalogs { get; set; }
        public DbSet<New> News { get; set; }

        public DbSet<Author> Authors { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=dotnetg1;Integrated Security=True;TrustServerCertificate=True");
        }
    }
}
