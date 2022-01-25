﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TodoAPI.Models;

#nullable disable

namespace TodoAPI.Migrations
{
    [DbContext(typeof(ToDoContext))]
    [Migration("20220123231052_InitialCreater")]
    partial class InitialCreater
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.1");

            modelBuilder.Entity("TodoAPI.Models.Todo", b =>
                {
                    b.Property<int>("TodoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("TodoId1")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TodoName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("TodoId");

                    b.HasIndex("TodoId1");

                    b.ToTable("Todos");
                });

            modelBuilder.Entity("TodoAPI.Models.Todo", b =>
                {
                    b.HasOne("TodoAPI.Models.Todo", null)
                        .WithMany("Todos")
                        .HasForeignKey("TodoId1");
                });

            modelBuilder.Entity("TodoAPI.Models.Todo", b =>
                {
                    b.Navigation("Todos");
                });
#pragma warning restore 612, 618
        }
    }
}
