﻿// <auto-generated />
using Leo.Test.AutoRT.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Leo.Test.AutoRT.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024");

            modelBuilder.Entity("Screen", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Availability");

                    b.Property<string>("BrowserContent");

                    b.Property<string>("BrowserFilter");

                    b.Property<string>("BrowserType");

                    b.Property<string>("Category");

                    b.Property<string>("ScreenContent");

                    b.Property<string>("ScreenFilter");

                    b.Property<string>("ScreenJpName");

                    b.Property<string>("ScreenName");

                    b.Property<string>("ScreenType");

                    b.Property<string>("VeriMethod");

                    b.Property<string>("VeriNo");

                    b.HasKey("Id");

                    b.ToTable("Screens");
                });
#pragma warning restore 612, 618
        }
    }
}
