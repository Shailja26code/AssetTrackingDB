﻿// <auto-generated />
using System;
using AssetTrackingDB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AssetTrackingDB.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AssetTrackingDB.Asset", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<DateTime>("PurchaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Assets");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Brand = "Lenovo",
                            Model = "IdeaPad",
                            Price = 6290,
                            PurchaseDate = new DateTime(2021, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "Laptop"
                        },
                        new
                        {
                            Id = 2,
                            Brand = "IPhone",
                            Model = "SE",
                            Price = 6590,
                            PurchaseDate = new DateTime(2021, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "MobilePhone"
                        },
                        new
                        {
                            Id = 3,
                            Brand = "Asus",
                            Model = "Vivobook",
                            Price = 5499,
                            PurchaseDate = new DateTime(2021, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "Laptop"
                        },
                        new
                        {
                            Id = 4,
                            Brand = "Samsung",
                            Model = "Galaxy S",
                            Price = 8990,
                            PurchaseDate = new DateTime(2022, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "MobilePhone"
                        },
                        new
                        {
                            Id = 5,
                            Brand = "MacBook",
                            Model = "Air",
                            Price = 18975,
                            PurchaseDate = new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "Laptop"
                        },
                        new
                        {
                            Id = 6,
                            Brand = "IPhone",
                            Model = "15",
                            Price = 11990,
                            PurchaseDate = new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "MobilePhone"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}