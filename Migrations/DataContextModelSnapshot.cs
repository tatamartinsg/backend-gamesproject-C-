﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using games_api.Data;

#nullable disable

namespace gamesapi.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("games_api.Models.GameModel", b =>
                {
                    b.Property<int>("idGame")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ImageidImage")
                        .HasColumnType("int");

                    b.Property<string>("classification")
                        .HasColumnType("longtext");

                    b.Property<int>("idImage")
                        .HasColumnType("int");

                    b.Property<string>("keyWord")
                        .HasColumnType("longtext");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("releaseDate")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("synopsis")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("video")
                        .HasColumnType("longtext");

                    b.HasKey("idGame");

                    b.HasIndex("ImageidImage");

                    b.ToTable("game");
                });

            modelBuilder.Entity("games_api.Models.ImageModel", b =>
                {
                    b.Property<int>("idImage")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("imageBg")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("imageCard")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("idImage");

                    b.ToTable("image");
                });

            modelBuilder.Entity("games_api.Models.GameModel", b =>
                {
                    b.HasOne("games_api.Models.ImageModel", "Image")
                        .WithMany()
                        .HasForeignKey("ImageidImage")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Image");
                });
#pragma warning restore 612, 618
        }
    }
}
