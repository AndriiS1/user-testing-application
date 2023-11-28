﻿// <auto-generated />
using System;
using Infrastructure.DataBase.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.DataBase.Migrations
{
    [DbContext(typeof(ServerDbContext))]
    [Migration("20231128143032_NewSeedData")]
    partial class NewSeedData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Models.QuestionAnswer", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<bool?>("IsCorrect")
                        .HasColumnType("bit");

                    b.Property<long?>("TestQuestionId")
                        .HasColumnType("bigint");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("TestQuestionId");

                    b.ToTable("QuestionAnswers");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            IsCorrect = false,
                            TestQuestionId = 1L,
                            Title = "x=2"
                        },
                        new
                        {
                            Id = 2L,
                            IsCorrect = true,
                            TestQuestionId = 1L,
                            Title = "x=3"
                        },
                        new
                        {
                            Id = 3L,
                            IsCorrect = false,
                            TestQuestionId = 1L,
                            Title = "x=4"
                        },
                        new
                        {
                            Id = 4L,
                            IsCorrect = true,
                            TestQuestionId = 2L,
                            Title = "x+6"
                        },
                        new
                        {
                            Id = 5L,
                            IsCorrect = false,
                            TestQuestionId = 2L,
                            Title = "x+4"
                        },
                        new
                        {
                            Id = 6L,
                            IsCorrect = false,
                            TestQuestionId = 2L,
                            Title = "x+4"
                        },
                        new
                        {
                            Id = 7L,
                            IsCorrect = true,
                            TestQuestionId = 3L,
                            Title = "(x−2)(x−3)"
                        },
                        new
                        {
                            Id = 8L,
                            IsCorrect = false,
                            TestQuestionId = 3L,
                            Title = "(x−1)(x−6)"
                        },
                        new
                        {
                            Id = 9L,
                            IsCorrect = false,
                            TestQuestionId = 3L,
                            Title = "(x−2)(x−4)"
                        },
                        new
                        {
                            Id = 10L,
                            IsCorrect = false,
                            TestQuestionId = 4L,
                            Title = "x>2"
                        },
                        new
                        {
                            Id = 11L,
                            IsCorrect = false,
                            TestQuestionId = 4L,
                            Title = "x<3"
                        },
                        new
                        {
                            Id = 12L,
                            IsCorrect = true,
                            TestQuestionId = 4L,
                            Title = "x<2"
                        },
                        new
                        {
                            Id = 13L,
                            IsCorrect = false,
                            TestQuestionId = 5L,
                            Title = "25"
                        },
                        new
                        {
                            Id = 14L,
                            IsCorrect = false,
                            TestQuestionId = 5L,
                            Title = "36"
                        },
                        new
                        {
                            Id = 15L,
                            IsCorrect = true,
                            TestQuestionId = 5L,
                            Title = "28"
                        },
                        new
                        {
                            Id = 16L,
                            IsCorrect = false,
                            TestQuestionId = 6L,
                            Title = "Earth"
                        },
                        new
                        {
                            Id = 17L,
                            IsCorrect = false,
                            TestQuestionId = 6L,
                            Title = "Mars"
                        },
                        new
                        {
                            Id = 18L,
                            IsCorrect = true,
                            TestQuestionId = 6L,
                            Title = "Jupiter"
                        },
                        new
                        {
                            Id = 19L,
                            IsCorrect = false,
                            TestQuestionId = 7L,
                            Title = "2"
                        },
                        new
                        {
                            Id = 20L,
                            IsCorrect = true,
                            TestQuestionId = 7L,
                            Title = "0"
                        },
                        new
                        {
                            Id = 21L,
                            IsCorrect = false,
                            TestQuestionId = 7L,
                            Title = "1"
                        },
                        new
                        {
                            Id = 22L,
                            IsCorrect = false,
                            TestQuestionId = 8L,
                            Title = "Helium"
                        },
                        new
                        {
                            Id = 23L,
                            IsCorrect = true,
                            TestQuestionId = 8L,
                            Title = "Hydrogen"
                        },
                        new
                        {
                            Id = 24L,
                            IsCorrect = false,
                            TestQuestionId = 8L,
                            Title = "Oxygen"
                        },
                        new
                        {
                            Id = 25L,
                            IsCorrect = false,
                            TestQuestionId = 9L,
                            Title = "M87"
                        },
                        new
                        {
                            Id = 26L,
                            IsCorrect = false,
                            TestQuestionId = 9L,
                            Title = "Triangulum"
                        },
                        new
                        {
                            Id = 27L,
                            IsCorrect = true,
                            TestQuestionId = 9L,
                            Title = "Andromeda "
                        },
                        new
                        {
                            Id = 28L,
                            IsCorrect = false,
                            TestQuestionId = 10L,
                            Title = "Refraction"
                        },
                        new
                        {
                            Id = 29L,
                            IsCorrect = false,
                            TestQuestionId = 10L,
                            Title = "Diffraction"
                        },
                        new
                        {
                            Id = 30L,
                            IsCorrect = true,
                            TestQuestionId = 10L,
                            Title = "Gravitational Lensing"
                        },
                        new
                        {
                            Id = 31L,
                            IsCorrect = false,
                            TestQuestionId = 11L,
                            Title = "Hyper Transfer Markup Language"
                        },
                        new
                        {
                            Id = 32L,
                            IsCorrect = false,
                            TestQuestionId = 11L,
                            Title = "Hyper Text Makeup Language"
                        },
                        new
                        {
                            Id = 33L,
                            IsCorrect = true,
                            TestQuestionId = 11L,
                            Title = "Hyper Text Markup Language"
                        },
                        new
                        {
                            Id = 34L,
                            IsCorrect = false,
                            TestQuestionId = 12L,
                            Title = "C++"
                        },
                        new
                        {
                            Id = 35L,
                            IsCorrect = false,
                            TestQuestionId = 12L,
                            Title = "Java"
                        },
                        new
                        {
                            Id = 36L,
                            IsCorrect = true,
                            TestQuestionId = 12L,
                            Title = "Python "
                        },
                        new
                        {
                            Id = 37L,
                            IsCorrect = false,
                            TestQuestionId = 13L,
                            Title = "Computer Style Sheets"
                        },
                        new
                        {
                            Id = 38L,
                            IsCorrect = true,
                            TestQuestionId = 13L,
                            Title = "Cascading Style Sheets"
                        },
                        new
                        {
                            Id = 39L,
                            IsCorrect = false,
                            TestQuestionId = 13L,
                            Title = "Creative Style Sheets"
                        },
                        new
                        {
                            Id = 40L,
                            IsCorrect = true,
                            TestQuestionId = 14L,
                            Title = "Binding the data and the methods that manipulate the data into a single unit"
                        },
                        new
                        {
                            Id = 41L,
                            IsCorrect = false,
                            TestQuestionId = 14L,
                            Title = "Breaking down a program into functions"
                        },
                        new
                        {
                            Id = 42L,
                            IsCorrect = false,
                            TestQuestionId = 14L,
                            Title = "Connecting two different classes "
                        },
                        new
                        {
                            Id = 43L,
                            IsCorrect = false,
                            TestQuestionId = 15L,
                            Title = "Create a new branch"
                        },
                        new
                        {
                            Id = 44L,
                            IsCorrect = false,
                            TestQuestionId = 15L,
                            Title = "Merge branches in Git"
                        },
                        new
                        {
                            Id = 45L,
                            IsCorrect = true,
                            TestQuestionId = 15L,
                            Title = "Copy a repository from a remote source to your local machine"
                        });
                });

            modelBuilder.Entity("Domain.Models.Test", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<int?>("Category")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Tests");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Category = 2,
                            Description = "The test provided by harvard to deeply test your math knowledge.",
                            Title = "Algebra Harvard testing"
                        },
                        new
                        {
                            Id = 2L,
                            Category = 0,
                            Description = "The NASA examination is a comprehensive assessment designed by the National Aeronautics and Space Administration (NASA) to evaluate your space knowledge.",
                            Title = "NASA examination"
                        },
                        new
                        {
                            Id = 3L,
                            Category = 1,
                            Description = "The WW3 Schools Programming Test is a challenging assessment designed to evaluate a programmer's skills and knowledge in various programming languages and concepts..",
                            Title = "WW3Schools test"
                        });
                });

            modelBuilder.Entity("Domain.Models.TestQuestion", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long?>("TestId")
                        .HasColumnType("bigint");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("TestId");

                    b.ToTable("TestQuestions");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            TestId = 1L,
                            Title = "Solve for x: 2x+5=11:"
                        },
                        new
                        {
                            Id = 2L,
                            TestId = 1L,
                            Title = "Simplify the expression 3(x+2)−2x:"
                        },
                        new
                        {
                            Id = 3L,
                            TestId = 1L,
                            Title = "Factorize the quadratic expression x^2−5x+6:"
                        },
                        new
                        {
                            Id = 4L,
                            TestId = 1L,
                            Title = "Solve the inequality: 3x+7>1:"
                        },
                        new
                        {
                            Id = 5L,
                            TestId = 1L,
                            Title = "Evaluate the expression 4a^2−2ab+b^2 when a=3 and b=2:"
                        },
                        new
                        {
                            Id = 6L,
                            TestId = 2L,
                            Title = "What is the largest planet in our solar system: "
                        },
                        new
                        {
                            Id = 7L,
                            TestId = 2L,
                            Title = "Choose many moons does Venus have:"
                        },
                        new
                        {
                            Id = 8L,
                            TestId = 2L,
                            Title = "What is the main component of the Sun:"
                        },
                        new
                        {
                            Id = 9L,
                            TestId = 2L,
                            Title = "Which galaxy is the Milky Way's closest neighbor:"
                        },
                        new
                        {
                            Id = 10L,
                            TestId = 2L,
                            Title = "What is the phenomenon where light is bent as it passes through a gravitational field, predicted by Einstein's theory of General Relativity:"
                        },
                        new
                        {
                            Id = 11L,
                            TestId = 3L,
                            Title = "What does HTML stand for: "
                        },
                        new
                        {
                            Id = 12L,
                            TestId = 3L,
                            Title = "Which programming language is known for its readability and simplicity:"
                        },
                        new
                        {
                            Id = 13L,
                            TestId = 3L,
                            Title = "What does CSS stand for:"
                        },
                        new
                        {
                            Id = 14L,
                            TestId = 3L,
                            Title = "In object-oriented programming, what is encapsulation:"
                        },
                        new
                        {
                            Id = 15L,
                            TestId = 3L,
                            Title = "What is the purpose of the \"git clone\" command in Git:"
                        });
                });

            modelBuilder.Entity("Domain.Models.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RefreshToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RefreshTokenExpiryTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("SecondName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Domain.Models.QuestionAnswer", b =>
                {
                    b.HasOne("Domain.Models.TestQuestion", "TestQuestion")
                        .WithMany("Answers")
                        .HasForeignKey("TestQuestionId");

                    b.Navigation("TestQuestion");
                });

            modelBuilder.Entity("Domain.Models.Test", b =>
                {
                    b.HasOne("Domain.Models.User", null)
                        .WithMany("Tests")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Domain.Models.TestQuestion", b =>
                {
                    b.HasOne("Domain.Models.Test", "Test")
                        .WithMany("Questions")
                        .HasForeignKey("TestId");

                    b.Navigation("Test");
                });

            modelBuilder.Entity("Domain.Models.Test", b =>
                {
                    b.Navigation("Questions");
                });

            modelBuilder.Entity("Domain.Models.TestQuestion", b =>
                {
                    b.Navigation("Answers");
                });

            modelBuilder.Entity("Domain.Models.User", b =>
                {
                    b.Navigation("Tests");
                });
#pragma warning restore 612, 618
        }
    }
}
