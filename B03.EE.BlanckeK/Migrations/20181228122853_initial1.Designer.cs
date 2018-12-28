﻿// <auto-generated />
using System;
using B03.EE.BlanckeK.Api;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace B03.EE.BlanckeK.Api.Migrations
{
    [DbContext(typeof(QuizContext))]
    [Migration("20181228122853_initial1")]
    partial class initial1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("B03.EE.BlanckeK.Models.Answer", b =>
                {
                    b.Property<int>("AnswerId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AnswerText");

                    b.Property<bool>("IsCorrectAnswer");

                    b.Property<int>("QuestionId");

                    b.HasKey("AnswerId");

                    b.HasIndex("QuestionId");

                    b.ToTable("Answer");

                    b.HasData(
                        new
                        {
                            AnswerId = 1,
                            AnswerText = "Correct antwoord op eerste vraag",
                            IsCorrectAnswer = true,
                            QuestionId = 1
                        },
                        new
                        {
                            AnswerId = 2,
                            AnswerText = "Eerste foutieve antwoord op eerste vraag",
                            IsCorrectAnswer = false,
                            QuestionId = 1
                        },
                        new
                        {
                            AnswerId = 3,
                            AnswerText = "tweede foutieve antwoord op eerste vraag",
                            IsCorrectAnswer = false,
                            QuestionId = 1
                        },
                        new
                        {
                            AnswerId = 4,
                            AnswerText = "derde foutieve antwoord op eerste vraag",
                            IsCorrectAnswer = false,
                            QuestionId = 1
                        },
                        new
                        {
                            AnswerId = 5,
                            AnswerText = "Eerste foutieve antwoord op tweede vraag",
                            IsCorrectAnswer = false,
                            QuestionId = 2
                        },
                        new
                        {
                            AnswerId = 6,
                            AnswerText = "Tweede foutieve antwoord op tweede vraag",
                            IsCorrectAnswer = false,
                            QuestionId = 2
                        },
                        new
                        {
                            AnswerId = 7,
                            AnswerText = "Juiste antwoord op tweede vraag",
                            IsCorrectAnswer = true,
                            QuestionId = 2
                        },
                        new
                        {
                            AnswerId = 8,
                            AnswerText = "derde foutieve antwoord op tweede vraag",
                            IsCorrectAnswer = false,
                            QuestionId = 2
                        },
                        new
                        {
                            AnswerId = 9,
                            AnswerText = "Correct antwoord op derde vraag",
                            IsCorrectAnswer = true,
                            QuestionId = 3
                        },
                        new
                        {
                            AnswerId = 10,
                            AnswerText = "Eerste foutieve antwoord op derde vraag",
                            IsCorrectAnswer = false,
                            QuestionId = 3
                        },
                        new
                        {
                            AnswerId = 11,
                            AnswerText = "tweede foutieve antwoord op derde vraag",
                            IsCorrectAnswer = false,
                            QuestionId = 3
                        },
                        new
                        {
                            AnswerId = 12,
                            AnswerText = "derde foutieve antwoord op derde vraag",
                            IsCorrectAnswer = false,
                            QuestionId = 3
                        });
                });

            modelBuilder.Entity("B03.EE.BlanckeK.Models.Question", b =>
                {
                    b.Property<int>("QuestionId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("QuestionText");

                    b.Property<int>("QuizId");

                    b.HasKey("QuestionId");

                    b.HasIndex("QuizId");

                    b.ToTable("Questions");

                    b.HasData(
                        new
                        {
                            QuestionId = 1,
                            QuestionText = "Eerste vraag?",
                            QuizId = 1
                        },
                        new
                        {
                            QuestionId = 2,
                            QuestionText = "Tweede vraag?",
                            QuizId = 1
                        },
                        new
                        {
                            QuestionId = 3,
                            QuestionText = "Derde vraag?",
                            QuizId = 1
                        });
                });

            modelBuilder.Entity("B03.EE.BlanckeK.Models.Quiz", b =>
                {
                    b.Property<int>("QuizId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("QuizName");

                    b.Property<int>("UserId");

                    b.HasKey("QuizId");

                    b.HasIndex("UserId");

                    b.ToTable("Quiz");

                    b.HasData(
                        new
                        {
                            QuizId = 1,
                            QuizName = "Eerste quiz",
                            UserId = 1
                        });
                });

            modelBuilder.Entity("B03.EE.BlanckeK.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateTime");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Password");

                    b.HasKey("UserId");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            DateTime = new DateTime(2018, 12, 28, 13, 28, 53, 304, DateTimeKind.Local).AddTicks(3365),
                            FirstName = "Kenny",
                            LastName = "Blancke",
                            Password = "Test"
                        });
                });

            modelBuilder.Entity("B03.EE.BlanckeK.Models.Answer", b =>
                {
                    b.HasOne("B03.EE.BlanckeK.Models.Question")
                        .WithMany("AnswerList")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("B03.EE.BlanckeK.Models.Question", b =>
                {
                    b.HasOne("B03.EE.BlanckeK.Models.Quiz")
                        .WithMany("Questions")
                        .HasForeignKey("QuizId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("B03.EE.BlanckeK.Models.Quiz", b =>
                {
                    b.HasOne("B03.EE.BlanckeK.Models.User")
                        .WithMany("Quizzes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}