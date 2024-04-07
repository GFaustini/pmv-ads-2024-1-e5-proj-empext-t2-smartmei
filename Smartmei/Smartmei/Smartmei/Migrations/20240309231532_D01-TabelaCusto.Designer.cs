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
    [Migration("20240309231532_D01-TabelaCusto")]
    partial class D01TabelaCusto
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SmartMei.Models.Custo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("Alimentacao")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("CustoTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Deslocamento")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Hospedagem")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PassagemAerea")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProjetoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProjetoId");

                    b.ToTable("Custos");
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

            modelBuilder.Entity("SmartMei.Models.Custo", b =>
                {
                    b.HasOne("Smartmei.Models.Projeto", "Projeto")
                        .WithMany()
                        .HasForeignKey("ProjetoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Projeto");
                });
#pragma warning restore 612, 618
        }
    }
}
