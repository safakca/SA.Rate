﻿// <auto-generated />
using System;
using CRM.DataAccess.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CRM.DataAccess.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CRM.Entity.Concrete.Rate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Stopped")
                        .HasColumnType("bit")
                        .HasColumnName("Stopped");

                    b.HasKey("Id");

                    b.ToTable("Rates");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Rate1",
                            Stopped = true
                        },
                        new
                        {
                            Id = 2,
                            Name = "Rate2",
                            Stopped = false
                        });
                });

            modelBuilder.Entity("CRM.Entity.Concrete.RateQN", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("EQNType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("EQNType");

                    b.Property<int>("RateId")
                        .HasColumnType("int");

                    b.Property<int>("TranslationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RateId");

                    b.ToTable("RateQNs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EQNType = "Star",
                            RateId = 1,
                            TranslationId = 1
                        },
                        new
                        {
                            Id = 2,
                            EQNType = "Star",
                            RateId = 1,
                            TranslationId = 1
                        },
                        new
                        {
                            Id = 3,
                            EQNType = "Star",
                            RateId = 1,
                            TranslationId = 1
                        },
                        new
                        {
                            Id = 4,
                            EQNType = "Star",
                            RateId = 2,
                            TranslationId = 2
                        },
                        new
                        {
                            Id = 5,
                            EQNType = "Star",
                            RateId = 2,
                            TranslationId = 2
                        },
                        new
                        {
                            Id = 6,
                            EQNType = "Star",
                            RateId = 2,
                            TranslationId = 2
                        },
                        new
                        {
                            Id = 7,
                            EQNType = "Star",
                            RateId = 2,
                            TranslationId = 2
                        });
                });

            modelBuilder.Entity("CRM.Entity.Concrete.RateResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreatedOn");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasColumnName("Notes");

                    b.Property<int>("RateId")
                        .HasColumnType("int");

                    b.Property<int?>("TaskId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("RateResults");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "1",
                            CreatedOn = new DateTime(2022, 11, 6, 19, 50, 31, 805, DateTimeKind.Local).AddTicks(6781),
                            CustomerId = 1,
                            Notes = "Test1",
                            RateId = 1,
                            TaskId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "2",
                            CreatedOn = new DateTime(2022, 11, 6, 19, 50, 31, 805, DateTimeKind.Local).AddTicks(6794),
                            CustomerId = 2,
                            Notes = "Test2",
                            RateId = 2,
                            TaskId = 2
                        });
                });

            modelBuilder.Entity("CRM.Entity.Concrete.RateResultDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("RateQNId")
                        .HasColumnType("int");

                    b.Property<int>("RateResultId")
                        .HasColumnType("int");

                    b.Property<int>("ValueInt")
                        .HasColumnType("int")
                        .HasColumnName("ValueInt");

                    b.Property<string>("ValueString")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ValueString");

                    b.HasKey("Id");

                    b.HasIndex("RateQNId");

                    b.HasIndex("RateResultId");

                    b.ToTable("RateResultDetails");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            RateQNId = 1,
                            RateResultId = 1,
                            ValueInt = 1,
                            ValueString = "test1"
                        },
                        new
                        {
                            Id = 2,
                            RateQNId = 2,
                            RateResultId = 2,
                            ValueInt = 1,
                            ValueString = "test"
                        });
                });

            modelBuilder.Entity("CRM.Entity.Concrete.Translation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)")
                        .HasColumnName("Text");

                    b.HasKey("Id");

                    b.ToTable("Translations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Text = "TR"
                        },
                        new
                        {
                            Id = 2,
                            Text = "EN"
                        });
                });

            modelBuilder.Entity("CRM.Entity.Concrete.RateQN", b =>
                {
                    b.HasOne("CRM.Entity.Concrete.Rate", null)
                        .WithMany("RateQNs")
                        .HasForeignKey("RateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CRM.Entity.Concrete.RateResultDetail", b =>
                {
                    b.HasOne("CRM.Entity.Concrete.RateQN", "RateQN")
                        .WithMany("RateResultDetails")
                        .HasForeignKey("RateQNId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CRM.Entity.Concrete.RateResult", null)
                        .WithMany("RateResultDetails")
                        .HasForeignKey("RateResultId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RateQN");
                });

            modelBuilder.Entity("CRM.Entity.Concrete.Rate", b =>
                {
                    b.Navigation("RateQNs");
                });

            modelBuilder.Entity("CRM.Entity.Concrete.RateQN", b =>
                {
                    b.Navigation("RateResultDetails");
                });

            modelBuilder.Entity("CRM.Entity.Concrete.RateResult", b =>
                {
                    b.Navigation("RateResultDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
