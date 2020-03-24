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
    [Migration("20200324143324_test1")]
    partial class test1
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

                    b.Property<int>("helprequestId")
                        .HasColumnType("int");

                    b.Property<int>("reviewId")
                        .HasColumnType("int");

                    b.Property<int>("studentId")
                        .HasColumnType("int");

                    b.Property<int>("teacherId")
                        .HasColumnType("int");

                    b.HasKey("assignmentId");

                    b.ToTable("assignments");
                });

            modelBuilder.Entity("EFCoreAssignment.Datalayer.Models.Course", b =>
                {
                    b.Property<int>("courseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("assignmentId")
                        .HasColumnType("int");

                    b.Property<int>("studentId")
                        .HasColumnType("int");

                    b.Property<int>("teacherId")
                        .HasColumnType("int");

                    b.HasKey("courseId");

                    b.ToTable("courses");
                });

            modelBuilder.Entity("EFCoreAssignment.Datalayer.Models.Exercise", b =>
                {
                    b.Property<int>("exerciseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("helprequestId")
                        .HasColumnType("int");

                    b.Property<int>("helpwhere")
                        .HasColumnType("int");

                    b.Property<int>("lecture")
                        .HasColumnType("int");

                    b.Property<int>("number")
                        .HasColumnType("int");

                    b.Property<int>("studentId")
                        .HasColumnType("int");

                    b.Property<int>("teacherId")
                        .HasColumnType("int");

                    b.HasKey("exerciseId");

                    b.ToTable("exercises");
                });

            modelBuilder.Entity("EFCoreAssignment.Datalayer.Models.HelpRequest", b =>
                {
                    b.Property<int>("helprequestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("assignmentId")
                        .HasColumnType("int");

                    b.Property<int>("exerciseId")
                        .HasColumnType("int");

                    b.Property<int>("studentId")
                        .HasColumnType("int");

                    b.HasKey("helprequestId");

                    b.ToTable("helprequests");
                });

            modelBuilder.Entity("EFCoreAssignment.Datalayer.Models.Review", b =>
                {
                    b.Property<int>("reviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Reviewtext")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("assignmentId")
                        .HasColumnType("int");

                    b.Property<int>("studentId")
                        .HasColumnType("int");

                    b.HasKey("reviewId");

                    b.ToTable("reviews");
                });

            modelBuilder.Entity("EFCoreAssignment.Datalayer.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AuId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("assignmentId")
                        .HasColumnType("int");

                    b.Property<int>("courseId")
                        .HasColumnType("int");

                    b.Property<int>("exerciseId")
                        .HasColumnType("int");

                    b.Property<int>("reviewId")
                        .HasColumnType("int");

                    b.HasKey("StudentId");

                    b.ToTable("students");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            AuId = "au616639",
                            Name = "Morten Dalsgaard",
                            assignmentId = 0,
                            courseId = 0,
                            exerciseId = 0,
                            reviewId = 0
                        });
                });

            modelBuilder.Entity("EFCoreAssignment.Datalayer.Models.Teacher", b =>
                {
                    b.Property<int>("teacherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AuId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("assignmentId")
                        .HasColumnType("int");

                    b.Property<int>("courseId")
                        .HasColumnType("int");

                    b.Property<int>("exerciseId")
                        .HasColumnType("int");

                    b.HasKey("teacherId");

                    b.ToTable("teachers");
                });
#pragma warning restore 612, 618
        }
    }
}
