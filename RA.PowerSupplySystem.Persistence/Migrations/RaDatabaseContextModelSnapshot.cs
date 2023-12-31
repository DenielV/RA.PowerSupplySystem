﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RA.PowerSupplySystem.Persistence.DatabaseContext;

#nullable disable

namespace RA.PowerSupplySystem.Persistence.Migrations
{
    [DbContext(typeof(RaDatabaseContext))]
    partial class RaDatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RA.PowerSupplySystem.Domain.Material", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PartNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Materials");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Resistencia de 10k Ohms",
                            Name = "Resistencia",
                            PartNumber = "R10K",
                            Stock = 1000
                        },
                        new
                        {
                            Id = 2,
                            Description = "Tablero de circuito impreso",
                            Name = "Tablero",
                            PartNumber = "PCB4",
                            Stock = 100
                        },
                        new
                        {
                            Id = 3,
                            Description = "Carcasa para fuente de poder",
                            Name = "Carcasa",
                            PartNumber = "CARK",
                            Stock = 100
                        },
                        new
                        {
                            Id = 4,
                            Description = "Capacitor de 22 uF",
                            Name = "Capacitor",
                            PartNumber = "C22U",
                            Stock = 1000
                        });
                });

            modelBuilder.Entity("RA.PowerSupplySystem.Domain.MaterialEntry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Batch")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EntryDate")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("ImageData")
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("MaterialId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MaterialId");

                    b.ToTable("MaterialEntries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Batch = "c256530b-adfc-4006-916a-3120933895f1",
                            EntryDate = new DateTime(2023, 9, 30, 10, 58, 6, 630, DateTimeKind.Local).AddTicks(4125),
                            MaterialId = 1,
                            Quantity = 1000
                        },
                        new
                        {
                            Id = 2,
                            Batch = "410bef14-6e7b-4714-ac3b-32c67de86c38",
                            EntryDate = new DateTime(2023, 9, 30, 10, 58, 6, 630, DateTimeKind.Local).AddTicks(4176),
                            MaterialId = 2,
                            Quantity = 100
                        },
                        new
                        {
                            Id = 3,
                            Batch = "8b82b18b-1293-43e7-8e9e-ecbab8336081",
                            EntryDate = new DateTime(2023, 9, 30, 10, 58, 6, 630, DateTimeKind.Local).AddTicks(4179),
                            MaterialId = 3,
                            Quantity = 100
                        },
                        new
                        {
                            Id = 4,
                            Batch = "f50d6f6d-7942-4d2f-b586-22df1889b858",
                            EntryDate = new DateTime(2023, 9, 30, 10, 58, 6, 630, DateTimeKind.Local).AddTicks(4181),
                            MaterialId = 4,
                            Quantity = 1000
                        });
                });

            modelBuilder.Entity("RA.PowerSupplySystem.Domain.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("OrderNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrderStatusId")
                        .HasColumnType("int");

                    b.Property<decimal>("Total")
                        .HasColumnType("money");

                    b.HasKey("Id");

                    b.HasIndex("OrderStatusId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("RA.PowerSupplySystem.Domain.OrderDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("RA.PowerSupplySystem.Domain.OrderStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Action")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ActionGifLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NextStatusId")
                        .HasColumnType("int");

                    b.Property<int?>("PreviousStatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NextStatusId");

                    b.HasIndex("PreviousStatusId");

                    b.ToTable("OrderStatuses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Action = "Producir",
                            ActionGifLink = "https://i.makeagif.com/media/12-04-2020/UrVrI_.gif",
                            Name = "En producción",
                            NextStatusId = 2
                        },
                        new
                        {
                            Id = 2,
                            Name = "En pruebas",
                            NextStatusId = 3,
                            PreviousStatusId = 1
                        },
                        new
                        {
                            Id = 3,
                            Action = "Enviar",
                            ActionGifLink = "https://media2.giphy.com/media/TIeTxUeyPeFI771jTF/giphy.gif?cid=ecf05e47nif00spqsshis5n7nfiy6t0cgyjkhn13nvdt2n33&ep=v1_gifs_search&rid=giphy.gif&ct=g",
                            Name = "En almacén",
                            NextStatusId = 4,
                            PreviousStatusId = 2
                        },
                        new
                        {
                            Id = 4,
                            Action = "Entregar",
                            ActionGifLink = "https://cdn.dribbble.com/users/5173832/screenshots/19756669/media/63c78c15a14a043b8a9ff2c8981e4fde.gif",
                            Name = "En camino",
                            NextStatusId = 5,
                            PreviousStatusId = 3
                        },
                        new
                        {
                            Id = 5,
                            Name = "Entregado",
                            PreviousStatusId = 4
                        });
                });

            modelBuilder.Entity("RA.PowerSupplySystem.Domain.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Fuente de poder de 24 Volts",
                            Name = "Fuente 24V",
                            Price = 400m
                        });
                });

            modelBuilder.Entity("RA.PowerSupplySystem.Domain.ProductMaterial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("MaterialId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MaterialId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductMaterials");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            MaterialId = 1,
                            ProductId = 1,
                            Quantity = 10
                        },
                        new
                        {
                            Id = 2,
                            MaterialId = 2,
                            ProductId = 1,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 3,
                            MaterialId = 3,
                            ProductId = 1,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 4,
                            MaterialId = 4,
                            ProductId = 1,
                            Quantity = 10
                        });
                });

            modelBuilder.Entity("RA.PowerSupplySystem.Domain.MaterialEntry", b =>
                {
                    b.HasOne("RA.PowerSupplySystem.Domain.Material", "Material")
                        .WithMany()
                        .HasForeignKey("MaterialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Material");
                });

            modelBuilder.Entity("RA.PowerSupplySystem.Domain.Order", b =>
                {
                    b.HasOne("RA.PowerSupplySystem.Domain.OrderStatus", "OrderStatus")
                        .WithMany()
                        .HasForeignKey("OrderStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OrderStatus");
                });

            modelBuilder.Entity("RA.PowerSupplySystem.Domain.OrderDetail", b =>
                {
                    b.HasOne("RA.PowerSupplySystem.Domain.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RA.PowerSupplySystem.Domain.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("RA.PowerSupplySystem.Domain.OrderStatus", b =>
                {
                    b.HasOne("RA.PowerSupplySystem.Domain.OrderStatus", "NextStatus")
                        .WithMany()
                        .HasForeignKey("NextStatusId");

                    b.HasOne("RA.PowerSupplySystem.Domain.OrderStatus", "PreviousStatus")
                        .WithMany()
                        .HasForeignKey("PreviousStatusId");

                    b.Navigation("NextStatus");

                    b.Navigation("PreviousStatus");
                });

            modelBuilder.Entity("RA.PowerSupplySystem.Domain.ProductMaterial", b =>
                {
                    b.HasOne("RA.PowerSupplySystem.Domain.Material", "Material")
                        .WithMany()
                        .HasForeignKey("MaterialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RA.PowerSupplySystem.Domain.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Material");

                    b.Navigation("Product");
                });
#pragma warning restore 612, 618
        }
    }
}
