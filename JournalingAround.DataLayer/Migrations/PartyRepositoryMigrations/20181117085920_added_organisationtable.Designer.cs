﻿// <auto-generated />
using System;
using JournalingAround.DataLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JournalingAround.DataLayer.Migrations.PartyRepositoryMigrations
{
    [DbContext(typeof(PartyRepository))]
    [Migration("20181117085920_added_organisationtable")]
    partial class added_organisationtable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("JournalingAround.DataLayer.Entities.Party.Individual", b =>
                {
                    b.Property<int>("Id");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("Id");

                    b.ToTable("Individuals");
                });

            modelBuilder.Entity("JournalingAround.DataLayer.Entities.Party.Organisation", b =>
                {
                    b.Property<int>("Id");

                    b.Property<string>("OrganisationName");

                    b.Property<string>("TaxId");

                    b.HasKey("Id");

                    b.ToTable("Organisations");
                });

            modelBuilder.Entity("JournalingAround.DataLayer.Entities.Party.Party", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate");

                    b.HasKey("Id");

                    b.ToTable("Parties");
                });

            modelBuilder.Entity("JournalingAround.DataLayer.Entities.Party.Individual", b =>
                {
                    b.HasOne("JournalingAround.DataLayer.Entities.Party.Party", "Party")
                        .WithMany()
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("JournalingAround.DataLayer.Entities.Party.Organisation", b =>
                {
                    b.HasOne("JournalingAround.DataLayer.Entities.Party.Party", "Party")
                        .WithMany()
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}