﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace one_to_many_rl.Migrations
{
    [DbContext(typeof(ESirketDbContext))]
    partial class ESirketDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Calisan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DepartmanId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DepartmanId");

                    b.ToTable("Calisanlar");
                });

            modelBuilder.Entity("Departman", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("DepartmanAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departmanlar");
                });

            modelBuilder.Entity("Calisan", b =>
                {
                    b.HasOne("Departman", "Departman")
                        .WithMany("Calisanlar")
                        .HasForeignKey("DepartmanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departman");
                });

            modelBuilder.Entity("Departman", b =>
                {
                    b.Navigation("Calisanlar");
                });
#pragma warning restore 612, 618
        }
    }
}
