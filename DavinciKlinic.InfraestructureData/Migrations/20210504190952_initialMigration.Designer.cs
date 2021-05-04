﻿// <auto-generated />
using System;
using DavinciKlinic.InfraestructureData.Modelos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DavinciKlinic.InfraestructureData.Migrations
{
    [DbContext(typeof(DavinciKlinicDBContext))]
    [Migration("20210504190952_initialMigration")]
    partial class initialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DavinciKlinic.InfraestructureData.Modelos.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CodigoCliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescripcionCliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DireccionCliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<bool>("Eliminado")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("FechaIngreso")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<string>("NombreCliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelefonoCliente")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("DavinciKlinic.InfraestructureData.Modelos.FacturaVenta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Eliminado")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("FechaFactura")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<int?>("IdCliente")
                        .HasColumnType("int");

                    b.Property<int?>("IdClienteNavigationId")
                        .HasColumnType("int");

                    b.Property<decimal?>("Impuesto")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("NumeroFactura")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("SubTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("IdClienteNavigationId");

                    b.ToTable("FacturaVenta");
                });

            modelBuilder.Entity("DavinciKlinic.InfraestructureData.Modelos.ItemFactura", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<short?>("Cantidad")
                        .HasColumnType("smallint");

                    b.Property<string>("CodigoProducto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Descuento")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("Eliminado")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("FechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<int?>("IdFacturaVenta")
                        .HasColumnType("int");

                    b.Property<int?>("IdFacturaVentaNavigationId")
                        .HasColumnType("int");

                    b.Property<int?>("IdProducto")
                        .HasColumnType("int");

                    b.Property<int?>("IdProductoNavigationId")
                        .HasColumnType("int");

                    b.Property<string>("NombreProducto")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdFacturaVentaNavigationId");

                    b.HasIndex("IdProductoNavigationId");

                    b.ToTable("ItemFacturas");
                });

            modelBuilder.Entity("DavinciKlinic.InfraestructureData.Modelos.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CodigoProducto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Eliminado")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("FechaIngreso")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<string>("NombreProducto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("PrecioCosto")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("PrecioUnitario")
                        .HasColumnType("decimal(18,2)");

                    b.Property<short?>("Stock")
                        .HasColumnType("smallint");

                    b.Property<short?>("StockMinimo")
                        .HasColumnType("smallint");

                    b.HasKey("Id");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("DavinciKlinic.InfraestructureData.Modelos.FacturaVenta", b =>
                {
                    b.HasOne("DavinciKlinic.InfraestructureData.Modelos.Cliente", "IdClienteNavigation")
                        .WithMany("FacturaVenta")
                        .HasForeignKey("IdClienteNavigationId");

                    b.Navigation("IdClienteNavigation");
                });

            modelBuilder.Entity("DavinciKlinic.InfraestructureData.Modelos.ItemFactura", b =>
                {
                    b.HasOne("DavinciKlinic.InfraestructureData.Modelos.FacturaVenta", "IdFacturaVentaNavigation")
                        .WithMany("ItemFacturas")
                        .HasForeignKey("IdFacturaVentaNavigationId");

                    b.HasOne("DavinciKlinic.InfraestructureData.Modelos.Producto", "IdProductoNavigation")
                        .WithMany("ItemFacturas")
                        .HasForeignKey("IdProductoNavigationId");

                    b.Navigation("IdFacturaVentaNavigation");

                    b.Navigation("IdProductoNavigation");
                });

            modelBuilder.Entity("DavinciKlinic.InfraestructureData.Modelos.Cliente", b =>
                {
                    b.Navigation("FacturaVenta");
                });

            modelBuilder.Entity("DavinciKlinic.InfraestructureData.Modelos.FacturaVenta", b =>
                {
                    b.Navigation("ItemFacturas");
                });

            modelBuilder.Entity("DavinciKlinic.InfraestructureData.Modelos.Producto", b =>
                {
                    b.Navigation("ItemFacturas");
                });
#pragma warning restore 612, 618
        }
    }
}
