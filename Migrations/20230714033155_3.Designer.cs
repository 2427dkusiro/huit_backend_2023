﻿// <auto-generated />
using System;
using API;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace 新しいフォルダー.Migrations
{
    [DbContext(typeof(MyDBContext))]
    [Migration("20230714033155_3")]
    partial class _3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("API.UserAmount", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("Amount")
                        .HasColumnType("bigint")
                        .HasColumnName("amount");

                    b.Property<long?>("UserInfoId")
                        .HasColumnType("bigint")
                        .HasColumnName("user_info_id");

                    b.HasKey("Id")
                        .HasName("pk_user_amount");

                    b.HasIndex("UserInfoId")
                        .HasDatabaseName("ix_user_amount_user_info_id");

                    b.ToTable("user_amount", (string)null);
                });

            modelBuilder.Entity("API.UserInfo", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("pk_user_info");

                    b.ToTable("user_info", (string)null);
                });

            modelBuilder.Entity("API.UserAmount", b =>
                {
                    b.HasOne("API.UserInfo", "UserInfo")
                        .WithMany()
                        .HasForeignKey("UserInfoId")
                        .HasConstraintName("fk_user_amount_user_info_user_info_id");

                    b.Navigation("UserInfo");
                });
#pragma warning restore 612, 618
        }
    }
}
