// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SistemaWebMVC.Data;

namespace SistemaWebMVC.Migrations
{
    [DbContext(typeof(SistemaWebMVCContext))]
    [Migration("20210912205415_DepartmentForeignKey")]
    partial class DepartmentForeignKey
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SistemaWebMVC.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("SistemaWebMVC.Models.Trainee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DepartmentId");

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.Property<DateTime>("Nascimento");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Trainee");
                });

            modelBuilder.Entity("SistemaWebMVC.Models.TraineesRecords", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Data");

                    b.Property<int>("Status");

                    b.Property<int?>("TraineeId");

                    b.HasKey("Id");

                    b.HasIndex("TraineeId");

                    b.ToTable("TraineesRecords");
                });

            modelBuilder.Entity("SistemaWebMVC.Models.Trainee", b =>
                {
                    b.HasOne("SistemaWebMVC.Models.Department", "Department")
                        .WithMany("Trainees")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SistemaWebMVC.Models.TraineesRecords", b =>
                {
                    b.HasOne("SistemaWebMVC.Models.Trainee", "Trainee")
                        .WithMany("Trainees")
                        .HasForeignKey("TraineeId");
                });
#pragma warning restore 612, 618
        }
    }
}
