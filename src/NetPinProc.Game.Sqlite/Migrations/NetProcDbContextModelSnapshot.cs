﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetPinProc.Game.Sqlite;

namespace NetPinProc.Game.Sqlite.Migrations
{
    [DbContext(typeof(NetProcDbContext))]
    partial class NetProcDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("NetPinProc.Game.Sqlite.Model.Adjustment", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("MenuName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("OptionType")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Options")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SubMenuName")
                        .HasColumnType("TEXT");

                    b.Property<int>("Value")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ValueDefault")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("Adjustments");
                });

            modelBuilder.Entity("NetPinProc.Game.Sqlite.Model.Audit", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Value")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Audits");
                });

            modelBuilder.Entity("NetPinProc.Game.Sqlite.Model.BallPlayed", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<byte>("Ball")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PlayerId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("Points")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ScoreId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Time")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("PlayerId");

                    b.HasIndex("ScoreId");

                    b.ToTable("BallsPlayed");
                });

            modelBuilder.Entity("NetPinProc.Game.Sqlite.Model.ColorSet", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("TEXT")
                        .HasMaxLength(6);

                    b.Property<string>("HtmlCode")
                        .HasColumnType("TEXT");

                    b.HasKey("Name");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Colors");

                    b.HasData(
                        new
                        {
                            Name = "BLK",
                            HtmlCode = "010101"
                        },
                        new
                        {
                            Name = "WHT",
                            HtmlCode = "FEFEFE"
                        },
                        new
                        {
                            Name = "BLU",
                            HtmlCode = "0155FE"
                        },
                        new
                        {
                            Name = "RED",
                            HtmlCode = "FF0000"
                        },
                        new
                        {
                            Name = "YEL",
                            HtmlCode = "EDFE01"
                        },
                        new
                        {
                            Name = "ORG",
                            HtmlCode = "FE9001"
                        },
                        new
                        {
                            Name = "GRN",
                            HtmlCode = "3CDF13"
                        },
                        new
                        {
                            Name = "VIO",
                            HtmlCode = "A913DF"
                        });
                });

            modelBuilder.Entity("NetPinProc.Game.Sqlite.Model.GamePlayed", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Adjustments")
                        .HasColumnType("TEXT");

                    b.Property<byte>("BallsPerGame")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Ended")
                        .HasColumnType("TEXT");

                    b.Property<double>("GameTime")
                        .HasColumnType("DOUBLE(18, 2)");

                    b.Property<DateTime>("Started")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("GamesPlayed");
                });

            modelBuilder.Entity("NetPinProc.Game.Sqlite.Model.Machine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("DisplayMonitor")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MachineType")
                        .HasColumnType("INTEGER");

                    b.Property<int>("NumBalls")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<string>("Version")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Machine");
                });

            modelBuilder.Entity("NetPinProc.Game.Sqlite.Model.Part", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<decimal?>("Cost")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Height")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Material")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PartNo")
                        .HasColumnType("TEXT");

                    b.Property<int?>("PartType")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Shape")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Width")
                        .HasColumnType("INTEGER");

                    b.Property<double?>("XPos")
                        .HasColumnType("REAL");

                    b.Property<double?>("YPos")
                        .HasColumnType("REAL");

                    b.Property<double?>("ZPos")
                        .HasColumnType("REAL");

                    b.HasKey("Name");

                    b.ToTable("Parts");
                });

            modelBuilder.Entity("NetPinProc.Game.Sqlite.Model.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Default")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Initials")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Name", "Initials")
                        .IsUnique();

                    b.ToTable("Players");
                });

            modelBuilder.Entity("NetPinProc.Game.Sqlite.Model.Score", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<byte>("ExtraBallsPlayed")
                        .HasColumnType("INTEGER");

                    b.Property<int>("GamePlayedId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PlayerId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("Points")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("GamePlayedId");

                    b.HasIndex("PlayerId");

                    b.ToTable("Scores");
                });

            modelBuilder.Entity("NetPinProc.Domain.MachineConfig.CoilConfigFileEntry", b =>
                {
                    b.Property<string>("Number")
                        .HasColumnType("TEXT");

                    b.Property<string>("Bus")
                        .HasColumnType("TEXT");

                    b.Property<string>("Conn")
                        .HasColumnType("TEXT");

                    b.Property<string>("DisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("ItemType")
                        .HasColumnType("TEXT");

                    b.Property<string>("Location")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Polarity")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PulseTime")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ReturnWire")
                        .HasColumnType("TEXT");

                    b.Property<int>("Search")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Tags")
                        .HasColumnType("TEXT");

                    b.Property<byte?>("Voltage")
                        .HasColumnType("INTEGER");

                    b.Property<string>("VoltageWire")
                        .HasColumnType("TEXT");

                    b.Property<double?>("XPos")
                        .HasColumnType("REAL");

                    b.Property<double?>("YPos")
                        .HasColumnType("REAL");

                    b.HasKey("Number");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.HasIndex("Number")
                        .IsUnique();

                    b.ToTable("Coils");
                });

            modelBuilder.Entity("NetPinProc.Domain.MachineConfig.LampConfigFileEntry", b =>
                {
                    b.Property<string>("Number")
                        .HasColumnType("TEXT");

                    b.Property<string>("Bus")
                        .HasColumnType("TEXT");

                    b.Property<string>("Conn")
                        .HasColumnType("TEXT");

                    b.Property<string>("DisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("ItemType")
                        .HasColumnType("TEXT");

                    b.Property<string>("Location")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Polarity")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Tags")
                        .HasColumnType("TEXT");

                    b.Property<double?>("XPos")
                        .HasColumnType("REAL");

                    b.Property<double?>("YPos")
                        .HasColumnType("REAL");

                    b.HasKey("Number");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.HasIndex("Number")
                        .IsUnique();

                    b.ToTable("Lamps");
                });

            modelBuilder.Entity("NetPinProc.Domain.MachineConfig.LedConfigFileEntry", b =>
                {
                    b.Property<string>("Number")
                        .HasColumnType("TEXT");

                    b.Property<string>("Bus")
                        .HasColumnType("TEXT");

                    b.Property<string>("Conn")
                        .HasColumnType("TEXT");

                    b.Property<string>("DisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("ItemType")
                        .HasColumnType("TEXT");

                    b.Property<string>("Location")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Polarity")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Tags")
                        .HasColumnType("TEXT");

                    b.Property<double?>("XPos")
                        .HasColumnType("REAL");

                    b.Property<double?>("YPos")
                        .HasColumnType("REAL");

                    b.HasKey("Number");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.HasIndex("Number")
                        .IsUnique();

                    b.ToTable("Leds");
                });

            modelBuilder.Entity("NetPinProc.Domain.MachineConfig.Lpd8806ConfigFileEntry", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<byte>("BoardId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Conn")
                        .HasColumnType("TEXT");

                    b.Property<string>("DisplayName")
                        .HasColumnType("TEXT");

                    b.Property<uint>("First")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Index")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ItemType")
                        .HasColumnType("TEXT");

                    b.Property<uint>("Last")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Location")
                        .HasColumnType("TEXT");

                    b.Property<double?>("XPos")
                        .HasColumnType("REAL");

                    b.Property<double?>("YPos")
                        .HasColumnType("REAL");

                    b.HasKey("Name");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.HasIndex("BoardId", "Index")
                        .IsUnique();

                    b.ToTable("Lpd8806Leds");
                });

            modelBuilder.Entity("NetPinProc.Domain.MachineConfig.ServoConfigFileEntry", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<byte>("BoardId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Conn")
                        .HasColumnType("TEXT");

                    b.Property<string>("DisplayName")
                        .HasColumnType("TEXT");

                    b.Property<uint>("Index")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ItemType")
                        .HasColumnType("TEXT");

                    b.Property<string>("Location")
                        .HasColumnType("TEXT");

                    b.Property<int>("MinValue")
                        .HasColumnType("INTEGER");

                    b.Property<double?>("XPos")
                        .HasColumnType("REAL");

                    b.Property<double?>("YPos")
                        .HasColumnType("REAL");

                    b.HasKey("Name");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.HasIndex("BoardId", "Index")
                        .IsUnique();

                    b.ToTable("Servos");
                });

            modelBuilder.Entity("NetPinProc.Domain.MachineConfig.StepperConfigFileEntry", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<byte>("BoardId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Conn")
                        .HasColumnType("TEXT");

                    b.Property<string>("DisplayName")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsStepper1")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ItemType")
                        .HasColumnType("TEXT");

                    b.Property<string>("Location")
                        .HasColumnType("TEXT");

                    b.Property<uint>("Speed")
                        .HasColumnType("INTEGER");

                    b.Property<double?>("XPos")
                        .HasColumnType("REAL");

                    b.Property<double?>("YPos")
                        .HasColumnType("REAL");

                    b.HasKey("Name");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.HasIndex("BoardId", "IsStepper1")
                        .IsUnique();

                    b.ToTable("Steppers");
                });

            modelBuilder.Entity("NetPinProc.Domain.MachineConfig.SwitchConfigFileEntry", b =>
                {
                    b.Property<string>("Number")
                        .HasColumnType("TEXT");

                    b.Property<string>("Conn")
                        .HasColumnType("TEXT");

                    b.Property<string>("DisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("GroundWire")
                        .HasColumnType("TEXT");

                    b.Property<string>("InputWire")
                        .HasColumnType("TEXT");

                    b.Property<string>("ItemType")
                        .HasColumnType("TEXT");

                    b.Property<string>("Location")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SearchReset")
                        .HasColumnType("TEXT");

                    b.Property<string>("SearchStop")
                        .HasColumnType("TEXT");

                    b.Property<string>("Tags")
                        .HasColumnType("TEXT");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.Property<double?>("XPos")
                        .HasColumnType("REAL");

                    b.Property<double?>("YPos")
                        .HasColumnType("REAL");

                    b.HasKey("Number");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.HasIndex("Number")
                        .IsUnique();

                    b.ToTable("Switches");
                });

            modelBuilder.Entity("NetPinProc.Domain.MachineConfig.WS281xConfigFileEntry", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<byte>("BoardId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Conn")
                        .HasColumnType("TEXT");

                    b.Property<string>("DisplayName")
                        .HasColumnType("TEXT");

                    b.Property<uint>("First")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Index")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ItemType")
                        .HasColumnType("TEXT");

                    b.Property<uint>("Last")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Location")
                        .HasColumnType("TEXT");

                    b.Property<double?>("XPos")
                        .HasColumnType("REAL");

                    b.Property<double?>("YPos")
                        .HasColumnType("REAL");

                    b.HasKey("Name");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.HasIndex("BoardId", "Index")
                        .IsUnique();

                    b.ToTable("WS281xLeds");
                });

            modelBuilder.Entity("NetPinProc.Game.Sqlite.Model.BallPlayed", b =>
                {
                    b.HasOne("NetPinProc.Game.Sqlite.Model.Player", "Player")
                        .WithMany()
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NetPinProc.Game.Sqlite.Model.Score", "Score")
                        .WithMany("BallsPlayed")
                        .HasForeignKey("ScoreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NetPinProc.Game.Sqlite.Model.Score", b =>
                {
                    b.HasOne("NetPinProc.Game.Sqlite.Model.GamePlayed", "GamePlayed")
                        .WithMany("Scores")
                        .HasForeignKey("GamePlayedId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NetPinProc.Game.Sqlite.Model.Player", "Player")
                        .WithMany()
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
