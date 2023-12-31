﻿using AugularAuthAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AugularAuthAPI.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<User> Users {get;  set;}

        public DbSet<ConsumerRegistrationUsers> ConsumerRegistrationUsers { get; set;}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ConsumerRegistrationUsers>().ToTable("ConsumerRegistrationUsers");
            modelBuilder.Entity<User>().ToTable("users");

            //base.OnModelCreating(modelBuilder);  
        }
    }
}
