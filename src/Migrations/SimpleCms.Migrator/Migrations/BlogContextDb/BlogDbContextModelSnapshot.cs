﻿// <auto-generated />
using SimpleCms.BlogContext.Core.Domain;
using SimpleCms.BlogContext.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace SimpleCms.Migrator.Migrations.BlogContextDb
{
    [DbContext(typeof(BlogDbContext))]
    partial class BlogDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BlogCore.BlogContext.Core.Domain.Blog", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("BlogSettingId");

                    b.Property<string>("Description");

                    b.Property<string>("ImageFilePath")
                        .IsRequired();

                    b.Property<string>("OwnerEmail")
                        .IsRequired();

                    b.Property<int>("Status");

                    b.Property<int>("Theme");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("BlogSettingId");

                    b.ToTable("Blogs","blog");
                });

            modelBuilder.Entity("BlogCore.BlogContext.Core.Domain.BlogSetting", b =>
                {
                    b.Property<Guid>("BlogSettingId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DaysToComment");

                    b.Property<bool>("ModerateComments");

                    b.Property<int>("PostsPerPage");

                    b.HasKey("BlogSettingId");

                    b.ToTable("BlogSettings","blog");
                });

            modelBuilder.Entity("BlogCore.BlogContext.Core.Domain.Blog", b =>
                {
                    b.HasOne("BlogCore.BlogContext.Core.Domain.BlogSetting", "BlogSetting")
                        .WithMany()
                        .HasForeignKey("BlogSettingId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
