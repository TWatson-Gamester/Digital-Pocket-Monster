﻿// <auto-generated />
using System;
using Digital_Pocket_Monster.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Digital_Pocket_Monster.Migrations
{
    [DbContext(typeof(DigimonContext))]
    [Migration("20220216160849_RestrictedValues")]
    partial class RestrictedValues
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Digital_Pocket_Monster.Models.AccountInfo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasColumnType("varchar(15)");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasColumnType("varchar(25)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("ID");

                    b.ToTable("AccountInfo");
                });

            modelBuilder.Entity("Digital_Pocket_Monster.Models.Card", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("amountOwned")
                        .HasColumnType("int");

                    b.Property<string>("attribute")
                        .IsRequired()
                        .HasColumnType("varchar(25)");

                    b.Property<string>("cardNumber")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<int>("cardPower")
                        .HasColumnType("int");

                    b.Property<string>("cardType")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<string>("color")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("varchar(250)");

                    b.Property<string>("digivolveColor")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<string>("image")
                        .IsRequired()
                        .HasColumnType("varchar(75)");

                    b.Property<int>("level")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("varchar(25)");

                    b.Property<int>("playCost")
                        .HasColumnType("int");

                    b.Property<string>("race")
                        .IsRequired()
                        .HasColumnType("varchar(25)");

                    b.Property<string>("rarity")
                        .IsRequired()
                        .HasColumnType("varchar(15)");

                    b.Property<string>("stageLevel")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.HasKey("ID");

                    b.ToTable("Cards");
                });

            modelBuilder.Entity("Digital_Pocket_Monster.Models.Deck", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("deckName")
                        .IsRequired()
                        .HasColumnType("varchar(25)");

                    b.Property<int?>("userID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Decks");
                });

            modelBuilder.Entity("Digital_Pocket_Monster.Models.Pack", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("packName")
                        .IsRequired()
                        .HasColumnType("varchar(25)");

                    b.HasKey("ID");

                    b.ToTable("Packs");
                });
#pragma warning restore 612, 618
        }
    }
}
