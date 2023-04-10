﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TicTacToeWebApi.DAL;

#nullable disable

namespace TicTacToeWebApi.DAL.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.15");

            modelBuilder.Entity("TicTacToeWebApi.Domain.Entity.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("Winner")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("DBGames");
                });
#pragma warning restore 612, 618
        }
    }
}
