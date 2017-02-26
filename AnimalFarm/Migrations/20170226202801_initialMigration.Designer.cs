using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using AnimalFarm.Models;

namespace AnimalFarm.Migrations
{
    [DbContext(typeof(AnimalContext))]
    [Migration("20170226202801_initialMigration")]
    partial class initialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752");

            modelBuilder.Entity("AnimalFarm.Models.Animal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("animalImage");

                    b.Property<string>("animalName");

                    b.HasKey("Id");

                    b.ToTable("animals");
                });
        }
    }
}
