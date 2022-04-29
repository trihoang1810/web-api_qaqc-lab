﻿// <auto-generated />
using System;
using ChaQaQcLabApi.Infrastructure.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ChaQaQcLabApi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220428024158_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.HasSequence("EntityFrameworkHiLoSequence")
                .IncrementsBy(10);

            modelBuilder.Entity("ChaQaQcLabApi.Domain.Models.CurlingForce.CurlingForceTest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseHiLo(b.Property<int>("Id"), "EntityFrameworkHiLoSequence");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("ProductId")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("TestPurpose")
                        .HasColumnType("int");

                    b.Property<string>("TesterEmployeeId")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("ProductId");

                    b.HasIndex("TesterEmployeeId");

                    b.ToTable("CurlingForceTests");
                });

            modelBuilder.Entity("ChaQaQcLabApi.Domain.Models.ForcedClose.ForcedCloseTest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseHiLo(b.Property<int>("Id"), "EntityFrameworkHiLoSequence");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("ProductId")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("TestPurpose")
                        .HasColumnType("int");

                    b.Property<string>("TesterEmployeeId")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("ProductId");

                    b.HasIndex("TesterEmployeeId");

                    b.ToTable("ForcedCloseTests");
                });

            modelBuilder.Entity("ChaQaQcLabApi.Domain.Models.Product", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("Products");
                });

            modelBuilder.Entity("ChaQaQcLabApi.Domain.Models.Rock.RockTest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseHiLo(b.Property<int>("Id"), "EntityFrameworkHiLoSequence");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("ProductId")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("TestPurpose")
                        .HasColumnType("int");

                    b.Property<string>("TesterEmployeeId")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("ProductId");

                    b.HasIndex("TesterEmployeeId");

                    b.ToTable("RockTests");
                });

            modelBuilder.Entity("ChaQaQcLabApi.Domain.Models.SoftClose.SoftCloseTest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseHiLo(b.Property<int>("Id"), "EntityFrameworkHiLoSequence");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("ProductId")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("TestPurpose")
                        .HasColumnType("int");

                    b.Property<string>("TesterEmployeeId")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("ProductId");

                    b.HasIndex("TesterEmployeeId");

                    b.ToTable("SoftCloseTests");
                });

            modelBuilder.Entity("ChaQaQcLabApi.Domain.Models.StaticLoad.StaticLoadTest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseHiLo(b.Property<int>("Id"), "EntityFrameworkHiLoSequence");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("ProductId")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("TestPurpose")
                        .HasColumnType("int");

                    b.Property<string>("TesterEmployeeId")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("ProductId");

                    b.HasIndex("TesterEmployeeId");

                    b.ToTable("StaticLoadTests");
                });

            modelBuilder.Entity("ChaQaQcLabApi.Domain.Models.Tester", b =>
                {
                    b.Property<string>("EmployeeId")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("EmployeeId");

                    b.HasIndex("EmployeeId")
                        .IsUnique();

                    b.ToTable("Tester");
                });

            modelBuilder.Entity("ChaQaQcLabApi.Domain.Models.CurlingForce.CurlingForceTest", b =>
                {
                    b.HasOne("ChaQaQcLabApi.Domain.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ChaQaQcLabApi.Domain.Models.Tester", "Tester")
                        .WithMany()
                        .HasForeignKey("TesterEmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsMany("ChaQaQcLabApi.Domain.Models.CurlingForce.CurlingForceTestSample", "Samples", b1 =>
                        {
                            b1.Property<int>("CurlingForceTestId")
                                .HasColumnType("int");

                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int");

                            SqlServerPropertyBuilderExtensions.UseIdentityColumn(b1.Property<int>("Id"), 1L, 1);

                            b1.Property<double>("DeformationDegree")
                                .HasColumnType("float");

                            b1.Property<int>("Duration")
                                .HasColumnType("int");

                            b1.Property<double>("Load")
                                .HasColumnType("float");

                            b1.Property<string>("Note")
                                .IsRequired()
                                .HasMaxLength(256)
                                .HasColumnType("nvarchar(256)");

                            b1.Property<int>("NumberOfErrors")
                                .HasColumnType("int");

                            b1.Property<int>("SampleNumber")
                                .HasColumnType("int");

                            b1.HasKey("CurlingForceTestId", "Id");

                            b1.ToTable("CurlingForceTestSamples");

                            b1.WithOwner()
                                .HasForeignKey("CurlingForceTestId");
                        });

                    b.Navigation("Product");

                    b.Navigation("Samples");

                    b.Navigation("Tester");
                });

            modelBuilder.Entity("ChaQaQcLabApi.Domain.Models.ForcedClose.ForcedCloseTest", b =>
                {
                    b.HasOne("ChaQaQcLabApi.Domain.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ChaQaQcLabApi.Domain.Models.Tester", "Tester")
                        .WithMany()
                        .HasForeignKey("TesterEmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("ChaQaQcLabApi.Domain.Models.ForcedClose.ForcedCloseTestSampleResult", "ExpectedOutcome", b1 =>
                        {
                            b1.Property<int>("ForcedCloseTestId")
                                .HasColumnType("int");

                            b1.Property<int>("FallTime")
                                .HasColumnType("int");

                            b1.Property<bool>("IsIntact")
                                .HasColumnType("bit");

                            b1.Property<bool>("IsUnleaked")
                                .HasColumnType("bit");

                            b1.Property<bool>("Passed")
                                .HasColumnType("bit");

                            b1.HasKey("ForcedCloseTestId");

                            b1.ToTable("ForcedCloseTests");

                            b1.WithOwner()
                                .HasForeignKey("ForcedCloseTestId");
                        });

                    b.OwnsMany("ChaQaQcLabApi.Domain.Models.ForcedClose.ForcedCloseTestSample", "Samples", b1 =>
                        {
                            b1.Property<int>("ForcedCloseTestId")
                                .HasColumnType("int");

                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int");

                            SqlServerPropertyBuilderExtensions.UseIdentityColumn(b1.Property<int>("Id"), 1L, 1);

                            b1.Property<string>("Note")
                                .IsRequired()
                                .HasMaxLength(256)
                                .HasColumnType("nvarchar(256)");

                            b1.Property<int>("SampleNumber")
                                .HasColumnType("int");

                            b1.HasKey("ForcedCloseTestId", "Id");

                            b1.ToTable("ForcedCloseTestSamples");

                            b1.WithOwner()
                                .HasForeignKey("ForcedCloseTestId");

                            b1.OwnsOne("ChaQaQcLabApi.Domain.Models.ForcedClose.ForcedCloseTestSampleResult", "Result", b2 =>
                                {
                                    b2.Property<int>("ForcedCloseTestSampleForcedCloseTestId")
                                        .HasColumnType("int");

                                    b2.Property<int>("ForcedCloseTestSampleId")
                                        .HasColumnType("int");

                                    b2.Property<int>("FallTime")
                                        .HasColumnType("int");

                                    b2.Property<bool>("IsIntact")
                                        .HasColumnType("bit");

                                    b2.Property<bool>("IsUnleaked")
                                        .HasColumnType("bit");

                                    b2.Property<bool>("Passed")
                                        .HasColumnType("bit");

                                    b2.HasKey("ForcedCloseTestSampleForcedCloseTestId", "ForcedCloseTestSampleId");

                                    b2.ToTable("ForcedCloseTestSamples");

                                    b2.WithOwner()
                                        .HasForeignKey("ForcedCloseTestSampleForcedCloseTestId", "ForcedCloseTestSampleId");
                                });

                            b1.Navigation("Result")
                                .IsRequired();
                        });

                    b.Navigation("ExpectedOutcome")
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Samples");

                    b.Navigation("Tester");
                });

            modelBuilder.Entity("ChaQaQcLabApi.Domain.Models.Rock.RockTest", b =>
                {
                    b.HasOne("ChaQaQcLabApi.Domain.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ChaQaQcLabApi.Domain.Models.Tester", "Tester")
                        .WithMany()
                        .HasForeignKey("TesterEmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsMany("ChaQaQcLabApi.Domain.Models.Rock.RockTestSample", "Samples", b1 =>
                        {
                            b1.Property<int>("RockTestId")
                                .HasColumnType("int");

                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int");

                            SqlServerPropertyBuilderExtensions.UseIdentityColumn(b1.Property<int>("Id"), 1L, 1);

                            b1.Property<double>("Load")
                                .HasColumnType("float");

                            b1.Property<string>("Note")
                                .IsRequired()
                                .HasMaxLength(256)
                                .HasColumnType("nvarchar(256)");

                            b1.Property<int>("NumberOfErrors")
                                .HasColumnType("int");

                            b1.Property<bool>("Passed")
                                .HasColumnType("bit");

                            b1.Property<int>("TestedTimes")
                                .HasColumnType("int");

                            b1.HasKey("RockTestId", "Id");

                            b1.ToTable("RockTestSamples");

                            b1.WithOwner()
                                .HasForeignKey("RockTestId");
                        });

                    b.Navigation("Product");

                    b.Navigation("Samples");

                    b.Navigation("Tester");
                });

            modelBuilder.Entity("ChaQaQcLabApi.Domain.Models.SoftClose.SoftCloseTest", b =>
                {
                    b.HasOne("ChaQaQcLabApi.Domain.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ChaQaQcLabApi.Domain.Models.Tester", "Tester")
                        .WithMany()
                        .HasForeignKey("TesterEmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("ChaQaQcLabApi.Domain.Models.SoftClose.SoftCloseTestSampleResult", "SeatLidExpectedOutcome", b1 =>
                        {
                            b1.Property<int>("SoftCloseTestId")
                                .HasColumnType("int");

                            b1.Property<int>("FallTime")
                                .HasColumnType("int");

                            b1.Property<bool>("IsBumperIntact")
                                .HasColumnType("bit");

                            b1.Property<bool>("IsUnleaked")
                                .HasColumnType("bit");

                            b1.Property<bool>("Passed")
                                .HasColumnType("bit");

                            b1.HasKey("SoftCloseTestId");

                            b1.ToTable("SoftCloseTests");

                            b1.WithOwner()
                                .HasForeignKey("SoftCloseTestId");
                        });

                    b.OwnsOne("ChaQaQcLabApi.Domain.Models.SoftClose.SoftCloseTestSampleResult", "SeatRingExpectedOutcome", b1 =>
                        {
                            b1.Property<int>("SoftCloseTestId")
                                .HasColumnType("int");

                            b1.Property<int>("FallTime")
                                .HasColumnType("int");

                            b1.Property<bool>("IsBumperIntact")
                                .HasColumnType("bit");

                            b1.Property<bool>("IsUnleaked")
                                .HasColumnType("bit");

                            b1.Property<bool>("Passed")
                                .HasColumnType("bit");

                            b1.HasKey("SoftCloseTestId");

                            b1.ToTable("SoftCloseTests");

                            b1.WithOwner()
                                .HasForeignKey("SoftCloseTestId");
                        });

                    b.OwnsMany("ChaQaQcLabApi.Domain.Models.SoftClose.SoftCloseTestSample", "Samples", b1 =>
                        {
                            b1.Property<int>("SoftCloseTestId")
                                .HasColumnType("int");

                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int");

                            SqlServerPropertyBuilderExtensions.UseIdentityColumn(b1.Property<int>("Id"), 1L, 1);

                            b1.Property<string>("Note")
                                .IsRequired()
                                .HasMaxLength(256)
                                .HasColumnType("nvarchar(256)");

                            b1.Property<int>("SampleNumber")
                                .HasColumnType("int");

                            b1.HasKey("SoftCloseTestId", "Id");

                            b1.ToTable("SoftCloseTestSamples");

                            b1.WithOwner()
                                .HasForeignKey("SoftCloseTestId");

                            b1.OwnsOne("ChaQaQcLabApi.Domain.Models.SoftClose.SoftCloseTestSampleResult", "SeatLidResult", b2 =>
                                {
                                    b2.Property<int>("SoftCloseTestSampleSoftCloseTestId")
                                        .HasColumnType("int");

                                    b2.Property<int>("SoftCloseTestSampleId")
                                        .HasColumnType("int");

                                    b2.Property<int>("FallTime")
                                        .HasColumnType("int");

                                    b2.Property<bool>("IsBumperIntact")
                                        .HasColumnType("bit");

                                    b2.Property<bool>("IsUnleaked")
                                        .HasColumnType("bit");

                                    b2.Property<bool>("Passed")
                                        .HasColumnType("bit");

                                    b2.HasKey("SoftCloseTestSampleSoftCloseTestId", "SoftCloseTestSampleId");

                                    b2.ToTable("SoftCloseTestSamples");

                                    b2.WithOwner()
                                        .HasForeignKey("SoftCloseTestSampleSoftCloseTestId", "SoftCloseTestSampleId");
                                });

                            b1.OwnsOne("ChaQaQcLabApi.Domain.Models.SoftClose.SoftCloseTestSampleResult", "SeatRingResult", b2 =>
                                {
                                    b2.Property<int>("SoftCloseTestSampleSoftCloseTestId")
                                        .HasColumnType("int");

                                    b2.Property<int>("SoftCloseTestSampleId")
                                        .HasColumnType("int");

                                    b2.Property<int>("FallTime")
                                        .HasColumnType("int");

                                    b2.Property<bool>("IsBumperIntact")
                                        .HasColumnType("bit");

                                    b2.Property<bool>("IsUnleaked")
                                        .HasColumnType("bit");

                                    b2.Property<bool>("Passed")
                                        .HasColumnType("bit");

                                    b2.HasKey("SoftCloseTestSampleSoftCloseTestId", "SoftCloseTestSampleId");

                                    b2.ToTable("SoftCloseTestSamples");

                                    b2.WithOwner()
                                        .HasForeignKey("SoftCloseTestSampleSoftCloseTestId", "SoftCloseTestSampleId");
                                });

                            b1.Navigation("SeatLidResult")
                                .IsRequired();

                            b1.Navigation("SeatRingResult")
                                .IsRequired();
                        });

                    b.Navigation("Product");

                    b.Navigation("Samples");

                    b.Navigation("SeatLidExpectedOutcome")
                        .IsRequired();

                    b.Navigation("SeatRingExpectedOutcome")
                        .IsRequired();

                    b.Navigation("Tester");
                });

            modelBuilder.Entity("ChaQaQcLabApi.Domain.Models.StaticLoad.StaticLoadTest", b =>
                {
                    b.HasOne("ChaQaQcLabApi.Domain.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ChaQaQcLabApi.Domain.Models.Tester", "Tester")
                        .WithMany()
                        .HasForeignKey("TesterEmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsMany("ChaQaQcLabApi.Domain.Models.StaticLoad.StaticLoadTestSample", "Samples", b1 =>
                        {
                            b1.Property<int>("StaticLoadTestId")
                                .HasColumnType("int");

                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int");

                            SqlServerPropertyBuilderExtensions.UseIdentityColumn(b1.Property<int>("Id"), 1L, 1);

                            b1.Property<string>("Note")
                                .IsRequired()
                                .HasMaxLength(256)
                                .HasColumnType("nvarchar(256)");

                            b1.Property<int>("NumberOfErrors")
                                .HasColumnType("int");

                            b1.Property<string>("Status")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("StaticLoadTestId", "Id");

                            b1.ToTable("StaticLoadTestSamples");

                            b1.WithOwner()
                                .HasForeignKey("StaticLoadTestId");
                        });

                    b.Navigation("Product");

                    b.Navigation("Samples");

                    b.Navigation("Tester");
                });
#pragma warning restore 612, 618
        }
    }
}
