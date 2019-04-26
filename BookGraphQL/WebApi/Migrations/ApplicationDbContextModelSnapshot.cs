﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApi.Data;

namespace WebApi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApi.Data.Models.Book", b =>
                {
                    b.Property<string>("Isbn")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Isbn");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Isbn = "ISBN 978-9930943106",
                            Author = "J. K. Rowling",
                            Title = "Harry Porter"
                        },
                        new
                        {
                            Isbn = "ISBN 978-9929801646",
                            Author = "Enid Blyton",
                            Title = "Famous Five"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}