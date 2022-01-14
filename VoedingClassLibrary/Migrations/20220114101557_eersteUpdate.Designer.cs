﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VoedingClassLibrary;

namespace VoedingClassLibrary.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20220114101557_eersteUpdate")]
    partial class eersteUpdate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VoedingClassLibrary.Barcode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Gewicht")
                        .HasColumnType("float");

                    b.Property<string>("InputField")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("barcodes");
                });
#pragma warning restore 612, 618
        }
    }
}
