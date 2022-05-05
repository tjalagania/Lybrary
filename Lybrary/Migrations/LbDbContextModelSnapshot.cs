﻿// <auto-generated />
using System;
using Lybrary.LybrarbyDbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Lybrary.Migrations
{
    [DbContext(typeof(LbDbContext))]
    partial class LbDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.4");

            modelBuilder.Entity("ArticalAuthor", b =>
                {
                    b.Property<int>("ArticalsId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("AuthorsId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ArticalsId", "AuthorsId");

                    b.HasIndex("AuthorsId");

                    b.ToTable("ArticalAuthor");
                });

            modelBuilder.Entity("ArticalMagazine", b =>
                {
                    b.Property<int>("ArticalsId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MagazinesId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ArticalsId", "MagazinesId");

                    b.HasIndex("MagazinesId");

                    b.ToTable("ArticalMagazine");
                });

            modelBuilder.Entity("AuthorBook", b =>
                {
                    b.Property<int>("AuthrosId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("BooksId")
                        .HasColumnType("INTEGER");

                    b.HasKey("AuthrosId", "BooksId");

                    b.HasIndex("BooksId");

                    b.ToTable("AuthorBook");
                });

            modelBuilder.Entity("lybrarbyModels.Artical", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ItemsId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Version")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ItemsId");

                    b.ToTable("Artists");
                });

            modelBuilder.Entity("lybrarbyModels.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("MagazineId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("MagazineId");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("lybrarbyModels.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ISBN")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ItemId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("lybrarbyModels.Borrow", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("BorrowDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("CopyId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CopyId");

                    b.HasIndex("UserId");

                    b.ToTable("Borrows");
                });

            modelBuilder.Entity("lybrarbyModels.Copy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ItemId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.ToTable("Copys");
                });

            modelBuilder.Entity("lybrarbyModels.Credential", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<int>("IsAdmin")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Username")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Credentials");
                });

            modelBuilder.Entity("lybrarbyModels.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("PublishedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Publisher")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("lybrarbyModels.Magazine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ISBN")
                        .HasColumnType("TEXT");

                    b.Property<int>("Number")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Magazines");
                });

            modelBuilder.Entity("lybrarbyModels.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ArticalAuthor", b =>
                {
                    b.HasOne("lybrarbyModels.Artical", null)
                        .WithMany()
                        .HasForeignKey("ArticalsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("lybrarbyModels.Author", null)
                        .WithMany()
                        .HasForeignKey("AuthorsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ArticalMagazine", b =>
                {
                    b.HasOne("lybrarbyModels.Artical", null)
                        .WithMany()
                        .HasForeignKey("ArticalsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("lybrarbyModels.Magazine", null)
                        .WithMany()
                        .HasForeignKey("MagazinesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AuthorBook", b =>
                {
                    b.HasOne("lybrarbyModels.Author", null)
                        .WithMany()
                        .HasForeignKey("AuthrosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("lybrarbyModels.Book", null)
                        .WithMany()
                        .HasForeignKey("BooksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("lybrarbyModels.Artical", b =>
                {
                    b.HasOne("lybrarbyModels.Item", "Items")
                        .WithMany()
                        .HasForeignKey("ItemsId");

                    b.Navigation("Items");
                });

            modelBuilder.Entity("lybrarbyModels.Author", b =>
                {
                    b.HasOne("lybrarbyModels.Magazine", null)
                        .WithMany("Authors")
                        .HasForeignKey("MagazineId");
                });

            modelBuilder.Entity("lybrarbyModels.Book", b =>
                {
                    b.HasOne("lybrarbyModels.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId");

                    b.Navigation("Item");
                });

            modelBuilder.Entity("lybrarbyModels.Borrow", b =>
                {
                    b.HasOne("lybrarbyModels.Copy", "Copy")
                        .WithMany()
                        .HasForeignKey("CopyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("lybrarbyModels.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Copy");

                    b.Navigation("User");
                });

            modelBuilder.Entity("lybrarbyModels.Copy", b =>
                {
                    b.HasOne("lybrarbyModels.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId");

                    b.Navigation("Item");
                });

            modelBuilder.Entity("lybrarbyModels.Credential", b =>
                {
                    b.HasOne("lybrarbyModels.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("lybrarbyModels.Magazine", b =>
                {
                    b.Navigation("Authors");
                });
#pragma warning restore 612, 618
        }
    }
}
