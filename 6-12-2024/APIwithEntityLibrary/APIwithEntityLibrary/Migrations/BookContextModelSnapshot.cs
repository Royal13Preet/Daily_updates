﻿// <auto-generated />
using APIwithEntityLibrary.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace APIwithEntityLibrary.Migrations
{
    [DbContext(typeof(BookContext))]
    partial class BookContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("APIwithEntityLibrary.Models.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuthorId"));

                    b.Property<string>("AuthorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            AuthorId = 1,
                            AuthorName = "Author1"
                        },
                        new
                        {
                            AuthorId = 2,
                            AuthorName = "author2"
                        });
                });

            modelBuilder.Entity("APIwithEntityLibrary.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookId"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookId");

                    b.HasIndex("AuthorId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            AuthorId = 1,
                            Title = "Book1"
                        },
                        new
                        {
                            BookId = 2,
                            AuthorId = 1,
                            Title = "Book2"
                        },
                        new
                        {
                            BookId = 3,
                            AuthorId = 2,
                            Title = "book3"
                        });
                });

            modelBuilder.Entity("APIwithEntityLibrary.Models.BookCategory", b =>
                {
                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.HasKey("BookId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("BookCategories");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            CategoryId = 1
                        },
                        new
                        {
                            BookId = 1,
                            CategoryId = 2
                        },
                        new
                        {
                            BookId = 2,
                            CategoryId = 2
                        },
                        new
                        {
                            BookId = 3,
                            CategoryId = 3
                        });
                });

            modelBuilder.Entity("APIwithEntityLibrary.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Fiction"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Non- Fiction"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Science Fiction"
                        });
                });

            modelBuilder.Entity("APIwithEntityLibrary.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("APIwithEntityLibrary.Models.Book", b =>
                {
                    b.HasOne("APIwithEntityLibrary.Models.Author", "author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("author");
                });

            modelBuilder.Entity("APIwithEntityLibrary.Models.BookCategory", b =>
                {
                    b.HasOne("APIwithEntityLibrary.Models.Book", "Book")
                        .WithMany("BookCategories")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("APIwithEntityLibrary.Models.Category", "Category")
                        .WithMany("BookCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("APIwithEntityLibrary.Models.Author", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("APIwithEntityLibrary.Models.Book", b =>
                {
                    b.Navigation("BookCategories");
                });

            modelBuilder.Entity("APIwithEntityLibrary.Models.Category", b =>
                {
                    b.Navigation("BookCategories");
                });
#pragma warning restore 612, 618
        }
    }
}
