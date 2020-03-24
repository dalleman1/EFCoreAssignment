﻿using EFCoreAssignment.Datalayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreAssignment.Datalayer.Configurations
{
    public class OnlinehelpContext : DbContext
    {
        public DbSet<Assignment> assignments  { get; set; }
        public DbSet<Course> courses { get; set; }
        public DbSet<Exercise> exercises { get; set; }
        public DbSet<HelpRequest> helprequests { get; set; }
        public DbSet<Review> reviews { get; set; }
        public DbSet<Student> students { get; set; }
        public DbSet<Teacher> teachers { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\mongl\\source\\repos\\EFCoreAssignment\\EFCoreAssignment\\Assignment2.mdf;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Static data for testing purposes
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new ExerciseConfiguration());
        }
    }
}
