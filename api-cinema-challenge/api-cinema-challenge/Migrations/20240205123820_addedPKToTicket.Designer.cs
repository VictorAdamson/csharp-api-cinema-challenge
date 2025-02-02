﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using api_cinema_challenge.Data;

#nullable disable

namespace api_cinema_challenge.Migrations
{
    [DbContext(typeof(CinemaContext))]
    [Migration("20240205123820_addedPKToTicket")]
    partial class addedPKToTicket
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("api_cinema_challenge.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("PhoneNr")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("phone_nr");

                    b.Property<int>("ScreeningId")
                        .HasColumnType("integer")
                        .HasColumnName("screening_id");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("ScreeningId");

                    b.ToTable("customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 2, 5, 12, 38, 20, 625, DateTimeKind.Utc).AddTicks(5358),
                            Email = "Victor@Adamson.se",
                            Name = "Victor Adamson",
                            PhoneNr = "070666123",
                            ScreeningId = 2,
                            UpdatedAt = new DateTime(2024, 2, 5, 12, 38, 20, 625, DateTimeKind.Utc).AddTicks(5363)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 2, 5, 12, 38, 20, 625, DateTimeKind.Utc).AddTicks(5376),
                            Email = "Phill@Collins.com",
                            Name = "Phill Collins",
                            PhoneNr = "321566322",
                            ScreeningId = 3,
                            UpdatedAt = new DateTime(2024, 2, 5, 12, 38, 20, 625, DateTimeKind.Utc).AddTicks(5377)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 2, 5, 12, 38, 20, 625, DateTimeKind.Utc).AddTicks(5378),
                            Email = "Real@Email.mars",
                            Name = "Person Humansson",
                            PhoneNr = "325666442",
                            ScreeningId = 1,
                            UpdatedAt = new DateTime(2024, 2, 5, 12, 38, 20, 625, DateTimeKind.Utc).AddTicks(5378)
                        });
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Movies", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("rating");

                    b.Property<int>("RuntimeMins")
                        .HasColumnType("integer")
                        .HasColumnName("runtime");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 2, 5, 12, 38, 20, 625, DateTimeKind.Utc).AddTicks(4992),
                            Description = "Amazing but imaginary Hank Williams movie",
                            Rating = "PG-16",
                            RuntimeMins = 114,
                            Title = "So Lonesome I Could Cry",
                            UpdatedAt = new DateTime(2024, 2, 5, 12, 38, 20, 625, DateTimeKind.Utc).AddTicks(4996)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 2, 5, 12, 38, 20, 625, DateTimeKind.Utc).AddTicks(5000),
                            Description = "Western B-Movie",
                            Rating = "PG-16",
                            RuntimeMins = 120,
                            Title = "Texas Cowboy Rides Again",
                            UpdatedAt = new DateTime(2024, 2, 5, 12, 38, 20, 625, DateTimeKind.Utc).AddTicks(5000)
                        });
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Screenings", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Capacity")
                        .HasColumnType("integer")
                        .HasColumnName("capacity");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("MoviesId")
                        .HasColumnType("integer")
                        .HasColumnName("movies_id");

                    b.Property<int>("ScreenNr")
                        .HasColumnType("integer")
                        .HasColumnName("screen_nr");

                    b.Property<DateTime>("StartsAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("starts_at");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("MoviesId");

                    b.ToTable("screenings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Capacity = 64,
                            CreatedAt = new DateTime(2024, 2, 5, 12, 38, 20, 625, DateTimeKind.Utc).AddTicks(5327),
                            MoviesId = 1,
                            ScreenNr = 1,
                            StartsAt = new DateTime(2024, 2, 5, 14, 38, 20, 625, DateTimeKind.Utc).AddTicks(5193),
                            UpdatedAt = new DateTime(2024, 2, 5, 12, 38, 20, 625, DateTimeKind.Utc).AddTicks(5328)
                        },
                        new
                        {
                            Id = 2,
                            Capacity = 64,
                            CreatedAt = new DateTime(2024, 2, 5, 12, 38, 20, 625, DateTimeKind.Utc).AddTicks(5331),
                            MoviesId = 1,
                            ScreenNr = 2,
                            StartsAt = new DateTime(2024, 2, 5, 12, 38, 20, 625, DateTimeKind.Utc).AddTicks(5193),
                            UpdatedAt = new DateTime(2024, 2, 5, 12, 38, 20, 625, DateTimeKind.Utc).AddTicks(5331)
                        },
                        new
                        {
                            Id = 3,
                            Capacity = 32,
                            CreatedAt = new DateTime(2024, 2, 5, 12, 38, 20, 625, DateTimeKind.Utc).AddTicks(5333),
                            MoviesId = 2,
                            ScreenNr = 3,
                            StartsAt = new DateTime(2024, 2, 5, 12, 38, 20, 625, DateTimeKind.Utc).AddTicks(5193),
                            UpdatedAt = new DateTime(2024, 2, 5, 12, 38, 20, 625, DateTimeKind.Utc).AddTicks(5333)
                        });
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Tickets", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("CustomerId")
                        .HasColumnType("integer")
                        .HasColumnName("customer_id");

                    b.Property<int>("ScreeningId")
                        .HasColumnType("integer")
                        .HasColumnName("screening_id");

                    b.Property<int>("SeatNr")
                        .HasColumnType("integer")
                        .HasColumnName("seat_nr");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("tickets");
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Customer", b =>
                {
                    b.HasOne("api_cinema_challenge.Models.Screenings", "Screening")
                        .WithMany()
                        .HasForeignKey("ScreeningId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Screening");
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Screenings", b =>
                {
                    b.HasOne("api_cinema_challenge.Models.Movies", "Movies")
                        .WithMany()
                        .HasForeignKey("MoviesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movies");
                });
#pragma warning restore 612, 618
        }
    }
}
