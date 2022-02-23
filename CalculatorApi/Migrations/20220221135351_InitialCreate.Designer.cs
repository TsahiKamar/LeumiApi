﻿// <auto-generated />
using Api.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220221135351_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Api.DataAccess.Calculations_2", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<double>("num1")
                        .HasColumnType("float")
                        .HasColumnName("num1");

                    b.Property<double>("num2")
                        .HasColumnType("float")
                        .HasColumnName("num2");

                    b.Property<string>("oper")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)")
                        .HasColumnName("oper");

                    b.Property<double>("result")
                        .HasColumnType("float")
                        .HasColumnName("result");

                    b.HasKey("id");

                    b.ToTable("Calculations_", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
