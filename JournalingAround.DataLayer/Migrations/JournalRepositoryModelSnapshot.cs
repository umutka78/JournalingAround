﻿// <auto-generated />
using System;
using JournalingAround.DataLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JournalingAround.DataLayer.Migrations
{
    [DbContext(typeof(JournalRepository))]
    partial class JournalRepositoryModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("JournalingAround.Domain.Entities.Journal.JournalEntry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Detail");

                    b.Property<DateTime>("EndDate");

                    b.Property<DateTime>("StartDate");

                    b.Property<string>("Summary");

                    b.HasKey("Id");

                    b.ToTable("JournalEntries");
                });

            modelBuilder.Entity("JournalingAround.Domain.Entities.Journal.JournalTag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("JournalEntryId");

                    b.Property<string>("TagName");

                    b.HasKey("Id");

                    b.HasIndex("JournalEntryId");

                    b.ToTable("JournalTags");
                });

            modelBuilder.Entity("JournalingAround.Domain.Entities.Journal.JournalTag", b =>
                {
                    b.HasOne("JournalingAround.Domain.Entities.Journal.JournalEntry", "JournalEntry")
                        .WithMany("JournalTags")
                        .HasForeignKey("JournalEntryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
