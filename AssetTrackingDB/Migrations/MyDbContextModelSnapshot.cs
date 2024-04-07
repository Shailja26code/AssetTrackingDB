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
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AssetTrackingDB.Asset1", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Currency")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Office")
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
                            Currency = "SEK",
                            Model = "IdeaPad",
                            Office = "Sweden",
                            Price = 6290,
                            PurchaseDate = new DateTime(2030, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "Laptop"
                        },
                        new
                        {
                            Id = 2,
                            Brand = "IPhone",
                            Currency = "SEK",
                            Model = "SE",
                            Office = "Sweden",
                            Price = 6590,
                            PurchaseDate = new DateTime(2015, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "MobilePhone"
                        },
                        new
                        {
                            Id = 3,
                            Brand = "Asus",
                            Currency = "DKK",
                            Model = "Vivobook",
                            Office = "Denmark",
                            Price = 5499,
                            PurchaseDate = new DateTime(2006, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "Laptop"
                        },
                        new
                        {
                            Id = 4,
                            Brand = "Samsung",
                            Currency = "DKK",
                            Model = "Galaxy S",
                            Office = "Denmark",
                            Price = 8990,
                            PurchaseDate = new DateTime(2010, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "MobilePhone"
                        },
                        new
                        {
                            Id = 5,
                            Brand = "MacBook",
                            Currency = "USD",
                            Model = "Air",
                            Office = "US",
                            Price = 18975,
                            PurchaseDate = new DateTime(2022, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "Laptop"
                        },
                        new
                        {
                            Id = 6,
                            Brand = "IPhone",
                            Currency = "USD",
                            Model = "15",
                            Office = "US",
                            Price = 11990,
                            PurchaseDate = new DateTime(2007, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "MobilePhone"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
