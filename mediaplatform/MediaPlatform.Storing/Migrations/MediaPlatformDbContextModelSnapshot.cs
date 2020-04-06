﻿// <auto-generated />
using System;
using MediaPlatform.Storing.Databases;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MediaPlatform.Storing.Migrations
{
    [DbContext(typeof(MediaPlatformDbContext))]
    partial class MediaPlatformDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MediaPlatform.Domain.Models.Community", b =>
                {
                    b.Property<long>("ID")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("UserID")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("UserID");

                    b.ToTable("Community");

                    b.HasData(
                        new
                        {
                            ID = 637217767848196661L,
                            Name = "Random Community"
                        });
                });

            modelBuilder.Entity("MediaPlatform.Domain.Models.User", b =>
                {
                    b.Property<long>("ID")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            ID = 637217767848182179L,
                            Name = "Demi Demi",
                            Password = "12345",
                            Username = "demi"
                        },
                        new
                        {
                            ID = 637217767848183074L,
                            Name = "Jesus",
                            Password = "Password12345",
                            Username = "jesus"
                        },
                        new
                        {
                            ID = 637217767848183101L,
                            Name = "George",
                            Password = "password",
                            Username = "george"
                        },
                        new
                        {
                            ID = 637217767848183107L,
                            Name = "Jeremy",
                            Password = "12345",
                            Username = "jeremy"
                        });
                });

            modelBuilder.Entity("MediaPlatform.Domain.Models.Video", b =>
                {
                    b.Property<long>("ID")
                        .HasColumnType("bigint");

                    b.Property<long?>("CommunityID")
                        .HasColumnType("bigint");

                    b.Property<long>("Duration")
                        .HasColumnType("bigint");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("URL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UploadedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("UserID")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("CommunityID");

                    b.HasIndex("UserID");

                    b.ToTable("Video");

                    b.HasData(
                        new
                        {
                            ID = 637217767848194626L,
                            Duration = 31L,
                            Title = "Tough Time Never Last, Only Tough People Last",
                            URL = "https://www.youtube.com/embed/1puR8jGK03A",
                            UploadedBy = "Demi Demi"
                        },
                        new
                        {
                            ID = 637217767848195645L,
                            Duration = 500L,
                            Title = "Birds are not real",
                            UploadedBy = "George"
                        });
                });

            modelBuilder.Entity("MediaPlatform.Domain.Models.Community", b =>
                {
                    b.HasOne("MediaPlatform.Domain.Models.User", null)
                        .WithMany("Communities")
                        .HasForeignKey("UserID");
                });

            modelBuilder.Entity("MediaPlatform.Domain.Models.Video", b =>
                {
                    b.HasOne("MediaPlatform.Domain.Models.Community", null)
                        .WithMany("Videos")
                        .HasForeignKey("CommunityID");

                    b.HasOne("MediaPlatform.Domain.Models.User", null)
                        .WithMany("Videos")
                        .HasForeignKey("UserID");
                });
#pragma warning restore 612, 618
        }
    }
}
