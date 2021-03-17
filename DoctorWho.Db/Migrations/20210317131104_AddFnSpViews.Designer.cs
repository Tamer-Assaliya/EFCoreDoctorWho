﻿// <auto-generated />
using System;
using DoctorWho.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DoctorWho.Db.Migrations
{
    [DbContext(typeof(DoctorWhoCoreDbContext))]
    [Migration("20210317131104_AddFnSpViews")]
    partial class AddFnSpViews
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DoctorWho.Db.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AuthorName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            AuthorId = 1,
                            AuthorName = "tamer"
                        },
                        new
                        {
                            AuthorId = 2,
                            AuthorName = "Fadi"
                        },
                        new
                        {
                            AuthorId = 3,
                            AuthorName = "Mohannad"
                        },
                        new
                        {
                            AuthorId = 4,
                            AuthorName = "Mohammed"
                        },
                        new
                        {
                            AuthorId = 5,
                            AuthorName = "Ayman"
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.Companion", b =>
                {
                    b.Property<int>("CompanionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanionName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WhoPlayed")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CompanionId");

                    b.ToTable("Companions");

                    b.HasData(
                        new
                        {
                            CompanionId = 5,
                            CompanionName = "Samer",
                            WhoPlayed = "Khalid"
                        },
                        new
                        {
                            CompanionId = 1,
                            CompanionName = "Emad",
                            WhoPlayed = "Omar"
                        },
                        new
                        {
                            CompanionId = 2,
                            CompanionName = "Sameer",
                            WhoPlayed = "Ward"
                        },
                        new
                        {
                            CompanionId = 3,
                            CompanionName = "Leen",
                            WhoPlayed = "Roa"
                        },
                        new
                        {
                            CompanionId = 4,
                            CompanionName = "Naheel",
                            WhoPlayed = "Sali"
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.Doctor", b =>
                {
                    b.Property<int>("DoctorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DoctorName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DoctorNumber")
                        .HasColumnType("int");

                    b.Property<DateTime?>("FirstEpisodeDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastEpisodeDate")
                        .HasColumnType("datetime2");

                    b.HasKey("DoctorId");

                    b.ToTable("Doctors");

                    b.HasData(
                        new
                        {
                            DoctorId = 1,
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 1, 998, DateTimeKind.Unspecified).AddTicks(601),
                            DoctorName = "John",
                            DoctorNumber = 834676823,
                            FirstEpisodeDate = new DateTime(1, 1, 1, 0, 0, 1, 998, DateTimeKind.Unspecified).AddTicks(602),
                            LastEpisodeDate = new DateTime(1, 1, 1, 0, 0, 2, 12, DateTimeKind.Unspecified).AddTicks(601)
                        },
                        new
                        {
                            DoctorId = 2,
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 1, 898, DateTimeKind.Unspecified).AddTicks(1201),
                            DoctorName = "Majd",
                            DoctorNumber = 511385412,
                            FirstEpisodeDate = new DateTime(1, 1, 1, 0, 0, 1, 998, DateTimeKind.Unspecified).AddTicks(1211),
                            LastEpisodeDate = new DateTime(1, 1, 1, 0, 0, 1, 999, DateTimeKind.Unspecified).AddTicks(511)
                        },
                        new
                        {
                            DoctorId = 3,
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 2, 0, DateTimeKind.Unspecified).AddTicks(506),
                            DoctorName = "Alaa",
                            DoctorNumber = 589135733,
                            FirstEpisodeDate = new DateTime(1, 1, 1, 0, 0, 2, 7, DateTimeKind.Unspecified).AddTicks(706),
                            LastEpisodeDate = new DateTime(1, 1, 1, 0, 0, 2, 15, DateTimeKind.Unspecified).AddTicks(113)
                        },
                        new
                        {
                            DoctorId = 4,
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 1, 990, DateTimeKind.Unspecified).AddTicks(714),
                            DoctorName = "Nihad",
                            DoctorNumber = 399178240,
                            FirstEpisodeDate = new DateTime(1, 1, 1, 0, 0, 1, 995, DateTimeKind.Unspecified).AddTicks(216),
                            LastEpisodeDate = new DateTime(1, 1, 1, 0, 0, 1, 997, DateTimeKind.Unspecified).AddTicks(809)
                        },
                        new
                        {
                            DoctorId = 5,
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 1, 983, DateTimeKind.Unspecified).AddTicks(417),
                            DoctorName = "Ali",
                            DoctorNumber = 388528561,
                            FirstEpisodeDate = new DateTime(1, 1, 1, 0, 0, 1, 988, DateTimeKind.Unspecified).AddTicks(815),
                            LastEpisodeDate = new DateTime(1, 1, 1, 0, 0, 1, 998, DateTimeKind.Unspecified).AddTicks(205)
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.Enemy", b =>
                {
                    b.Property<int>("EnemyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnemyName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EnemyId");

                    b.ToTable("Enemys");

                    b.HasData(
                        new
                        {
                            EnemyId = 1,
                            Description = "an evil one",
                            EnemyName = "Suha"
                        },
                        new
                        {
                            EnemyId = 2,
                            Description = "a cute one",
                            EnemyName = "Jameel"
                        },
                        new
                        {
                            EnemyId = 3,
                            Description = "the wildest",
                            EnemyName = "Jamal"
                        },
                        new
                        {
                            EnemyId = 4,
                            Description = "Unexpected one",
                            EnemyName = "Areen"
                        },
                        new
                        {
                            EnemyId = 5,
                            Description = "As the fire",
                            EnemyName = "Yazan"
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.Episode", b =>
                {
                    b.Property<int>("EpisodeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int?>("DoctorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EpisodeDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("EpisodeNumber")
                        .HasColumnType("int");

                    b.Property<string>("EpisodeType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SeriesNumber")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EpisodeId");

                    b.HasIndex("AuthorId");

                    b.HasIndex("DoctorId");

                    b.ToTable("Episodes");

                    b.HasData(
                        new
                        {
                            EpisodeId = 1,
                            AuthorId = 2,
                            DoctorId = 2,
                            EpisodeDate = new DateTime(1, 1, 1, 0, 0, 2, 21, DateTimeKind.Unspecified).AddTicks(414),
                            EpisodeNumber = 565,
                            EpisodeType = "Action",
                            Notes = "best car drifting",
                            SeriesNumber = 432,
                            Title = "Fast & Furios"
                        },
                        new
                        {
                            EpisodeId = 2,
                            AuthorId = 4,
                            DoctorId = 3,
                            EpisodeDate = new DateTime(1, 1, 1, 0, 0, 2, 15, DateTimeKind.Unspecified).AddTicks(502),
                            EpisodeNumber = 112,
                            EpisodeType = "Fancy",
                            Notes = "back to worldwide war 2",
                            SeriesNumber = 433,
                            Title = "The Game"
                        },
                        new
                        {
                            EpisodeId = 3,
                            AuthorId = 5,
                            DoctorId = 1,
                            EpisodeDate = new DateTime(1, 1, 1, 0, 0, 2, 13, DateTimeKind.Unspecified).AddTicks(1204),
                            EpisodeNumber = 629,
                            EpisodeType = "Funny",
                            Notes = "loved by people",
                            SeriesNumber = 766,
                            Title = "GOT"
                        },
                        new
                        {
                            EpisodeId = 4,
                            AuthorId = 1,
                            DoctorId = 2,
                            EpisodeDate = new DateTime(1, 1, 1, 0, 0, 2, 0, DateTimeKind.Unspecified).AddTicks(1123),
                            EpisodeNumber = 257,
                            EpisodeType = "Thriller",
                            Notes = "An exciting one",
                            SeriesNumber = 551,
                            Title = "Prison Break"
                        },
                        new
                        {
                            EpisodeId = 5,
                            AuthorId = 1,
                            DoctorId = 3,
                            EpisodeDate = new DateTime(1, 1, 1, 0, 0, 2, 18, DateTimeKind.Unspecified).AddTicks(512),
                            EpisodeNumber = 391,
                            EpisodeType = "Mystrey",
                            Notes = "psychopath lover",
                            SeriesNumber = 984,
                            Title = "You"
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.EpisodeCompanion", b =>
                {
                    b.Property<int>("EpisodeId")
                        .HasColumnType("int");

                    b.Property<int>("CompanionId")
                        .HasColumnType("int");

                    b.HasKey("EpisodeId", "CompanionId");

                    b.HasIndex("CompanionId");

                    b.ToTable("EpisodeCompanion");

                    b.HasData(
                        new
                        {
                            EpisodeId = 2,
                            CompanionId = 5
                        },
                        new
                        {
                            EpisodeId = 3,
                            CompanionId = 1
                        },
                        new
                        {
                            EpisodeId = 5,
                            CompanionId = 2
                        },
                        new
                        {
                            EpisodeId = 1,
                            CompanionId = 3
                        },
                        new
                        {
                            EpisodeId = 4,
                            CompanionId = 3
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.EpisodeEnemy", b =>
                {
                    b.Property<int>("EpisodeId")
                        .HasColumnType("int");

                    b.Property<int>("EnemyId")
                        .HasColumnType("int");

                    b.HasKey("EpisodeId", "EnemyId");

                    b.HasIndex("EnemyId");

                    b.ToTable("EpisodeEnemy");

                    b.HasData(
                        new
                        {
                            EpisodeId = 3,
                            EnemyId = 4
                        },
                        new
                        {
                            EpisodeId = 1,
                            EnemyId = 1
                        },
                        new
                        {
                            EpisodeId = 5,
                            EnemyId = 2
                        },
                        new
                        {
                            EpisodeId = 1,
                            EnemyId = 3
                        },
                        new
                        {
                            EpisodeId = 4,
                            EnemyId = 3
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.Episode", b =>
                {
                    b.HasOne("DoctorWho.Db.Author", "Author")
                        .WithMany("Episodes")
                        .HasForeignKey("AuthorId");

                    b.HasOne("DoctorWho.Db.Doctor", "Doctor")
                        .WithMany("Episodes")
                        .HasForeignKey("DoctorId");

                    b.Navigation("Author");

                    b.Navigation("Doctor");
                });

            modelBuilder.Entity("DoctorWho.Db.EpisodeCompanion", b =>
                {
                    b.HasOne("DoctorWho.Db.Companion", "Companion")
                        .WithMany("EpisodeCompanions")
                        .HasForeignKey("CompanionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoctorWho.Db.Episode", "Episode")
                        .WithMany("EpisodeCompanions")
                        .HasForeignKey("EpisodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Companion");

                    b.Navigation("Episode");
                });

            modelBuilder.Entity("DoctorWho.Db.EpisodeEnemy", b =>
                {
                    b.HasOne("DoctorWho.Db.Enemy", "Enemy")
                        .WithMany("EpisodeEnemyies")
                        .HasForeignKey("EnemyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoctorWho.Db.Episode", "Episode")
                        .WithMany("EpisodeEnemyies")
                        .HasForeignKey("EpisodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Enemy");

                    b.Navigation("Episode");
                });

            modelBuilder.Entity("DoctorWho.Db.Author", b =>
                {
                    b.Navigation("Episodes");
                });

            modelBuilder.Entity("DoctorWho.Db.Companion", b =>
                {
                    b.Navigation("EpisodeCompanions");
                });

            modelBuilder.Entity("DoctorWho.Db.Doctor", b =>
                {
                    b.Navigation("Episodes");
                });

            modelBuilder.Entity("DoctorWho.Db.Enemy", b =>
                {
                    b.Navigation("EpisodeEnemyies");
                });

            modelBuilder.Entity("DoctorWho.Db.Episode", b =>
                {
                    b.Navigation("EpisodeCompanions");

                    b.Navigation("EpisodeEnemyies");
                });
#pragma warning restore 612, 618
        }
    }
}
