﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
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
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("boards.Infrastructure.Models.BoardDb", b =>
                {
                    b.Property<string>("Slug")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Slug");

                    b.ToTable("Boards");
                });

            modelBuilder.Entity("boards.Infrastructure.Models.ReplyDb", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("text");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ThreadId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ThreadId");

                    b.ToTable("Replies");
                });

            modelBuilder.Entity("boards.Infrastructure.Models.ThreadDb", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("BoardSlug")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("BoardSlug");

                    b.ToTable("Threads");
                });

            modelBuilder.Entity("boards.Infrastructure.Models.ReplyDb", b =>
                {
                    b.HasOne("boards.Infrastructure.Models.ThreadDb", "Thread")
                        .WithMany("Replies")
                        .HasForeignKey("ThreadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Thread");
                });

            modelBuilder.Entity("boards.Infrastructure.Models.ThreadDb", b =>
                {
                    b.HasOne("boards.Infrastructure.Models.BoardDb", "Board")
                        .WithMany("Threads")
                        .HasForeignKey("BoardSlug")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Board");
                });

            modelBuilder.Entity("boards.Infrastructure.Models.BoardDb", b =>
                {
                    b.Navigation("Threads");
                });

            modelBuilder.Entity("boards.Infrastructure.Models.ThreadDb", b =>
                {
                    b.Navigation("Replies");
                });
#pragma warning restore 612, 618
        }
    }
}
