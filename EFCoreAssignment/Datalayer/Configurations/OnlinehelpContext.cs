using EFCoreAssignment.Datalayer.Models;
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
        public DbSet<HelpRequestExercise> helpRequestExercises { get; set; }
        public DbSet<StudentsInCourse> studentsInCourses { get; set; }
        public DbSet<TeacherHelpsWith> teacherHelpsWiths { get; set; }
        public DbSet<TeacherHelpsWithExercise> teacherHelpsWithExercises { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EfcoreAssignment;Integrated Security=True");
            optionsBuilder.EnableSensitiveDataLogging(true);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Static data for testing purposes
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new ExerciseConfiguration());
            modelBuilder.ApplyConfiguration(new AssignmentConfiguration());
            modelBuilder.ApplyConfiguration(new CourseConfiguration());
            modelBuilder.ApplyConfiguration(new HelpRequestConfiguration());
            modelBuilder.ApplyConfiguration(new HelpRequestExerciseConfiguration());
            modelBuilder.ApplyConfiguration(new ReviewConfiguration());
            modelBuilder.ApplyConfiguration(new StudentInCourseConfiguration());
            modelBuilder.ApplyConfiguration(new TeacherConfiguration());
            modelBuilder.ApplyConfiguration(new TeacherHelpsWithConfiguration());
            modelBuilder.ApplyConfiguration(new TeacherHelpsWithExerciseConfiguration());
         
            //Composite key for Exercises
            modelBuilder.Entity<Exercise>().HasKey(table => new { table.number, table.lecture });

            modelBuilder.Entity<HelpRequest>().HasKey(h => new { h.auId, h.assignmentId });
            modelBuilder.Entity<HelpRequestExercise>().HasKey(h => new { h.auId, h.number });
            modelBuilder.Entity<Review>().HasKey(h => new { h.auId, h.assignmentId });
            modelBuilder.Entity<StudentsInCourse>().HasKey(h => new { h.auId, h.courseId });
            modelBuilder.Entity<TeacherHelpsWith>().HasKey(h => new { h.auId, h.assignmentId });
            modelBuilder.Entity<TeacherHelpsWithExercise>().HasKey(h => new { h.auId, h.number });

        }
    }
}
