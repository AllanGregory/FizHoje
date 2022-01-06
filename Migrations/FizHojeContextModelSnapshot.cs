﻿// <auto-generated />
using FizHoje.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace mvc_rest_api_fiz_hoje.Migrations
{
    [DbContext(typeof(FizHojeContext))]
    partial class FizHojeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FizHoje.Models.FizHojeModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DataFeito")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TaFeito")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("FizHoje");
                });
#pragma warning restore 612, 618
        }
    }
}
