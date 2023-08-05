﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using boards.Infrastructure;
using boards.Infrastructure.Context;

#nullable disable

namespace boards.Migrations
{
    [DbContext(typeof(BoardDbContext))]
    [Migration("20230729160238_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.9");

            modelBuilder.Entity("src.Infrastructure.BoardDb", b =>
                {
                    b.Property<string>("Slug")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Slug");

                    b.ToTable("Boards");
                });
#pragma warning restore 612, 618
        }
    }
}
