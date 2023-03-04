﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository.DbContexts;

#nullable disable

namespace Repository.Migrations
{
    [DbContext(typeof(CsgoBotDataContext))]
    [Migration("20230304164203_FKeySteamID64")]
    partial class FKeySteamID64
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CSGOBot.Data.Models.Csgo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int>("faceit_elo")
                        .HasColumnType("int");

                    b.Property<string>("game_player_id")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("game_player_name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("game_profile_id")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("region")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("skill_level")
                        .HasColumnType("int");

                    b.Property<string>("skill_level_label")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Csgo");
                });

            modelBuilder.Entity("CSGOBot.Data.Models.FaceitPlayer", b =>
                {
                    b.Property<Guid>("player_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("avatar")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("country")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("cover_featured_image")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("cover_image")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("faceit_url")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("friends_ids")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<Guid>("gamesid")
                        .HasColumnType("char(36)");

                    b.Property<string>("membership_type")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("memberships")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("new_steam_id")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("nickname")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("steam_id_64")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("steam_nickname")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("player_id");

                    b.HasIndex("gamesid");

                    b.ToTable("FaceitPlayers");
                });

            modelBuilder.Entity("CSGOBot.Data.Models.Games", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("csgoId")
                        .HasColumnType("char(36)");

                    b.HasKey("id");

                    b.HasIndex("csgoId");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("CSGOBot.Data.Models.User", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint unsigned");

                    b.Property<Guid>("FaceitPlayerId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("SteamID64")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CSGOBot.Data.Models.FaceitPlayer", b =>
                {
                    b.HasOne("CSGOBot.Data.Models.Games", "games")
                        .WithMany()
                        .HasForeignKey("gamesid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("games");
                });

            modelBuilder.Entity("CSGOBot.Data.Models.Games", b =>
                {
                    b.HasOne("CSGOBot.Data.Models.Csgo", "csgo")
                        .WithMany()
                        .HasForeignKey("csgoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("csgo");
                });
#pragma warning restore 612, 618
        }
    }
}
