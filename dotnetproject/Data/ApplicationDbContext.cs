using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace dotnetproject.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
}

            //Updated for my table Srujana
            //Update your tables
            public DbSet<Slot> Slots{get; set;}
            public DbSet<Student> Students{get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            base.OnModelCreating(modelBuilder);
            
          //Update your tables
            modelBuilder.Entity<Slot>().ToTable("Slot");
            modelBuilder.Entity<Student>().ToTable("Student");

        }
        }
    }

