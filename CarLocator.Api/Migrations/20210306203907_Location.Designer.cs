﻿// <auto-generated />
using System;
using CarLocator.Api.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CarLocator.Api.Migrations
{
    [DbContext(typeof(VehicleLocatorDbContext))]
    [Migration("20210306203907_Location")]
    partial class Location
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CarLocator.Api.Vehicles.Entities.Vehicle", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("CarLocator.Api.Vehicles.Entities.Vehicle", b =>
                {
                    b.OwnsOne("CarLocator.Api.Vehicles.Entities.Location", "MostRecentLocation", b1 =>
                        {
                            b1.Property<Guid>("VehicleId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<double>("Lat")
                                .HasColumnType("float");

                            b1.Property<double>("Lon")
                                .HasColumnType("float");

                            b1.HasKey("VehicleId");

                            b1.ToTable("Vehicles");

                            b1.WithOwner()
                                .HasForeignKey("VehicleId");
                        });

                    b.Navigation("MostRecentLocation");
                });
#pragma warning restore 612, 618
        }
    }
}
