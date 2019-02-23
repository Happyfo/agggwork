﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using FilmprodconsoleApp.NewDb;

namespace ConsoleApp1.Migrations
{
    [DbContext(typeof(FilmprodconsoleContext))]
    partial class FilmprodconsoleContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FilmprodconsoleApp.NewDb.Filmprodconsoletbl", b =>
                {
                    b.Property<int>("FilmprodconsoleId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("category_name");

                    b.Property<string>("title");

                    b.Property<string>("year");

                    b.HasKey("FilmprodconsoleId");

                    b.ToTable("Filmprodconsoles");
                });
#pragma warning restore 612, 618
        }
    }
}