﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PROIECT.Data;

#nullable disable

namespace PROIECT.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20240109150038_Relatii2")]
    partial class Relatii2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PROIECT.Models.Angajat", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CNP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("MagazinID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("NumarTelefon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Salariu")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MagazinID");

                    b.ToTable("Angajati");
                });

            modelBuilder.Entity("PROIECT.Models.Magazin", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AdresaMail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("NumarContact")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("StatiuneID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("StatiuneID");

                    b.ToTable("Magazine");
                });

            modelBuilder.Entity("PROIECT.Models.MagazinProdus", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("MagazinID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProdusID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("MagazinID");

                    b.HasIndex("ProdusID");

                    b.ToTable("MagazinProduse");
                });

            modelBuilder.Entity("PROIECT.Models.Partie", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("GradDificultate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Inaltime")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<int>("Lungime")
                        .HasColumnType("int");

                    b.Property<string>("Nume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("StatiuneID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("StatiuneID");

                    b.ToTable("Partii");
                });

            modelBuilder.Entity("PROIECT.Models.Produs", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Pret")
                        .HasColumnType("int");

                    b.Property<int>("Stoc")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Produse");
                });

            modelBuilder.Entity("PROIECT.Models.Statiune", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Regiune")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Stat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Statiuni");
                });

            modelBuilder.Entity("PROIECT.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AdresaMail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CNP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("NumarTelefon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Parola")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenume")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clienti");
                });

            modelBuilder.Entity("PROIECT.Models.UserProdus", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Cantiate")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ProdusID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ProdusID");

                    b.HasIndex("UserID");

                    b.ToTable("UserProduse");
                });

            modelBuilder.Entity("PROIECT.Models.Angajat", b =>
                {
                    b.HasOne("PROIECT.Models.Magazin", "Magazin")
                        .WithMany("Angajati")
                        .HasForeignKey("MagazinID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Magazin");
                });

            modelBuilder.Entity("PROIECT.Models.Magazin", b =>
                {
                    b.HasOne("PROIECT.Models.Statiune", "Statiune")
                        .WithMany("Magazine")
                        .HasForeignKey("StatiuneID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Statiune");
                });

            modelBuilder.Entity("PROIECT.Models.MagazinProdus", b =>
                {
                    b.HasOne("PROIECT.Models.Magazin", "Magazin")
                        .WithMany("MagazinProduse")
                        .HasForeignKey("MagazinID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PROIECT.Models.Produs", "Produs")
                        .WithMany("MagazinProduse")
                        .HasForeignKey("ProdusID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Magazin");

                    b.Navigation("Produs");
                });

            modelBuilder.Entity("PROIECT.Models.Partie", b =>
                {
                    b.HasOne("PROIECT.Models.Statiune", "Statiune")
                        .WithMany("Partii")
                        .HasForeignKey("StatiuneID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Statiune");
                });

            modelBuilder.Entity("PROIECT.Models.UserProdus", b =>
                {
                    b.HasOne("PROIECT.Models.Produs", "Produs")
                        .WithMany("UserProduse")
                        .HasForeignKey("ProdusID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PROIECT.Models.User", "User")
                        .WithMany("UserProduse")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Produs");

                    b.Navigation("User");
                });

            modelBuilder.Entity("PROIECT.Models.Magazin", b =>
                {
                    b.Navigation("Angajati");

                    b.Navigation("MagazinProduse");
                });

            modelBuilder.Entity("PROIECT.Models.Produs", b =>
                {
                    b.Navigation("MagazinProduse");

                    b.Navigation("UserProduse");
                });

            modelBuilder.Entity("PROIECT.Models.Statiune", b =>
                {
                    b.Navigation("Magazine");

                    b.Navigation("Partii");
                });

            modelBuilder.Entity("PROIECT.Models.User", b =>
                {
                    b.Navigation("UserProduse");
                });
#pragma warning restore 612, 618
        }
    }
}
