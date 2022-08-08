using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ProjectServer.Model.Models
{
    public partial class ProjectLocalDBContext : DbContext
    {
        public ProjectLocalDBContext()
        {
        }

        public ProjectLocalDBContext(DbContextOptions<ProjectLocalDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\ProjectModels;Database=ProjectLocalDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.Token).HasMaxLength(50);
            });
           // new DbInitializer(modelBuilder).Seed();


            //OnModelCreatingPartial(modelBuilder);
            modelBuilder.Seed();

        }

        //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
