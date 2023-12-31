﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OgrenciTakipSistemi.Entities.Authentication;
using OgrenciTakipSistemi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciTakipSistemi.DAL.Contexts
{
    public class SqlDbContext: IdentityDbContext<AppUser, AppRole, string>
    {
        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<Danisman> Danismanlar { get; set;}

        public SqlDbContext()
        {

        }
        public SqlDbContext(DbContextOptions<SqlDbContext> options)
          : base(options)
       {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           base.OnConfiguring(optionsBuilder);
           optionsBuilder.UseSqlServer("Server=localhost;Database=OgrenciTakipSistemi;Trusted_Connection=True;TrustServerCertificate=true");
       }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }
}
