﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Models;

#nullable disable

namespace CarPooling.Models.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Models.BookRide", b =>
                {
                    b.Property<int>("RideId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("BookerUserId")
                        .HasColumnType("int");

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("EndPoint")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("Fare")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("OffererName")
                        .HasColumnType("longtext");

                    b.Property<int?>("OffererUserId")
                        .HasColumnType("int");

                    b.Property<string>("StartPoint")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("TimeSlot")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("RideId");

                    b.ToTable("BookedRides");
                });

            modelBuilder.Entity("Models.OfferedRide", b =>
                {
                    b.Property<int>("RideId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Capacity")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("EndPoint")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("FarePerBlock")
                        .HasColumnType("int");

                    b.Property<string>("IntermediatePoints")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("OffererId")
                        .HasColumnType("int");

                    b.Property<string>("OffererName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("StartPoint")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("TimeSlot")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("RideId");

                    b.ToTable("OfferedRides");
                });

            modelBuilder.Entity("Models.Ride", b =>
                {
                    b.Property<int>("RideId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("EndPoint")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("StartPoint")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("TimeSlot")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("RideId");

                    b.ToTable("Rides");
                });

            modelBuilder.Entity("Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
