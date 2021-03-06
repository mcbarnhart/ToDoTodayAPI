﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ToDoTodayAPI.Data;

namespace ToDoTodayAPI.Migrations
{
    [DbContext(typeof(ToDoListDBContext))]
    [Migration("20200610220346_SeedToDoData")]
    partial class SeedToDoData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ToDoTodayAPI.Models.TaskItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Assignee")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedByUserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DifficultyRating")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DueTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("EstimatedTimeToComplete")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TaskItems");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Assignee = "Matthew",
                            Description = "Get up on that ladder and clean out those filthy gutters!",
                            DifficultyRating = 4,
                            DueTime = new DateTime(2020, 6, 17, 17, 3, 45, 967, DateTimeKind.Local).AddTicks(3149),
                            EstimatedTimeToComplete = "2 hours",
                            StartTime = new DateTime(2020, 6, 10, 17, 3, 45, 963, DateTimeKind.Local).AddTicks(9613),
                            Title = "Clean Gutters"
                        },
                        new
                        {
                            Id = 2,
                            Assignee = "Matthew",
                            Description = "Your plants are rootbound-- fix it!",
                            DifficultyRating = 2,
                            DueTime = new DateTime(2020, 6, 17, 17, 3, 45, 967, DateTimeKind.Local).AddTicks(6547),
                            EstimatedTimeToComplete = "2 hours",
                            StartTime = new DateTime(2020, 6, 10, 17, 3, 45, 967, DateTimeKind.Local).AddTicks(6517),
                            Title = "Pot Plants"
                        },
                        new
                        {
                            Id = 3,
                            Assignee = "Jessie",
                            Description = "The hard part is done. Now we just have to build and hang the panels.",
                            DifficultyRating = 3,
                            DueTime = new DateTime(2020, 6, 17, 17, 3, 45, 967, DateTimeKind.Local).AddTicks(6604),
                            EstimatedTimeToComplete = "2 hours",
                            StartTime = new DateTime(2020, 6, 10, 17, 3, 45, 967, DateTimeKind.Local).AddTicks(6599),
                            Title = "Build the Fence"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
