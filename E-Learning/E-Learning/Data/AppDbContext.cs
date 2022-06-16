﻿using E_Learning.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Learning.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountClass> AccountClasses { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Score> Scoreboards { get; set; }
        public DbSet<Semester> Semesters { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Test> Tests { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountClass>()
                .HasKey(ac => new { ac.AccountId, ac.ClassId });
            modelBuilder.Entity<AccountClass>()
                .HasOne(a => a.Account)
                .WithMany(ac => ac.AccountClasses)
                .HasForeignKey(a => a.AccountId);
            modelBuilder.Entity<AccountClass>()
                .HasOne(c => c.Class)
                .WithMany(ac => ac.AccountClasses)
                .HasForeignKey(c => c.ClassId);
        }
    }
}

