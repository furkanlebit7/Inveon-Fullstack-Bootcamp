﻿// <auto-generated />
using JwtInveonOrnek.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JwtInveonOrnek.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231031000704_DatabaseInit")]
    partial class DatabaseInit
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.4");

            modelBuilder.Entity("JwtInveonOrnek.Entities.ApplicationUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ApplicationUsers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "test",
                            Password = "testPassword",
                            Username = "testUser"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
