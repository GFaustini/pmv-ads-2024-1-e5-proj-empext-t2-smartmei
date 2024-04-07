﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Smartmei.Models;

#nullable disable

namespace Smartmei.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240310140545_D03-TabelaCliente")]
    partial class D03TabelaCliente
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Smartmei.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CNPJ")
                        .HasMaxLength(18)
                        .HasColumnType("int");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Email")
                        .HasColumnType("int");

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observacao")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ProductOwner")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Smartmei.Models.Projeto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Acompanhamento")
                        .HasColumnType("int");

                    b.Property<string>("Cidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataEmissaoNF")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataFimEvento")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataFimProjeto")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataInicioEvento")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataInicioProjeto")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataPagamentoNF")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Diaria")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LinkDrive")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MeiId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrazoPagamento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuantidadeTelas")
                        .HasColumnType("int");

                    b.Property<decimal>("ValorTela")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ValorTotalProjeto")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Projetos");
                });
#pragma warning restore 612, 618
        }
    }
}