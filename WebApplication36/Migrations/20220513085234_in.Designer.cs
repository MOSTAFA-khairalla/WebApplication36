﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication36.Data;

namespace WebApplication36.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220513085234_in")]
    partial class @in
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication36.Data.Entrant", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EntrantDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EntrantFacebookPageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EntrantFullAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EntrantGooglePlaceId")
                        .HasColumnType("int");

                    b.Property<string>("EntrantInstagramHandle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EntrantName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EntrantPhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EntrantPhotoVideoURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EntrantTwitterHandle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EntrantWebsiteUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EntrantYouTubeChannelUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfVotes")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfWriteIns")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GroupId");

                    b.ToTable("Entrants");
                });
#pragma warning restore 612, 618
        }
    }
}
