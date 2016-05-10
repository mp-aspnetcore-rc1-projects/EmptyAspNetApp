using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using BasicAspApp.Models;

namespace BasicAspApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20160509170200_FirstMigration")]
    partial class FirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348");

            modelBuilder.Entity("BasicAspApp.Models.ComputerLanguage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 200);

                    b.Property<DateTime>("UpdateDate")
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");
                });

            modelBuilder.Entity("BasicAspApp.Models.Snippet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ComputerLanguageId");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 5000);

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 200);

                    b.Property<DateTime>("UpateDate")
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");
                });

            modelBuilder.Entity("BasicAspApp.Models.Snippet", b =>
                {
                    b.HasOne("BasicAspApp.Models.ComputerLanguage")
                        .WithMany()
                        .HasForeignKey("ComputerLanguageId");
                });
        }
    }
}
