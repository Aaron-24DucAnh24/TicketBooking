﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TicketBooking.API.EF;

#nullable disable

namespace TicketBooking.API.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230723031031_new")]
    partial class @new
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TicketBooking.API.Models.Category", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)")
                        .HasDefaultValue("a480bf3a-6fc7-4c4a-aea5-6342e1cc8119");

                    b.Property<DateTime?>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 7, 23, 10, 10, 31, 447, DateTimeKind.Local).AddTicks(7050));

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Category", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "c1",
                            IsDeleted = false,
                            Name = "Theater"
                        },
                        new
                        {
                            Id = "c2",
                            IsDeleted = false,
                            Name = "Music"
                        },
                        new
                        {
                            Id = "c3",
                            IsDeleted = false,
                            Name = "Comedy"
                        },
                        new
                        {
                            Id = "c4",
                            IsDeleted = false,
                            Name = "Play"
                        });
                });

            modelBuilder.Entity("TicketBooking.API.Models.Event", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)")
                        .HasDefaultValue("6cf475ff-a220-4e52-9e63-136780a522f8");

                    b.Property<string>("City")
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 7, 23, 10, 10, 31, 447, DateTimeKind.Local).AddTicks(2790));

                    b.Property<DateTime>("Date")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 8, 11, 21, 15, 0, 0, DateTimeKind.Unspecified));

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Image")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MinPrice")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(2);

                    b.Property<string>("Title")
                        .IsRequired()
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Event", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "e1",
                            City = "",
                            Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Image = "https://gonewiththetwins.com/new/wp-content/uploads/2016/06/click.jpg",
                            IsDeleted = false,
                            Location = "CGV Phu Tho",
                            MinPrice = 60000,
                            Status = 0,
                            Title = "The click"
                        },
                        new
                        {
                            Id = "e2",
                            City = "",
                            Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Image = "https://kenhcine.cgv.vn/media/catalog/product/1/5/1545333390524.jpg",
                            IsDeleted = false,
                            Location = "CGV Phu Tho",
                            MinPrice = 70000,
                            Status = 0,
                            Title = "Man in Black V"
                        },
                        new
                        {
                            Id = "e3",
                            City = "",
                            Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Image = "https://toplist.vn/images/800px/django-unchained-151603.jpg",
                            IsDeleted = false,
                            Location = "CGV Hung Vuong",
                            MinPrice = 80000,
                            Status = 0,
                            Title = "Django unchained"
                        },
                        new
                        {
                            Id = "e4",
                            City = "Hà Nội",
                            Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Image = "https://kenh14cdn.com/thumb_w/600/203336854389633024/2022/12/13/photo1670894930473-1670894930937151252993.png",
                            IsDeleted = false,
                            Location = "New Arena Theater",
                            MinPrice = 70000,
                            Status = 0,
                            Title = "Gala Cười 2023"
                        },
                        new
                        {
                            Id = "e5",
                            City = "Hà Nội",
                            Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Image = "https://static2.yan.vn/YanNews/2167221/202110/sky-tour-movie-tuoi-tre-nhiet-huyet-va-dam-me-cua-son-tung-mtp-08241d81.jpg",
                            IsDeleted = false,
                            Location = "New Arena Theater",
                            MinPrice = 65000,
                            Status = 0,
                            Title = "Sky Tour"
                        },
                        new
                        {
                            Id = "e6",
                            City = "Hà Nội",
                            Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Image = "https://media-cdn-v2.laodong.vn/Storage/NewsPortal/2021/4/2/895272/Anh_2_Mytam_PR03.JPG",
                            IsDeleted = false,
                            Location = "The Savarin Theater",
                            MinPrice = 1000000,
                            Status = 0,
                            Title = "Mỹ Tâm - Liveshow tri âm"
                        });
                });

            modelBuilder.Entity("TicketBooking.API.Models.EventCategory", b =>
                {
                    b.Property<string>("EventId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CategoryId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("EventId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("EventCategory", (string)null);

                    b.HasData(
                        new
                        {
                            EventId = "e1",
                            CategoryId = "c1"
                        },
                        new
                        {
                            EventId = "e2",
                            CategoryId = "c1"
                        },
                        new
                        {
                            EventId = "e3",
                            CategoryId = "c1"
                        },
                        new
                        {
                            EventId = "e4",
                            CategoryId = "c3"
                        },
                        new
                        {
                            EventId = "e5",
                            CategoryId = "c2"
                        },
                        new
                        {
                            EventId = "e6",
                            CategoryId = "c2"
                        },
                        new
                        {
                            EventId = "e5",
                            CategoryId = "c4"
                        });
                });

            modelBuilder.Entity("TicketBooking.API.Models.Invoice", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)")
                        .HasDefaultValue("a8a41a10-b573-4fca-9e76-fbc588fc55d9");

                    b.Property<DateTime?>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 7, 23, 10, 10, 31, 447, DateTimeKind.Local).AddTicks(4800));

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("EventId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.ToTable("Invoice", (string)null);
                });

            modelBuilder.Entity("TicketBooking.API.Models.Seat", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)")
                        .HasDefaultValue("78c6790c-983a-4206-8a65-75643b2f129a");

                    b.Property<DateTime?>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 7, 23, 10, 10, 31, 447, DateTimeKind.Local).AddTicks(6110));

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Seat", (string)null);
                });

            modelBuilder.Entity("TicketBooking.API.Models.SeatEvent", b =>
                {
                    b.Property<string>("EventId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SeatId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("SeatStatus")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.HasKey("EventId", "SeatId");

                    b.HasIndex("SeatId");

                    b.ToTable("SeatEvent", (string)null);
                });

            modelBuilder.Entity("TicketBooking.API.Models.SeatInvoice", b =>
                {
                    b.Property<string>("InvoiceId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SeatId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("InvoiceId", "SeatId");

                    b.HasIndex("SeatId");

                    b.ToTable("SeatInvoice", (string)null);
                });

            modelBuilder.Entity("TicketBooking.API.Models.EventCategory", b =>
                {
                    b.HasOne("TicketBooking.API.Models.Category", "Category")
                        .WithMany("EventCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TicketBooking.API.Models.Event", "Event")
                        .WithMany("EventCategories")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Event");
                });

            modelBuilder.Entity("TicketBooking.API.Models.Invoice", b =>
                {
                    b.HasOne("TicketBooking.API.Models.Event", "Event")
                        .WithMany("Invoices")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Event");
                });

            modelBuilder.Entity("TicketBooking.API.Models.SeatEvent", b =>
                {
                    b.HasOne("TicketBooking.API.Models.Event", "Event")
                        .WithMany("SeatEvents")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TicketBooking.API.Models.Seat", "Seat")
                        .WithMany("SeatEvents")
                        .HasForeignKey("SeatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Event");

                    b.Navigation("Seat");
                });

            modelBuilder.Entity("TicketBooking.API.Models.SeatInvoice", b =>
                {
                    b.HasOne("TicketBooking.API.Models.Invoice", "Invoice")
                        .WithMany("SeatInvoices")
                        .HasForeignKey("InvoiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TicketBooking.API.Models.Seat", "Seat")
                        .WithMany("SeatInvoices")
                        .HasForeignKey("SeatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Invoice");

                    b.Navigation("Seat");
                });

            modelBuilder.Entity("TicketBooking.API.Models.Category", b =>
                {
                    b.Navigation("EventCategories");
                });

            modelBuilder.Entity("TicketBooking.API.Models.Event", b =>
                {
                    b.Navigation("EventCategories");

                    b.Navigation("Invoices");

                    b.Navigation("SeatEvents");
                });

            modelBuilder.Entity("TicketBooking.API.Models.Invoice", b =>
                {
                    b.Navigation("SeatInvoices");
                });

            modelBuilder.Entity("TicketBooking.API.Models.Seat", b =>
                {
                    b.Navigation("SeatEvents");

                    b.Navigation("SeatInvoices");
                });
#pragma warning restore 612, 618
        }
    }
}
