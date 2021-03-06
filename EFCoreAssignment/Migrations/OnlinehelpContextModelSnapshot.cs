﻿// <auto-generated />
using EFCoreAssignment.Datalayer.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFCoreAssignment.Migrations
{
    [DbContext(typeof(OnlinehelpContext))]
    partial class OnlinehelpContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.HasData(
                        new
                        {
                            courseId = 1,
                            Name = "DAB"
                        },
                        new
                        {
                            courseId = 2,
                            Name = "GFV"
                        },
                        new
                        {
                            courseId = 3,
                            Name = "ISU"
                        });
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
                    b.Property<string>("auId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("assignmentId")
                        .HasColumnType("int");

                    b.HasKey("auId", "assignmentId");

                    b.ToTable("helprequests");

                    b.HasData(
                        new
                        {
                            auId = "Au616638",
                            assignmentId = 1
                        },
                        new
                        {
                            auId = "Au616638",
                            assignmentId = 2
                        },
                        new
                        {
                            auId = "Au612638",
                            assignmentId = 4
                        });
                });

            modelBuilder.Entity("EFCoreAssignment.Datalayer.Models.HelpRequestExercise", b =>
                {
                    b.Property<string>("auId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("number")
                        .HasColumnType("int");

                    b.Property<string>("helpwhere")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("auId", "number");

                    b.ToTable("helpRequestExercises");

                    b.HasData(
                        new
                        {
                            auId = "Au614328",
                            number = 2,
                            helpwhere = "Bord 20"
                        },
                        new
                        {
                            auId = "Au612238",
                            number = 1,
                            helpwhere = "Bord 22"
                        },
                        new
                        {
                            auId = "Au614328",
                            number = 1,
                            helpwhere = "Bord 21"
                        },
                        new
                        {
                            auId = "Au616638",
                            number = 6,
                            helpwhere = "Bord 23"
                        });
                });

            modelBuilder.Entity("EFCoreAssignment.Datalayer.Models.Review", b =>
                {
                    b.Property<string>("auId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("assignmentId")
                        .HasColumnType("int");

                    b.Property<string>("Reviewtext")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("auId", "assignmentId");

                    b.ToTable("reviews");

                    b.HasData(
                        new
                        {
                            auId = "Au616621",
                            assignmentId = 1,
                            Reviewtext = "Fint nok"
                        },
                        new
                        {
                            auId = "Au616621",
                            assignmentId = 2,
                            Reviewtext = "Helt ok"
                        },
                        new
                        {
                            auId = "Au616621",
                            assignmentId = 3,
                            Reviewtext = "Meget fint"
                        });
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
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("courseId")
                        .HasColumnType("int");

                    b.HasKey("auId", "courseId");

                    b.ToTable("studentsInCourses");

                    b.HasData(
                        new
                        {
                            auId = "Au616638",
                            courseId = 1
                        },
                        new
                        {
                            auId = "Au616621",
                            courseId = 1
                        },
                        new
                        {
                            auId = "Au616621",
                            courseId = 3
                        },
                        new
                        {
                            auId = "Au616638",
                            courseId = 3
                        },
                        new
                        {
                            auId = "Au616638",
                            courseId = 2
                        },
                        new
                        {
                            auId = "Au616621",
                            courseId = 2
                        },
                        new
                        {
                            auId = "Au631321",
                            courseId = 3
                        },
                        new
                        {
                            auId = "Au612638",
                            courseId = 2
                        },
                        new
                        {
                            auId = "Au612638",
                            courseId = 3
                        },
                        new
                        {
                            auId = "Au612638",
                            courseId = 1
                        });
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

                    b.HasData(
                        new
                        {
                            AuId = "Au616639",
                            Name = "Morten Bobsen",
                            courseId = 1
                        },
                        new
                        {
                            AuId = "Au620433",
                            Name = "Kaj Løkke",
                            courseId = 1
                        },
                        new
                        {
                            AuId = "Au504234",
                            Name = "Kasper Kaj",
                            courseId = 2
                        },
                        new
                        {
                            AuId = "Au420322",
                            Name = "Mads Madsen",
                            courseId = 2
                        },
                        new
                        {
                            AuId = "Au302420",
                            Name = "Oliver Escobar",
                            courseId = 3
                        });
                });

            modelBuilder.Entity("EFCoreAssignment.Datalayer.Models.TeacherHelpsWith", b =>
                {
                    b.Property<string>("auId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("assignmentId")
                        .HasColumnType("int");

                    b.HasKey("auId", "assignmentId");

                    b.ToTable("teacherHelpsWiths");

                    b.HasData(
                        new
                        {
                            auId = "Au620433",
                            assignmentId = 1
                        },
                        new
                        {
                            auId = "Au504234",
                            assignmentId = 2
                        },
                        new
                        {
                            auId = "Au420322",
                            assignmentId = 3
                        },
                        new
                        {
                            auId = "Au302420",
                            assignmentId = 4
                        });
                });

            modelBuilder.Entity("EFCoreAssignment.Datalayer.Models.TeacherHelpsWithExercise", b =>
                {
                    b.Property<string>("auId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("number")
                        .HasColumnType("int");

                    b.HasKey("auId", "number");

                    b.ToTable("teacherHelpsWithExercises");

                    b.HasData(
                        new
                        {
                            auId = "Au420322",
                            number = 1
                        },
                        new
                        {
                            auId = "Au616639",
                            number = 2
                        },
                        new
                        {
                            auId = "Au420322",
                            number = 2
                        },
                        new
                        {
                            auId = "Au620433",
                            number = 6
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
