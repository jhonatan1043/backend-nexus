﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using testnexus.Context;

namespace testnexus.Migrations
{
    [DbContext(typeof(ContextBook))]
    partial class ContextBookModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("testnexus.Entitys.Autor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("birthdate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Autores");
                });

            modelBuilder.Entity("testnexus.Entitys.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AutorId")
                        .HasColumnType("int");

                    b.Property<int?>("EditorialId")
                        .HasColumnType("int");

                    b.Property<int>("IdAutor")
                        .HasColumnType("int");

                    b.Property<int>("IdEditorial")
                        .HasColumnType("int");

                    b.Property<int>("NumPage")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AutorId");

                    b.HasIndex("EditorialId");

                    b.ToTable("books");
                });

            modelBuilder.Entity("testnexus.Entitys.Editorial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaxBookReg")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Phone")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Editorials");
                });

            modelBuilder.Entity("testnexus.Entitys.Book", b =>
                {
                    b.HasOne("testnexus.Entitys.Autor", "Autor")
                        .WithMany()
                        .HasForeignKey("AutorId");

                    b.HasOne("testnexus.Entitys.Editorial", "Editorial")
                        .WithMany()
                        .HasForeignKey("EditorialId");

                    b.Navigation("Autor");

                    b.Navigation("Editorial");
                });
#pragma warning restore 612, 618
        }
    }
}
