﻿// <auto-generated />
using System;
using ConsoleApp1.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ConsoleApp1.Migrations
{
    [DbContext(typeof(WorkContext))]
    [Migration("20210827132908_MigrationWithTpt")]
    partial class MigrationWithTpt
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ConsoleApp1.Worker", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("LastModification")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("Wage")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Workers");
                });

            modelBuilder.Entity("ConsoleApp1.Cook", b =>
                {
                    b.HasBaseType("ConsoleApp1.Worker");

                    b.Property<string>("SpecialFood")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Cooks");
                });

            modelBuilder.Entity("ConsoleApp1.Driver", b =>
                {
                    b.HasBaseType("ConsoleApp1.Worker");

                    b.Property<int>("NumberOfKm")
                        .HasColumnType("int");

                    b.ToTable("Drivers");
                });

            modelBuilder.Entity("ConsoleApp1.Cook", b =>
                {
                    b.HasOne("ConsoleApp1.Worker", null)
                        .WithOne()
                        .HasForeignKey("ConsoleApp1.Cook", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ConsoleApp1.Driver", b =>
                {
                    b.HasOne("ConsoleApp1.Worker", null)
                        .WithOne()
                        .HasForeignKey("ConsoleApp1.Driver", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
