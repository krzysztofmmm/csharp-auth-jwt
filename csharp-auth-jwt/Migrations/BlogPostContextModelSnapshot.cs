﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using csharp_auth_jwt.Data;

#nullable disable

namespace csharp_auth_jwt.Migrations
{
    [DbContext(typeof(BlogPostContext))]
    partial class BlogPostContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("csharp_auth_jwt.Model.BlogPost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("AuthorId")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("authorId");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("text");

                    b.Property<string>("authorId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("authorId");

                    b.ToTable("blogPosts", t =>
                        {
                            t.Property("authorId")
                                .HasColumnName("authorId1");
                        });

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = "author1",
                            Text = "First blog post"
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = "author2",
                            Text = "Second blog post"
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = "author3",
                            Text = "Third blog post"
                        });
                });

            modelBuilder.Entity("csharp_auth_jwt.Model.BlogUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("text");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("text");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<int>("Role")
                        .HasColumnType("integer")
                        .HasColumnName("role");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("blogUsers");
                });

            modelBuilder.Entity("csharp_auth_jwt.Model.BlogPost", b =>
                {
                    b.HasOne("csharp_auth_jwt.Model.BlogUser", "Author")
                        .WithMany()
                        .HasForeignKey("authorId");

                    b.Navigation("Author");
                });
#pragma warning restore 612, 618
        }
    }
}
