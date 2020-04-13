﻿// <auto-generated />
using EFCoreAssignment.Datalayer.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFCoreAssignment.Migrations
{
    [DbContext(typeof(OnlinehelpContext))]
    [Migration("20200413130502_test4")]
    partial class test4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EFCoreAssignment.Datalayer.Models.Assignment", b =>
                {
                    b.Property<int>("assignmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("courseId")
                        .HasColumnType("int");

                    b.HasKey("assignmentId");

                    b.ToTable("assignments");

                    b.HasData(
                        new
                        {
                            assignmentId = 1,
                            courseId = 1
                        },
                        new
                        {
                            assignmentId = 2,
                            courseId = 1
                        },
                        new
                        {
                            assignmentId = 3,
                            courseId = 2
                        },
                        new
                        {
                            assignmentId = 4,
                            courseId = 3
                        });
                });

            modelBuilder.Entity("EFCoreAssignment.Datalayer.Models.Course", b =>
                {
                    b.Property<int>("courseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("courseId");

                    b.ToTable("courses");
                });

            modelBuilder.Entity("EFCoreAssignment.Datalayer.Models.Exercise", b =>
                {
                    b.Property<int>("number")
                        .HasColumnType("int");

                    b.Property<int>("lecture")
                        .HasColumnType("int");

                    b.Property<int>("courseId")
                        .HasColumnType("int");

                    b.HasKey("number", "lecture");

                    b.ToTable("exercises");

                    b.HasData(
                        new
                        {
                            number = 1,
                            lecture = 1,
                            courseId = 1
                        },
                        new
                        {
                            number = 2,
                            lecture = 1,
                            courseId = 1
                        },
                        new
                        {
                            number = 1,
                            lecture = 4,
                            courseId = 2
                        },
                        new
                        {
                            number = 6,
                            lecture = 10,
                            courseId = 3
                        });
                });

            modelBuilder.Entity("EFCoreAssignment.Datalayer.Models.HelpRequest", b =>
                {
                    b.Property<int>("assignmentId")
                        .HasColumnType("int");

                    b.Property<string>("auId")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("helprequests");
                });

            modelBuilder.Entity("EFCoreAssignment.Datalayer.Models.HelpRequestExercise", b =>
                {
                    b.Property<string>("auId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("helpwhere")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("number")
                        .HasColumnType("int");

                    b.ToTable("helpRequestExercises");
                });

            modelBuilder.Entity("EFCoreAssignment.Datalayer.Models.Review", b =>
                {
                    b.Property<string>("Reviewtext")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("assignmentId")
                        .HasColumnType("int");

                    b.Property<string>("auId")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("reviews");
                });

            modelBuilder.Entity("EFCoreAssignment.Datalayer.Models.Student", b =>
                {
                    b.Property<string>("AuId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Semester")
                        .HasColumnType("int");

                    b.HasKey("AuId");

                    b.ToTable("students");

                    b.HasData(
                        new
                        {
                            AuId = "Au616638",
                            Name = "Bjarke Bjarkesen",
                            Semester = 4
                        },
                        new
                        {
                            AuId = "Au612638",
                            Name = "Morten Bjarkesen",
                            Semester = 3
                        },
                        new
                        {
                            AuId = "Au632638",
                            Name = "Bjarke Mortensen",
                            Semester = 2
                        },
                        new
                        {
                            AuId = "Au652638",
                            Name = "Morten Mortensen",
                            Semester = 4
                        },
                        new
                        {
                            AuId = "Au616621",
                            Name = "Oliver Madsen",
                            Semester = 4
                        },
                        new
                        {
                            AuId = "Au631321",
                            Name = "Mads Oliversen",
                            Semester = 5
                        },
                        new
                        {
                            AuId = "Au614328",
                            Name = "Mads Madsen",
                            Semester = 1
                        },
                        new
                        {
                            AuId = "Au612238",
                            Name = "Oliver Oliversen",
                            Semester = 4
                        });
                });

            modelBuilder.Entity("EFCoreAssignment.Datalayer.Models.StudentsInCourse", b =>
                {
                    b.Property<string>("auId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("courseId")
                        .HasColumnType("int");

                    b.ToTable("studentsInCourses");
                });

            modelBuilder.Entity("EFCoreAssignment.Datalayer.Models.Teacher", b =>
                {
                    b.Property<string>("AuId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("courseId")
                        .HasColumnType("int");

                    b.HasKey("AuId");

                    b.ToTable("teachers");
                });

            modelBuilder.Entity("EFCoreAssignment.Datalayer.Models.TeacherHelpsWith", b =>
                {
                    b.Property<int>("assignmentId")
                        .HasColumnType("int");

                    b.Property<string>("auId")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("teacherHelpsWiths");
                });

            modelBuilder.Entity("EFCoreAssignment.Datalayer.Models.TeacherHelpsWithExercise", b =>
                {
                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<string>("auId")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("teacherHelpsWithExercises");
                });
#pragma warning restore 612, 618
        }
    }
}
