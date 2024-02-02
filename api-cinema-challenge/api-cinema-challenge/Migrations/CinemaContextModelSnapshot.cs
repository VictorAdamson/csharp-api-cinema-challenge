﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using api_cinema_challenge.Data;

#nullable disable

namespace api_cinema_challenge.Migrations
{
    [DbContext(typeof(CinemaContext))]
    partial class CinemaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<int>("PhoneNr")
                        .HasColumnType("integer")
                        .HasColumnName("phone_nr");

                    b.Property<int>("ScreeningId")
                        .HasColumnType("integer")
                        .HasColumnName("screening_id");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("ScreeningId");

                    b.ToTable("customers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 2, 1, 13, 39, 0, 841, DateTimeKind.Utc).AddTicks(3637),
                            Email = "Victor@Adamson.se",
                            Name = "Victor Adamson",
                            PhoneNr = 70666123,
                            ScreeningId = 2,
                            UpdatedAt = new DateTime(2024, 2, 1, 13, 39, 0, 841, DateTimeKind.Utc).AddTicks(3641)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 2, 1, 13, 39, 0, 841, DateTimeKind.Utc).AddTicks(3644),
                            Email = "Phill@Collins.com",
                            Name = "Phill Collins",
                            PhoneNr = 321566322,
                            ScreeningId = 3,
                            UpdatedAt = new DateTime(2024, 2, 1, 13, 39, 0, 841, DateTimeKind.Utc).AddTicks(3644)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 2, 1, 13, 39, 0, 841, DateTimeKind.Utc).AddTicks(3646),
                            Email = "Real@Email.mars",
                            Name = "Person Humansson",
                            PhoneNr = 325666442,
                            ScreeningId = 1,
                            UpdatedAt = new DateTime(2024, 2, 1, 13, 39, 0, 841, DateTimeKind.Utc).AddTicks(3647)
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

                    b.ToTable("movies", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 2, 1, 13, 39, 0, 841, DateTimeKind.Utc).AddTicks(3333),
                            Description = "Amazing but imaginary Hank Williams movie",
                            Rating = "PG-16",
                            RuntimeMins = 114,
                            Title = "So Lonesome I Could Cry",
                            UpdatedAt = new DateTime(2024, 2, 1, 13, 39, 0, 841, DateTimeKind.Utc).AddTicks(3337)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 2, 1, 13, 39, 0, 841, DateTimeKind.Utc).AddTicks(3341),
                            Description = "Western B-Movie",
                            Rating = "PG-16",
                            RuntimeMins = 120,
                            Title = "Texas Cowboy Rides Again",
                            UpdatedAt = new DateTime(2024, 2, 1, 13, 39, 0, 841, DateTimeKind.Utc).AddTicks(3342)
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

                    b.ToTable("screenings", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Capacity = 64,
                            CreatedAt = new DateTime(2024, 2, 1, 13, 39, 0, 841, DateTimeKind.Utc).AddTicks(3603),
                            MoviesId = 1,
                            ScreenNr = 1,
                            StartsAt = new DateTime(2024, 2, 1, 13, 39, 0, 841, DateTimeKind.Utc).AddTicks(3475),
                            UpdatedAt = new DateTime(2024, 2, 1, 13, 39, 0, 841, DateTimeKind.Utc).AddTicks(3605)
                        },
                        new
                        {
                            Id = 2,
                            Capacity = 64,
                            CreatedAt = new DateTime(2024, 2, 1, 13, 39, 0, 841, DateTimeKind.Utc).AddTicks(3610),
                            MoviesId = 1,
                            ScreenNr = 2,
                            StartsAt = new DateTime(2024, 2, 1, 13, 39, 0, 841, DateTimeKind.Utc).AddTicks(3475),
                            UpdatedAt = new DateTime(2024, 2, 1, 13, 39, 0, 841, DateTimeKind.Utc).AddTicks(3611)
                        },
                        new
                        {
                            Id = 3,
                            Capacity = 32,
                            CreatedAt = new DateTime(2024, 2, 1, 13, 39, 0, 841, DateTimeKind.Utc).AddTicks(3612),
                            MoviesId = 2,
                            ScreenNr = 3,
                            StartsAt = new DateTime(2024, 2, 1, 13, 39, 0, 841, DateTimeKind.Utc).AddTicks(3475),
                            UpdatedAt = new DateTime(2024, 2, 1, 13, 39, 0, 841, DateTimeKind.Utc).AddTicks(3613)
                        });
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
