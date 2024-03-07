﻿// <auto-generated />
using System;
using Backend_SoftGNet.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Backend_SoftGNet.Migrations
{
    [DbContext(typeof(dataContext))]
    [Migration("20240307193257_ChangeNameDescription")]
    partial class ChangeNameDescription
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Backend_SoftGNet.Models.Drivers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Active")
                        .HasColumnType("bit")
                        .HasColumnOrder(10);

                    b.Property<string>("Address")
                        .HasColumnType("varchar(100)")
                        .HasColumnOrder(6);

                    b.Property<string>("City")
                        .HasColumnType("varchar(100)")
                        .HasColumnOrder(7);

                    b.Property<DateTime>("Dob")
                        .HasColumnType("date")
                        .HasColumnOrder(5);

                    b.Property<string>("First_name")
                        .IsRequired()
                        .HasColumnType("varchar(200)")
                        .HasColumnOrder(3);

                    b.Property<string>("Last_name")
                        .IsRequired()
                        .HasColumnType("varchar(max)")
                        .HasColumnOrder(2);

                    b.Property<int?>("Phone")
                        .HasColumnType("int")
                        .HasColumnOrder(9);

                    b.Property<string>("Ssn")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnOrder(4);

                    b.Property<string>("Zip")
                        .HasColumnType("varchar(100)")
                        .HasColumnOrder(8);

                    b.HasKey("Id");

                    b.ToTable("Drivers");
                });

            modelBuilder.Entity("Backend_SoftGNet.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(max)")
                        .HasColumnOrder(3);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnOrder(2);

                    b.HasKey("Id");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("Backend_SoftGNet.Models.Routes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Active")
                        .HasColumnType("bit")
                        .HasColumnOrder(5);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(max)")
                        .HasColumnOrder(2);

                    b.Property<int>("Driver_Id")
                        .HasColumnType("int")
                        .HasColumnOrder(3);

                    b.Property<int>("Vehicle_Id")
                        .HasColumnType("int")
                        .HasColumnOrder(4);

                    b.HasKey("Id");

                    b.HasIndex("Driver_Id");

                    b.HasIndex("Vehicle_Id");

                    b.ToTable("Route");
                });

            modelBuilder.Entity("Backend_SoftGNet.Models.Schedules", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Active")
                        .HasColumnType("bit")
                        .HasColumnOrder(6);

                    b.Property<DateTime>("From")
                        .HasColumnType("datetime")
                        .HasColumnOrder(4);

                    b.Property<int>("Route_Id")
                        .HasColumnType("int")
                        .HasColumnOrder(2);

                    b.Property<DateTime>("To")
                        .HasColumnType("datetime")
                        .HasColumnOrder(5);

                    b.Property<int>("Week_Num")
                        .HasColumnType("int")
                        .HasColumnOrder(3);

                    b.HasKey("Id");

                    b.HasIndex("Route_Id");

                    b.ToTable("Schedules");
                });

            modelBuilder.Entity("Backend_SoftGNet.Models.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Active")
                        .HasColumnType("bit")
                        .HasColumnOrder(6);

                    b.Property<int>("Role_Id")
                        .HasColumnType("int")
                        .HasColumnOrder(5);

                    b.Property<string>("User_Email")
                        .HasColumnType("varchar(200)")
                        .HasColumnOrder(3);

                    b.Property<string>("User_Name")
                        .IsRequired()
                        .HasColumnType("varchar(200)")
                        .HasColumnOrder(2);

                    b.Property<string>("User_Password")
                        .IsRequired()
                        .HasColumnType("varchar(max)")
                        .HasColumnOrder(4);

                    b.HasKey("Id");

                    b.HasIndex("Role_Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Backend_SoftGNet.Models.Vehicles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Active")
                        .HasColumnType("bit")
                        .HasColumnOrder(6);

                    b.Property<int>("Capacity")
                        .HasColumnType("int")
                        .HasColumnOrder(5);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(200)")
                        .HasColumnOrder(2);

                    b.Property<int>("Make")
                        .HasColumnType("int")
                        .HasColumnOrder(4);

                    b.Property<int>("Year")
                        .HasColumnType("int")
                        .HasColumnOrder(3);

                    b.HasKey("Id");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("Backend_SoftGNet.Models.Routes", b =>
                {
                    b.HasOne("Backend_SoftGNet.Models.Drivers", "Drivers")
                        .WithMany()
                        .HasForeignKey("Driver_Id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Backend_SoftGNet.Models.Vehicles", "Vehicles")
                        .WithMany()
                        .HasForeignKey("Vehicle_Id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Drivers");

                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("Backend_SoftGNet.Models.Schedules", b =>
                {
                    b.HasOne("Backend_SoftGNet.Models.Routes", "Route")
                        .WithMany()
                        .HasForeignKey("Route_Id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Route");
                });

            modelBuilder.Entity("Backend_SoftGNet.Models.Users", b =>
                {
                    b.HasOne("Backend_SoftGNet.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("Role_Id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Role");
                });
#pragma warning restore 612, 618
        }
    }
}
