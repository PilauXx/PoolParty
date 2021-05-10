﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PoolParty.Data;

namespace PoolParty.Migrations
{
    [DbContext(typeof(GestionTachesContext))]
    partial class GestionTachesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EquipeLicensie", b =>
                {
                    b.Property<int>("EquipesID")
                        .HasColumnType("int");

                    b.Property<int>("LicensiesID")
                        .HasColumnType("int");

                    b.HasKey("EquipesID", "LicensiesID");

                    b.HasIndex("LicensiesID");

                    b.ToTable("EquipeLicensie");
                });

            modelBuilder.Entity("PoolParty.Models.Competition", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("jeuID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("jeuID");

                    b.ToTable("Competition");
                });

            modelBuilder.Entity("PoolParty.Models.Equipe", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CompetitionID")
                        .HasColumnType("int");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("CompetitionID");

                    b.ToTable("Equipe");
                });

            modelBuilder.Entity("PoolParty.Models.Etape", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CompetitionID")
                        .HasColumnType("int");

                    b.Property<int?>("EtapeSuivanteID")
                        .HasColumnType("int");

                    b.Property<int>("RencontreID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CompetitionID");

                    b.HasIndex("EtapeSuivanteID");

                    b.ToTable("Etape");
                });

            modelBuilder.Entity("PoolParty.Models.Jeu", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Jeu");
                });

            modelBuilder.Entity("PoolParty.Models.Licensie", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Licensie");
                });

            modelBuilder.Entity("PoolParty.Models.Rencontre", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("EquipeAID")
                        .HasColumnType("int");

                    b.Property<int?>("EquipeBID")
                        .HasColumnType("int");

                    b.Property<int>("EtapeID")
                        .HasColumnType("int");

                    b.Property<int>("ScoreA")
                        .HasColumnType("int");

                    b.Property<int>("ScoreB")
                        .HasColumnType("int");

                    b.Property<int?>("jeuID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("EquipeAID");

                    b.HasIndex("EquipeBID");

                    b.HasIndex("EtapeID")
                        .IsUnique();

                    b.HasIndex("jeuID");

                    b.ToTable("Rencontre");
                });

            modelBuilder.Entity("EquipeLicensie", b =>
                {
                    b.HasOne("PoolParty.Models.Equipe", null)
                        .WithMany()
                        .HasForeignKey("EquipesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PoolParty.Models.Licensie", null)
                        .WithMany()
                        .HasForeignKey("LicensiesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PoolParty.Models.Competition", b =>
                {
                    b.HasOne("PoolParty.Models.Jeu", "jeu")
                        .WithMany("Competitions")
                        .HasForeignKey("jeuID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("jeu");
                });

            modelBuilder.Entity("PoolParty.Models.Equipe", b =>
                {
                    b.HasOne("PoolParty.Models.Competition", null)
                        .WithMany("Equipes")
                        .HasForeignKey("CompetitionID");
                });

            modelBuilder.Entity("PoolParty.Models.Etape", b =>
                {
                    b.HasOne("PoolParty.Models.Competition", "Competition")
                        .WithMany("Etapes")
                        .HasForeignKey("CompetitionID");

                    b.HasOne("PoolParty.Models.Etape", "EtapeSuivante")
                        .WithMany("EtapesPrecedantes")
                        .HasForeignKey("EtapeSuivanteID");

                    b.Navigation("Competition");

                    b.Navigation("EtapeSuivante");
                });

            modelBuilder.Entity("PoolParty.Models.Rencontre", b =>
                {
                    b.HasOne("PoolParty.Models.Equipe", "EquipeA")
                        .WithMany()
                        .HasForeignKey("EquipeAID");

                    b.HasOne("PoolParty.Models.Equipe", "EquipeB")
                        .WithMany()
                        .HasForeignKey("EquipeBID");

                    b.HasOne("PoolParty.Models.Etape", "Etape")
                        .WithOne("Rencontre")
                        .HasForeignKey("PoolParty.Models.Rencontre", "EtapeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PoolParty.Models.Jeu", "jeu")
                        .WithMany()
                        .HasForeignKey("jeuID");

                    b.Navigation("EquipeA");

                    b.Navigation("EquipeB");

                    b.Navigation("Etape");

                    b.Navigation("jeu");
                });

            modelBuilder.Entity("PoolParty.Models.Competition", b =>
                {
                    b.Navigation("Equipes");

                    b.Navigation("Etapes");
                });

            modelBuilder.Entity("PoolParty.Models.Etape", b =>
                {
                    b.Navigation("EtapesPrecedantes");

                    b.Navigation("Rencontre")
                        .IsRequired();
                });

            modelBuilder.Entity("PoolParty.Models.Jeu", b =>
                {
                    b.Navigation("Competitions");
                });
#pragma warning restore 612, 618
        }
    }
}
