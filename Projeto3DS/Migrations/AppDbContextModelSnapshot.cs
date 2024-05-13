﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Projeto3DS.Controllers;

#nullable disable

namespace Projeto3DS.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Projeto3DS.Models.Categoria", b =>
                {
                    b.Property<int>("categoriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("categoriaNome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("descricao")
                        .HasColumnType("longtext");

                    b.Property<string>("lanche")
                        .HasColumnType("longtext");

                    b.HasKey("categoriaId");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("Projeto3DS.Models.Lanche", b =>
                {
                    b.Property<int>("lancheId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("categoriaId")
                        .HasColumnType("int");

                    b.Property<string>("descricao_curta")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("descricao_detalhada")
                        .HasColumnType("longtext");

                    b.Property<bool>("emEstoque")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("imagemURL")
                        .HasColumnType("longtext");

                    b.Property<string>("lanchePreferido")
                        .HasColumnType("longtext");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.Property<decimal>("preco")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("lancheId");

                    b.HasIndex("categoriaId");

                    b.ToTable("Lanche");
                });

            modelBuilder.Entity("Projeto3DS.Models.Lanche", b =>
                {
                    b.HasOne("Projeto3DS.Models.Categoria", null)
                        .WithMany("lanches")
                        .HasForeignKey("categoriaId");
                });

            modelBuilder.Entity("Projeto3DS.Models.Categoria", b =>
                {
                    b.Navigation("lanches");
                });
#pragma warning restore 612, 618
        }
    }
}
