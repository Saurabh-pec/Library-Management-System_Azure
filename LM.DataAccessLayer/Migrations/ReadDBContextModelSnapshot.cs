﻿// <auto-generated />
using System;
using LMS.DataAccessLayer.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LMS.DataAccessLayer.Migrations
{
    [DbContext(typeof(ReadDBContext))]
    partial class ReadDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LMS.DataAccessLayer.Entities.Book", b =>
                {
                    b.Property<int>("bookId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("author")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("genre");

                    b.Property<double>("price");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("bookId");

                    b.ToTable("books");
                });

            modelBuilder.Entity("LMS.DataAccessLayer.Entities.BookLibraryAssociation", b =>
                {
                    b.Property<int>("bookLibraryAssociationId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("bookId");

                    b.Property<bool>("isAvailable");

                    b.Property<bool>("isCheckedOut");

                    b.Property<int>("libraryId");

                    b.HasKey("bookLibraryAssociationId");

                    b.ToTable("bookLibraryAssociations");
                });

            modelBuilder.Entity("LMS.DataAccessLayer.Entities.Library", b =>
                {
                    b.Property<int>("libraryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("locationId");

                    b.HasKey("libraryId");

                    b.ToTable("libraries");
                });

            modelBuilder.Entity("LMS.DataAccessLayer.Entities.Location", b =>
                {
                    b.Property<int>("locationId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("locationName")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("locationId");

                    b.ToTable("locations");
                });

            modelBuilder.Entity("LMS.DataAccessLayer.Entities.Role", b =>
                {
                    b.Property<int>("roleId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("roleId");

                    b.ToTable("roles");
                });

            modelBuilder.Entity("LMS.DataAccessLayer.Entities.User", b =>
                {
                    b.Property<int>("userId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("locationId");

                    b.Property<string>("password")
                        .IsRequired();

                    b.Property<int>("roleId");

                    b.Property<string>("userName")
                        .IsRequired();

                    b.HasKey("userId");

                    b.ToTable("users");
                });

            modelBuilder.Entity("LMS.DataAccessLayer.Entities.UserBookAssociation", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookLibraryAssociationId");

                    b.Property<DateTime>("DueDate");

                    b.Property<int>("userId");

                    b.HasKey("id");

                    b.ToTable("userBookAssociations");
                });
#pragma warning restore 612, 618
        }
    }
}