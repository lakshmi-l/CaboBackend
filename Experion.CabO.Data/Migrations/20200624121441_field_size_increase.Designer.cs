﻿// <auto-generated />
using System;
using Experion.CabO.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Experion.CabO.Data.Migrations
{
    [DbContext(typeof(CabODbContext))]
    [Migration("20200624121441_field_size_increase")]
    partial class field_size_increase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Experion.CabO.Data.Entities.AvailableTime", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("OfficeCommutationId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("OfficeCommutationId");

                    b.ToTable("AvailableTime");
                });

            modelBuilder.Entity("Experion.CabO.Data.Entities.Cab", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("VehicleNo")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.ToTable("Cab");
                });

            modelBuilder.Entity("Experion.CabO.Data.Entities.Driver", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Driver");
                });

            modelBuilder.Entity("Experion.CabO.Data.Entities.OfficeCommutation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CabId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("Location1")
                        .HasColumnType("int");

                    b.Property<int>("Location2")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CabId");

                    b.ToTable("OfficeCommutation");
                });

            modelBuilder.Entity("Experion.CabO.Data.Entities.OfficeLocation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("OfficeLocation");
                });

            modelBuilder.Entity("Experion.CabO.Data.Entities.Rating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float?>("Behaviour")
                        .HasColumnType("real");

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float?>("Overall")
                        .HasColumnType("real");

                    b.Property<int?>("RideId")
                        .HasColumnType("int");

                    b.Property<float?>("Timing")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("RideId");

                    b.ToTable("Rating");
                });

            modelBuilder.Entity("Experion.CabO.Data.Entities.Ride", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CabType")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("CancelReason")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("ContactNo")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("ExternalCabName")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<long?>("FinalReading")
                        .HasColumnType("bigint");

                    b.Property<string>("From")
                        .HasColumnType("nvarchar(300)")
                        .HasMaxLength(300);

                    b.Property<string>("Guid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("InitialReading")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("PassengerCount")
                        .HasColumnType("int");

                    b.Property<string>("ProjectCode")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Purpose")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int?>("RideAssignmentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("RideDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("RideRequestorId")
                        .HasColumnType("int");

                    b.Property<int?>("RideStatusId")
                        .HasColumnType("int");

                    b.Property<DateTime>("RideTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("RideTypeId")
                        .HasColumnType("int");

                    b.Property<string>("To")
                        .HasColumnType("nvarchar(300)")
                        .HasMaxLength(300);

                    b.HasKey("Id");

                    b.HasIndex("RideAssignmentId");

                    b.HasIndex("RideRequestorId");

                    b.HasIndex("RideStatusId");

                    b.HasIndex("RideTypeId");

                    b.ToTable("Ride");
                });

            modelBuilder.Entity("Experion.CabO.Data.Entities.RideAssignment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CabId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DailyDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DriverId")
                        .HasColumnType("int");

                    b.Property<int?>("FinalReading")
                        .HasColumnType("int");

                    b.Property<int?>("InitialReading")
                        .HasColumnType("int");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("ShiftId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CabId");

                    b.HasIndex("DriverId");

                    b.HasIndex("ShiftId");

                    b.ToTable("RideAssignment");
                });

            modelBuilder.Entity("Experion.CabO.Data.Entities.RideRequestor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RideRequestor");
                });

            modelBuilder.Entity("Experion.CabO.Data.Entities.RideStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("StatusName")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.ToTable("RideStatus");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            StatusName = "Approved"
                        },
                        new
                        {
                            Id = 2,
                            StatusName = "Pending"
                        },
                        new
                        {
                            Id = 3,
                            StatusName = "Rejected"
                        },
                        new
                        {
                            Id = 4,
                            StatusName = "Completed"
                        },
                        new
                        {
                            Id = 5,
                            StatusName = "Cancelled"
                        });
                });

            modelBuilder.Entity("Experion.CabO.Data.Entities.RideType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("rideType")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.ToTable("RideType");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            rideType = "CABO-OFFICE"
                        },
                        new
                        {
                            Id = 2,
                            rideType = "CABO-CLIENT"
                        },
                        new
                        {
                            Id = 3,
                            rideType = "CABO-OTHERS"
                        },
                        new
                        {
                            Id = 4,
                            rideType = "CABO-ADMIN"
                        });
                });

            modelBuilder.Entity("Experion.CabO.Data.Entities.Shift", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ShiftEnd")
                        .HasColumnType("datetime2");

                    b.Property<string>("ShiftName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime>("ShiftStart")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Shift");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ShiftEnd = new DateTime(1, 1, 1, 17, 30, 0, 0, DateTimeKind.Unspecified),
                            ShiftName = "Day",
                            ShiftStart = new DateTime(1, 1, 1, 7, 30, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            ShiftEnd = new DateTime(1, 1, 1, 7, 30, 0, 0, DateTimeKind.Unspecified),
                            ShiftName = "Night",
                            ShiftStart = new DateTime(1, 1, 1, 17, 30, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Experion.CabO.Data.Entities.AvailableTime", b =>
                {
                    b.HasOne("Experion.CabO.Data.Entities.OfficeCommutation", "OfficeCommutation")
                        .WithMany("AvailableTime")
                        .HasForeignKey("OfficeCommutationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Experion.CabO.Data.Entities.OfficeCommutation", b =>
                {
                    b.HasOne("Experion.CabO.Data.Entities.Cab", "Cab")
                        .WithMany("OfficeCommutation")
                        .HasForeignKey("CabId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Experion.CabO.Data.Entities.Rating", b =>
                {
                    b.HasOne("Experion.CabO.Data.Entities.Ride", "Ride")
                        .WithMany("Rating")
                        .HasForeignKey("RideId");
                });

            modelBuilder.Entity("Experion.CabO.Data.Entities.Ride", b =>
                {
                    b.HasOne("Experion.CabO.Data.Entities.RideAssignment", "RideAssignment")
                        .WithMany("Ride")
                        .HasForeignKey("RideAssignmentId");

                    b.HasOne("Experion.CabO.Data.Entities.RideRequestor", "RideRequestor")
                        .WithMany("Ride")
                        .HasForeignKey("RideRequestorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Experion.CabO.Data.Entities.RideStatus", "RideStatus")
                        .WithMany("Ride")
                        .HasForeignKey("RideStatusId");

                    b.HasOne("Experion.CabO.Data.Entities.RideType", "RideType")
                        .WithMany("Ride")
                        .HasForeignKey("RideTypeId");
                });

            modelBuilder.Entity("Experion.CabO.Data.Entities.RideAssignment", b =>
                {
                    b.HasOne("Experion.CabO.Data.Entities.Cab", "Cab")
                        .WithMany("RideAssignment")
                        .HasForeignKey("CabId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Experion.CabO.Data.Entities.Driver", "Driver")
                        .WithMany("RideAssignment")
                        .HasForeignKey("DriverId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Experion.CabO.Data.Entities.Shift", "Shift")
                        .WithMany("RideAssignment")
                        .HasForeignKey("ShiftId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
