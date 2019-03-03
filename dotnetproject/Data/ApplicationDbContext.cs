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
             //Updated for my table Poojitha
            public DbSet<Student> Students{get; set;}
            public DbSet<Credit> Credits{get; set; }
            //Updated for my table Himabindu
            public Dbset<Degree> Degrees{get; set;}
            public Dbset<DegreePlan> DegreePlans{get; set;}
            

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            base.OnModelCreating(modelBuilder);
            
          //Update your tables
            modelBuilder.Entity<Slot>().ToTable("Slot");
            modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<Credit>().ToTable("Credit");
            modelBuilder.Entity<Degree>().ToTable("Degree");
            modelBuilder.Entity<DegreePlan>().ToTable("DegreePlan");

        }
        }
    }

