﻿// <auto-generated />
using System;
using BlazorTest.ServerSide.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorTest.ServerSide.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0-preview.6.22329.4");

            modelBuilder.Entity("BlazorTest.ServerSide.Models.Kanji", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Char")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Meanings")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Kanjis");
                });

            modelBuilder.Entity("BlazorTest.ServerSide.Models.Reading", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Kana")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("KanjiId")
                        .HasColumnType("TEXT");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("KanjiId");

                    b.ToTable("Readings");
                });

            modelBuilder.Entity("BlazorTest.ServerSide.Models.Reading", b =>
                {
                    b.HasOne("BlazorTest.ServerSide.Models.Kanji", "Kanji")
                        .WithMany("Readings")
                        .HasForeignKey("KanjiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kanji");
                });

            modelBuilder.Entity("BlazorTest.ServerSide.Models.Kanji", b =>
                {
                    b.Navigation("Readings");
                });
#pragma warning restore 612, 618
        }
    }
}
