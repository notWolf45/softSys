﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using softSys_1.Models;

namespace softSys_1.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("softSys_1.Models.DelivStore", b =>
                {
                    b.Property<int>("StoresID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("delivsID")
                        .HasColumnType("INTEGER");

                    b.HasKey("StoresID", "delivsID");

                    b.HasIndex("delivsID");

                    b.ToTable("DelivStore");
                });

            modelBuilder.Entity("softSys_1.Models.Stores", b =>
                {
                    b.Property<int>("StoresID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("StoreName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(60);

                    b.Property<string>("address")
                        .HasColumnType("TEXT");

                    b.Property<string>("food")
                        .HasColumnType("TEXT");

                    b.HasKey("StoresID");

                    b.ToTable("Stores");
                });

            modelBuilder.Entity("softSys_1.Models.delivs", b =>
                {
                    b.Property<int>("delivsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DriverName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(60);

                    b.Property<string>("address")
                        .HasColumnType("TEXT");

                    b.HasKey("delivsID");

                    b.ToTable("deliv");
                });

            modelBuilder.Entity("softSys_1.Models.users", b =>
                {
                    b.Property<int>("usersID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(60);

                    b.HasKey("usersID");

                    b.ToTable("users");
                });

            modelBuilder.Entity("softSys_1.Models.DelivStore", b =>
                {
                    b.HasOne("softSys_1.Models.Stores", "Store")
                        .WithMany()
                        .HasForeignKey("StoresID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("softSys_1.Models.delivs", "drivers")
                        .WithMany()
                        .HasForeignKey("delivsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
