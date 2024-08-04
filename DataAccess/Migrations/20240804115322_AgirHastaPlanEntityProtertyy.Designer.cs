﻿// <auto-generated />
using System;
using DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240804115322_AgirHastaPlanEntityProtertyy")]
    partial class AgirHastaPlanEntityProtertyy
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Entities.Concrete.AgriHastaBakimPlani", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Amac")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Degerlendirme")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HastaId")
                        .HasColumnType("int");

                    b.Property<int>("HemsireId")
                        .HasColumnType("int");

                    b.Property<string>("Neden")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Not")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TaniOlculeri")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("HastaId");

                    b.HasIndex("HemsireId");

                    b.ToTable("AgriHastaBakimPlanlari");
                });

            modelBuilder.Entity("Entities.Concrete.CheckboxItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AgriHastaBakimPlaniId")
                        .HasColumnType("int");

                    b.Property<int?>("AgriHastaBakimPlaniId1")
                        .HasColumnType("int");

                    b.Property<int?>("AgriHastaBakimPlaniId2")
                        .HasColumnType("int");

                    b.Property<int?>("AgriHastaBakimPlaniId3")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsChecked")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("AgriHastaBakimPlaniId");

                    b.HasIndex("AgriHastaBakimPlaniId1");

                    b.HasIndex("AgriHastaBakimPlaniId2");

                    b.HasIndex("AgriHastaBakimPlaniId3");

                    b.ToTable("CheckboxItems");
                });

            modelBuilder.Entity("Entities.Concrete.Girisim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AgriHastaBakimPlaniId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AgriHastaBakimPlaniId");

                    b.ToTable("Girisimler");
                });

            modelBuilder.Entity("Entities.Concrete.Hasta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DogumTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("HemsireTanisi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tani")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tanim")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Hastalar");
                });

            modelBuilder.Entity("Entities.Concrete.Hemsire", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Hemsireler");
                });

            modelBuilder.Entity("Entities.Concrete.AgriHastaBakimPlani", b =>
                {
                    b.HasOne("Entities.Concrete.Hasta", "Hasta")
                        .WithMany("AgriHastaBakimPlanlari")
                        .HasForeignKey("HastaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.Hemsire", "Hemsire")
                        .WithMany("AgriHastaBakimPlanlari")
                        .HasForeignKey("HemsireId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hasta");

                    b.Navigation("Hemsire");
                });

            modelBuilder.Entity("Entities.Concrete.CheckboxItem", b =>
                {
                    b.HasOne("Entities.Concrete.AgriHastaBakimPlani", null)
                        .WithMany("Amaclar")
                        .HasForeignKey("AgriHastaBakimPlaniId");

                    b.HasOne("Entities.Concrete.AgriHastaBakimPlani", null)
                        .WithMany("Degerlendirmeler")
                        .HasForeignKey("AgriHastaBakimPlaniId1");

                    b.HasOne("Entities.Concrete.AgriHastaBakimPlani", null)
                        .WithMany("Nedenler")
                        .HasForeignKey("AgriHastaBakimPlaniId2");

                    b.HasOne("Entities.Concrete.AgriHastaBakimPlani", null)
                        .WithMany("TaniOlcutleri")
                        .HasForeignKey("AgriHastaBakimPlaniId3");
                });

            modelBuilder.Entity("Entities.Concrete.Girisim", b =>
                {
                    b.HasOne("Entities.Concrete.AgriHastaBakimPlani", "AgriHastaBakimPlani")
                        .WithMany("Girisimler")
                        .HasForeignKey("AgriHastaBakimPlaniId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AgriHastaBakimPlani");
                });

            modelBuilder.Entity("Entities.Concrete.AgriHastaBakimPlani", b =>
                {
                    b.Navigation("Amaclar");

                    b.Navigation("Degerlendirmeler");

                    b.Navigation("Girisimler");

                    b.Navigation("Nedenler");

                    b.Navigation("TaniOlcutleri");
                });

            modelBuilder.Entity("Entities.Concrete.Hasta", b =>
                {
                    b.Navigation("AgriHastaBakimPlanlari");
                });

            modelBuilder.Entity("Entities.Concrete.Hemsire", b =>
                {
                    b.Navigation("AgriHastaBakimPlanlari");
                });
#pragma warning restore 612, 618
        }
    }
}
