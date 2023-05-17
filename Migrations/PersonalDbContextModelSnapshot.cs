﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyResumeOfWPF;

#nullable disable

namespace MyResumeOfWPF.Migrations
{
    [DbContext(typeof(PersonalDbContext))]
    partial class PersonalDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.4");

            modelBuilder.Entity("MyResumeOfWPF.PDO.BasicinfoRow", b =>
                {
                    b.Property<int>("BasicinfoRowId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AddressColumn")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("AgeColumn")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("EmailColumn")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ExperienceColumn")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NameColumn")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PhonenumberColumn")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("BasicinfoRowId");

                    b.ToTable("BasicInfos");
                });

            modelBuilder.Entity("MyResumeOfWPF.PDO.EducationRow", b =>
                {
                    b.Property<int>("EducationRowId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("MajoyColumn")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PeriodColumn")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SchoolnameColumn")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("StageColumn")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("StartColumn")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("EducationRowId");

                    b.ToTable("Educations");
                });

            modelBuilder.Entity("MyResumeOfWPF.PDO.JobRow", b =>
                {
                    b.Property<int>("JobRowId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CompanyNameColumn")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("DutyColumn")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("InputColumn")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("OutputColumn")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TitleColumn")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("JobRowId");

                    b.ToTable("Jobs");
                });

            modelBuilder.Entity("MyResumeOfWPF.PDO.SkillRow", b =>
                {
                    b.Property<int>("SkillRowId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ComponentFourColumn")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ComponentOneColumn")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ComponentThreeColumn")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ComponentTwoColumn")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TopicColumn")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("SkillRowId");

                    b.ToTable("Skills");
                });
#pragma warning restore 612, 618
        }
    }
}