using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using REQGEST.Areas.Identity.Data;
using REQGEST.Models;

namespace REQGEST.Data
{
    public class ReqGestDbContext : IdentityDbContext<AplicationUser>
    {
        public ReqGestDbContext(DbContextOptions<ReqGestDbContext> options)
            : base(options)
        {
        }


        public DbSet<Item> Items { get; set; }

        public DbSet<Fornecedor> Fornecedores {get; set; }
        
        public DbSet<Requisicao> Requisicao { get; set; }

        public DbSet<Stock> Stocks { get; set; }

        //    protected override void OnModelCreating(ModelBuilder builder)
        //    {
        //        base.OnModelCreating(builder);
        //        // Customize the ASP.NET Identity model and override the defaults if needed.
        //        // For example, you can rename the ASP.NET Identity table names and more.
        //        // Add your customizations after calling base.OnModelCreating(builder);
        //    }
    }
}
