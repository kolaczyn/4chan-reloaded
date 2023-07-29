﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using boards.Infrastructure;

#nullable disable

namespace boards.Migrations
{
    [DbContext(typeof(BoardDbContext))]
    partial class BoardDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.9");

            modelBuilder.Entity("boards.Infrastructure.BoardDb", b =>
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
