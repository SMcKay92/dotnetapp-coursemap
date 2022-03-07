﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace nscccoursemap_SMcKay92.Migrations
{
    [DbContext(typeof(NSCCCourseMapContext))]
    partial class NSCCCourseMapContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("NSCCCourseMap.Models.AcademicYear", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("Title")
                        .IsUnique();

                    b.ToTable("AcademicYears");
                });

            modelBuilder.Entity("NSCCCourseMap.Models.AdvisingAssignment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("DiplomaYearSectionId")
                        .HasColumnType("int");

                    b.Property<int?>("InstructorId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DiplomaYearSectionId")
                        .IsUnique();

                    b.HasIndex("InstructorId", "DiplomaYearSectionId")
                        .IsUnique();

                    b.ToTable("AdvisingAssignments");
                });

            modelBuilder.Entity("NSCCCourseMap.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CourseCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("CourseCode")
                        .IsUnique();

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("NSCCCourseMap.Models.CourseOffering", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("DiplomaYearSectionId")
                        .HasColumnType("int");

                    b.Property<int?>("InstructorId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDirectedElective")
                        .HasColumnType("bit");

                    b.Property<int>("SemesterId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DiplomaYearSectionId");

                    b.HasIndex("InstructorId");

                    b.HasIndex("SemesterId");

                    b.HasIndex("CourseId", "DiplomaYearSectionId", "SemesterId")
                        .IsUnique();

                    b.ToTable("CourseOfferings");
                });

            modelBuilder.Entity("NSCCCourseMap.Models.CoursePrerequisite", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("PrerequisiteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PrerequisiteId");

                    b.HasIndex("CourseId", "PrerequisiteId")
                        .IsUnique();

                    b.ToTable("CoursePrerequisites");
                });

            modelBuilder.Entity("NSCCCourseMap.Models.Diploma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Title")
                        .IsUnique();

                    b.ToTable("Diplomas");
                });

            modelBuilder.Entity("NSCCCourseMap.Models.DiplomaYear", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("DiplomaId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("DiplomaId");

                    b.HasIndex("Title", "DiplomaId")
                        .IsUnique();

                    b.ToTable("DiplomaYears");
                });

            modelBuilder.Entity("NSCCCourseMap.Models.DiplomaYearSection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AcademicYearId")
                        .HasColumnType("int");

                    b.Property<int>("DiplomaYearId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("AcademicYearId");

                    b.HasIndex("DiplomaYearId");

                    b.HasIndex("Title", "DiplomaYearId", "AcademicYearId")
                        .IsUnique();

                    b.ToTable("DiplomaYearSections");
                });

            modelBuilder.Entity("NSCCCourseMap.Models.Instructor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Instructors");
                });

            modelBuilder.Entity("NSCCCourseMap.Models.Semester", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AcademicYearId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AcademicYearId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Semesters");
                });

            modelBuilder.Entity("NSCCCourseMap.Models.AdvisingAssignment", b =>
                {
                    b.HasOne("NSCCCourseMap.Models.DiplomaYearSection", "DiplomaYearSection")
                        .WithOne("AdvisingAssignment")
                        .HasForeignKey("NSCCCourseMap.Models.AdvisingAssignment", "DiplomaYearSectionId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("NSCCCourseMap.Models.Instructor", "Instructor")
                        .WithMany("AdvisingAssignments")
                        .HasForeignKey("InstructorId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("DiplomaYearSection");

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("NSCCCourseMap.Models.CourseOffering", b =>
                {
                    b.HasOne("NSCCCourseMap.Models.Course", "Course")
                        .WithMany("CourseOfferings")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("NSCCCourseMap.Models.DiplomaYearSection", "DiplomaYearSection")
                        .WithMany("CourseOfferings")
                        .HasForeignKey("DiplomaYearSectionId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("NSCCCourseMap.Models.Instructor", "Instructor")
                        .WithMany("CourseOfferings")
                        .HasForeignKey("InstructorId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("NSCCCourseMap.Models.Semester", "Semester")
                        .WithMany("CourseOfferings")
                        .HasForeignKey("SemesterId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("DiplomaYearSection");

                    b.Navigation("Instructor");

                    b.Navigation("Semester");
                });

            modelBuilder.Entity("NSCCCourseMap.Models.CoursePrerequisite", b =>
                {
                    b.HasOne("NSCCCourseMap.Models.Course", "Course")
                        .WithMany("Prerequisites")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("NSCCCourseMap.Models.Course", "Prerequisite")
                        .WithMany("IsPrerequisiteFor")
                        .HasForeignKey("PrerequisiteId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Prerequisite");
                });

            modelBuilder.Entity("NSCCCourseMap.Models.DiplomaYear", b =>
                {
                    b.HasOne("NSCCCourseMap.Models.Diploma", "Diploma")
                        .WithMany("DiplomaYears")
                        .HasForeignKey("DiplomaId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Diploma");
                });

            modelBuilder.Entity("NSCCCourseMap.Models.DiplomaYearSection", b =>
                {
                    b.HasOne("NSCCCourseMap.Models.AcademicYear", "AcademicYear")
                        .WithMany("DiplomaYearSections")
                        .HasForeignKey("AcademicYearId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("NSCCCourseMap.Models.DiplomaYear", "DiplomaYear")
                        .WithMany("DiplomaYearSections")
                        .HasForeignKey("DiplomaYearId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("AcademicYear");

                    b.Navigation("DiplomaYear");
                });

            modelBuilder.Entity("NSCCCourseMap.Models.Semester", b =>
                {
                    b.HasOne("NSCCCourseMap.Models.AcademicYear", "AcademicYear")
                        .WithMany("Semesters")
                        .HasForeignKey("AcademicYearId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("AcademicYear");
                });

            modelBuilder.Entity("NSCCCourseMap.Models.AcademicYear", b =>
                {
                    b.Navigation("DiplomaYearSections");

                    b.Navigation("Semesters");
                });

            modelBuilder.Entity("NSCCCourseMap.Models.Course", b =>
                {
                    b.Navigation("CourseOfferings");

                    b.Navigation("IsPrerequisiteFor");

                    b.Navigation("Prerequisites");
                });

            modelBuilder.Entity("NSCCCourseMap.Models.Diploma", b =>
                {
                    b.Navigation("DiplomaYears");
                });

            modelBuilder.Entity("NSCCCourseMap.Models.DiplomaYear", b =>
                {
                    b.Navigation("DiplomaYearSections");
                });

            modelBuilder.Entity("NSCCCourseMap.Models.DiplomaYearSection", b =>
                {
                    b.Navigation("AdvisingAssignment");

                    b.Navigation("CourseOfferings");
                });

            modelBuilder.Entity("NSCCCourseMap.Models.Instructor", b =>
                {
                    b.Navigation("AdvisingAssignments");

                    b.Navigation("CourseOfferings");
                });

            modelBuilder.Entity("NSCCCourseMap.Models.Semester", b =>
                {
                    b.Navigation("CourseOfferings");
                });
#pragma warning restore 612, 618
        }
    }
}