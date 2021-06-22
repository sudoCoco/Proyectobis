﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Proyectobis;

namespace Proyectobis.Migrations
{
    [DbContext(typeof(AgenciaColocacionContext))]
    [Migration("20210622114553_OnDeleteMethod")]
    partial class OnDeleteMethod
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.7");

            modelBuilder.Entity("Proyectobis.Agencia", b =>
                {
                    b.Property<int>("CodigoAgencia")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.HasKey("CodigoAgencia");

                    b.ToTable("Agencias");
                });

            modelBuilder.Entity("Proyectobis.Colocacion", b =>
                {
                    b.Property<int>("ColocacionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("FechaColocacion")
                        .HasColumnType("date");

                    b.Property<int>("OfertaId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("OfertaTrabajadorId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TipoContrato")
                        .HasMaxLength(3)
                        .HasColumnType("INTEGER");

                    b.Property<int>("TrabajadorId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ColocacionId");

                    b.HasIndex("OfertaTrabajadorId", "TrabajadorId", "OfertaId")
                        .IsUnique();

                    b.ToTable("Colocaciones");
                });

            modelBuilder.Entity("Proyectobis.Empresa", b =>
                {
                    b.Property<int>("EmpresaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CifEmpresa")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("TEXT");

                    b.Property<string>("RazonSocial")
                        .IsRequired()
                        .HasMaxLength(55)
                        .HasColumnType("TEXT");

                    b.HasKey("EmpresaId");

                    b.ToTable("Empresas");
                });

            modelBuilder.Entity("Proyectobis.Oferta", b =>
                {
                    b.Property<int>("OfertaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("varchar");

                    b.Property<int>("EmpresaId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("FechaOferta")
                        .HasColumnType("TEXT");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.HasKey("OfertaId");

                    b.HasIndex("EmpresaId");

                    b.ToTable("Ofertas");
                });

            modelBuilder.Entity("Proyectobis.OfertaTrabajador", b =>
                {
                    b.Property<int>("OfertaId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TrabajadorId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("OfertaTrabajadorId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("FechaOfertaEnviada")
                        .HasColumnType("date");

                    b.HasKey("OfertaId", "TrabajadorId", "OfertaTrabajadorId");

                    b.HasAlternateKey("OfertaTrabajadorId");

                    b.HasIndex("TrabajadorId");

                    b.ToTable("OfertaTrabajadores");
                });

            modelBuilder.Entity("Proyectobis.Trabajador", b =>
                {
                    b.Property<int>("TrabajadorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Apellido1")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("Apellido2")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<char>("Discapacidad")
                        .HasColumnType("TEXT");

                    b.Property<string>("Dni")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasMaxLength(8)
                        .HasColumnType("date");

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("TEXT");

                    b.Property<char>("Inmigrante")
                        .HasColumnType("TEXT");

                    b.Property<string>("NivelFormativo")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("TEXT");

                    b.Property<char>("Sexo")
                        .HasColumnType("TEXT");

                    b.HasKey("TrabajadorId");

                    b.ToTable("Trabajadores");
                });

            modelBuilder.Entity("Proyectobis.Colocacion", b =>
                {
                    b.HasOne("Proyectobis.OfertaTrabajador", "OfertaTrabajador")
                        .WithOne("Colocacion")
                        .HasForeignKey("Proyectobis.Colocacion", "OfertaTrabajadorId", "TrabajadorId", "OfertaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OfertaTrabajador");
                });

            modelBuilder.Entity("Proyectobis.Oferta", b =>
                {
                    b.HasOne("Proyectobis.Empresa", "Empresa")
                        .WithMany("Ofertas")
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.Navigation("Empresa");
                });

            modelBuilder.Entity("Proyectobis.OfertaTrabajador", b =>
                {
                    b.HasOne("Proyectobis.Oferta", "Oferta")
                        .WithMany("OfertaTrabajadores")
                        .HasForeignKey("OfertaId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.HasOne("Proyectobis.Trabajador", "Trabajador")
                        .WithMany("OfertaTrabajadores")
                        .HasForeignKey("TrabajadorId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.Navigation("Oferta");

                    b.Navigation("Trabajador");
                });

            modelBuilder.Entity("Proyectobis.Empresa", b =>
                {
                    b.Navigation("Ofertas");
                });

            modelBuilder.Entity("Proyectobis.Oferta", b =>
                {
                    b.Navigation("OfertaTrabajadores");
                });

            modelBuilder.Entity("Proyectobis.OfertaTrabajador", b =>
                {
                    b.Navigation("Colocacion");
                });

            modelBuilder.Entity("Proyectobis.Trabajador", b =>
                {
                    b.Navigation("OfertaTrabajadores");
                });
#pragma warning restore 612, 618
        }
    }
}
