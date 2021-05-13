using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Proxies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApp.Entities
{
    public class MagazineContext:DbContext
    {
        public DbSet<UserInfo> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Good> Goods { get; set; }

        private IWebHostEnvironment webHostEnvironment;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        public MagazineContext(DbContextOptions<MagazineContext> options)
        : base(options)
        {
            Database.EnsureCreated();
        }
      
    }
}
