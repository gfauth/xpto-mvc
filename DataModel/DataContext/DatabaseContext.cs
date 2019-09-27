using DataModel.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.DataContext
{
    public class DatabaseContext : DbContext
    {

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }
        public DbSet<UserModel> Users { get; set; }
        public DbSet<MountModel> Mounts { get; set; }
        public DbSet<HitTypeModel> HitTypes { get; set; }
        public DbSet<ExceptionModel> Errors { get; set; }
        public DbSet<MountProcateModel> MountProcates { get; set; }
        public DbSet<SpecialAbilityModel> SpecialAbilities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserModel>().ToTable("Users");
            modelBuilder.Entity<MountModel>().ToTable("Mounts");
            modelBuilder.Entity<HitTypeModel>().ToTable("HitTipes");
            modelBuilder.Entity<MountProcateModel>().ToTable("MountProcates");
            modelBuilder.Entity<SpecialAbilityModel>().ToTable("SpecialAbilities");

            modelBuilder.Entity<UserModel>().HasKey(x => x.Id);
            modelBuilder.Entity<MountModel>().HasKey(x => x.Id);
            modelBuilder.Entity<HitTypeModel>().HasKey(x => x.Id);
            modelBuilder.Entity<MountProcateModel>().HasKey(x => x.Id);
            modelBuilder.Entity<SpecialAbilityModel>().HasKey(x => x.Id);

            modelBuilder.Entity<UserModel>().Property(x => x.Name).IsRequired();
            modelBuilder.Entity<UserModel>().Property(x => x.Email).IsRequired();
            modelBuilder.Entity<UserModel>().Property(x => x.Password).IsRequired();
            modelBuilder.Entity<UserModel>().Property(x => x.Email).IsRequired();
            modelBuilder.Entity<UserModel>().Property(x => x.CreatedAt).HasDefaultValueSql("getdate()");
            modelBuilder.Entity<UserModel>().Property(x => x.UpdatedAt).HasDefaultValueSql("getdate()").HasValueGenerator(System.Type.GetType("DateTime"));

            modelBuilder.Entity<HitTypeModel>().Property(x => x.Description).IsRequired();

            modelBuilder.Entity<ExceptionModel>().ToTable("ExceptionLog");
        }
    }
}
