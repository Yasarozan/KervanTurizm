﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using kervanturizm.data.Concrete;

namespace kervanturizm.data.Migrations
{
    [DbContext(typeof(BiletContext))]
    [Migration("20211226115238_denemem")]
    partial class denemem
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3");

            modelBuilder.Entity("kervanturizm.entity.Admin", b =>
                {
                    b.Property<int>("AdminID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Kullanici")
                        .HasColumnType("TEXT");

                    b.Property<string>("Sifre")
                        .HasColumnType("TEXT");

                    b.HasKey("AdminID");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("kervanturizm.entity.Bilet", b =>
                {
                    b.Property<int>("BiletID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Ad")
                        .HasColumnType("TEXT");


                    b.Property<double>("Fiyat")
                        .HasColumnType("REAL");

                    b.Property<int>("GuzergahID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("KoltukNo")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Mail")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nereden")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nereye")
                        .HasColumnType("TEXT");

                    b.Property<string>("Soyad")
                        .HasColumnType("TEXT");

                    b.HasKey("BiletID");

                    b.HasIndex("GuzergahID");

                    b.ToTable("Bilets");
                });

            modelBuilder.Entity("kervanturizm.entity.Guzergah", b =>
                {
                    b.Property<int>("GuzergahID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Baslangic")
                        .HasColumnType("TEXT");

                    b.Property<string>("Bitis")
                        .HasColumnType("TEXT");

                    b.Property<double>("Fiyat")
                        .HasColumnType("REAL");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("Saat")
                        .HasColumnType("TEXT");

                    b.Property<string>("Tarih")
                        .HasColumnType("TEXT");

                    b.Property<string>("gz1")
                        .HasColumnType("TEXT");

                    b.Property<string>("gz2")
                        .HasColumnType("TEXT");

                    b.Property<string>("gz3")
                        .HasColumnType("TEXT");

                    b.HasKey("GuzergahID");

                    b.ToTable("Guzergahs");
                });

            modelBuilder.Entity("kervanturizm.entity.Kullanici", b =>
                {
                    b.Property<int>("KullaniciID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Mail")
                        .HasColumnType("TEXT");

                    b.Property<string>("Sifre")
                        .HasColumnType("TEXT");

                    b.HasKey("KullaniciID");

                    b.ToTable("Kullanicis");
                });

            modelBuilder.Entity("kervanturizm.entity.Sehir", b =>
                {
                    b.Property<int>("SehirID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("SehirAd")
                        .HasColumnType("TEXT");

                    b.HasKey("SehirID");

                    b.ToTable("Sehirs");
                });

            modelBuilder.Entity("kervanturizm.entity.Bilet", b =>
                {
                    b.HasOne("kervanturizm.entity.Guzergah", "guzergah")
                        .WithMany("Bilets")
                        .HasForeignKey("GuzergahID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
