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
    [Migration("20240317195949_V2Correcao")]
    partial class V2Correcao
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

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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

            modelBuilder.Entity("Smartmei.Models.Evento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataEventoFim")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataEventoInicio")
                        .HasColumnType("datetime2");

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<int>("ProjetoId")
                        .HasColumnType("int");

                    b.Property<decimal>("ValorDiaria")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("ProjetoId");

                    b.ToTable("Eventos");
                });

            modelBuilder.Entity("SmartMei.Models.Faturamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Ano")
                        .HasColumnType("int");

                    b.Property<decimal>("CustoMensal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("MeiId")
                        .HasColumnType("int");

                    b.Property<int>("Mes")
                        .HasColumnType("int");

                    b.Property<decimal>("ValorBruto")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ValorLiquidoMensal")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("MeiId");

                    b.ToTable("Faturamento");
                });

            modelBuilder.Entity("Smartmei.Models.Mei", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Mei");
                });

            modelBuilder.Entity("Smartmei.Models.Projeto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Acompanhamento")
                        .HasColumnType("int");

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataEmissaoNF")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataFimProjeto")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataInicioProjeto")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataPagamentoNF")
                        .HasColumnType("datetime2");

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

                    b.HasIndex("ClienteId");

                    b.HasIndex("MeiId");

                    b.ToTable("Projetos");
                });

            modelBuilder.Entity("SmartMei.Models.Custo", b =>
                {
                    b.HasOne("Smartmei.Models.Projeto", "Projeto")
                        .WithMany("Custos")
                        .HasForeignKey("ProjetoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Projeto");
                });

            modelBuilder.Entity("Smartmei.Models.Evento", b =>
                {
                    b.HasOne("Smartmei.Models.Projeto", "Projeto")
                        .WithMany("Eventos")
                        .HasForeignKey("ProjetoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Projeto");
                });

            modelBuilder.Entity("SmartMei.Models.Faturamento", b =>
                {
                    b.HasOne("Smartmei.Models.Mei", "Mei")
                        .WithMany("Faturamentos")
                        .HasForeignKey("MeiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Mei");
                });

            modelBuilder.Entity("Smartmei.Models.Projeto", b =>
                {
                    b.HasOne("Smartmei.Models.Cliente", "Cliente")
                        .WithMany("Projetos")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Smartmei.Models.Mei", "Mei")
                        .WithMany("Projetos")
                        .HasForeignKey("MeiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Mei");
                });

            modelBuilder.Entity("Smartmei.Models.Cliente", b =>
                {
                    b.Navigation("Projetos");
                });

            modelBuilder.Entity("Smartmei.Models.Mei", b =>
                {
                    b.Navigation("Faturamentos");

                    b.Navigation("Projetos");
                });

            modelBuilder.Entity("Smartmei.Models.Projeto", b =>
                {
                    b.Navigation("Custos");

                    b.Navigation("Eventos");
                });
#pragma warning restore 612, 618
        }
    }
}
