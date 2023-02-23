﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UMBIT.Core.Repositorio.Contexto;

#nullable disable

namespace UMBIT.API.EXEMPLO.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230223162106_teste_")]
    partial class teste_
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-preview.1.23111.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("UMBIT.API.EXEMPLO.model.Gato", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("DataAtualizacao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Miar")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("t")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.ToTable("Gato");
                });

            modelBuilder.Entity("UMBIT.API.EXEMPLO.model.Gato1", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("DataAtualizacao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Miar")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.ToTable("Gato1");
                });
#pragma warning restore 612, 618
        }
    }
}
