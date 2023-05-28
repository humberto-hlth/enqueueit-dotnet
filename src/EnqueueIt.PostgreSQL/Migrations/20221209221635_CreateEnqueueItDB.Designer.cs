﻿// <auto-generated />
using System;
using EnqueueIt.PostgreSQL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace EnqueueIt.PostgreSQL.Migrations
{
    [DbContext(typeof(EnqueueItDbContext))]
    [Migration("20221209221635_CreateEnqueueItDB")]
    partial class CreateEnqueueItDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("EnqueueIt")
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("EnqueueIt.Sql.BackgroundJobItem", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("char(36)")
                        .HasColumnName("id");

                    b.Property<DateTime?>("CompletedAt")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("completed_at");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("created_at");

                    b.Property<string>("JobError")
                        .HasColumnType("text")
                        .HasColumnName("job_error");

                    b.Property<string>("JobId")
                        .HasColumnType("char(36)")
                        .HasColumnName("job_id");

                    b.Property<DateTime?>("LastActivity")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("last_activity");

                    b.Property<string>("Logs")
                        .HasColumnType("text")
                        .HasColumnName("logs");

                    b.Property<string>("ProcessedBy")
                        .HasColumnType("char(36)")
                        .HasColumnName("processed_by");

                    b.Property<string>("Server")
                        .HasColumnType("text")
                        .HasColumnName("server");

                    b.Property<DateTime?>("StartedAt")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("started_at");

                    b.Property<int>("Status")
                        .HasColumnType("smallint")
                        .HasColumnName("status");

                    b.HasKey("Id")
                        .HasName("pk_background_jobs");

                    b.HasIndex("JobId")
                        .HasDatabaseName("ix_background_jobs_job_id");

                    b.ToTable("background_jobs");
                });

            modelBuilder.Entity("EnqueueIt.Sql.JobItem", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("char(36)")
                        .HasColumnName("id");

                    b.Property<bool>("Active")
                        .HasColumnType("boolean")
                        .HasColumnName("active");

                    b.Property<string>("AfterBackgroundJobIds")
                        .HasColumnType("text")
                        .HasColumnName("after_background_job_ids");

                    b.Property<string>("AppName")
                        .HasColumnType("text")
                        .HasColumnName("app_name");

                    b.Property<string>("Argument")
                        .HasColumnType("text")
                        .HasColumnName("argument");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("created_at");

                    b.Property<bool>("IsRecurring")
                        .HasColumnType("boolean")
                        .HasColumnName("is_recurring");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("Queue")
                        .HasColumnType("text")
                        .HasColumnName("queue");

                    b.Property<string>("Recurring")
                        .HasColumnType("text")
                        .HasColumnName("recurring");

                    b.Property<DateTime?>("StartAt")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("start_at");

                    b.Property<int>("Tries")
                        .HasColumnType("int")
                        .HasColumnName("tries");

                    b.Property<int>("Type")
                        .HasColumnType("smallint")
                        .HasColumnName("type");

                    b.HasKey("Id")
                        .HasName("pk_jobs");

                    b.ToTable("jobs");
                });

            modelBuilder.Entity("EnqueueIt.Sql.BackgroundJobItem", b =>
                {
                    b.HasOne("EnqueueIt.Sql.JobItem", "Job")
                        .WithMany("BackgroundJobs")
                        .HasForeignKey("JobId")
                        .HasConstraintName("fk_background_jobs_jobs_job_id");

                    b.Navigation("Job");
                });

            modelBuilder.Entity("EnqueueIt.Sql.JobItem", b =>
                {
                    b.Navigation("BackgroundJobs");
                });
#pragma warning restore 612, 618
        }
    }
}