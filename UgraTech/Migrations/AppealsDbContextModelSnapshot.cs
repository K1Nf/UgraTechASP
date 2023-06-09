﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using UgraTech.Context;

#nullable disable

namespace UgraTech.Migrations
{
    [DbContext(typeof(AppealsDbContext))]
    partial class AppealsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("UgraTech.Models.Appeals", b =>
                {
                    b.Property<int>("Appeal_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Appeal_ID"));

                    b.Property<int>("Email")
                        .HasColumnType("integer");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("Phone_Number")
                        .HasColumnType("integer");

                    b.Property<bool?>("Status")
                        .HasColumnType("boolean");

                    b.HasKey("Appeal_ID");

                    b.ToTable("Appeals");
                });
#pragma warning restore 612, 618
        }
    }
}
