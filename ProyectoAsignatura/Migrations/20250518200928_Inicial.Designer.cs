﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProyectoAsignatura.Components.Data;

#nullable disable

namespace ProyectoAsignatura.Migrations
{
    [DbContext(typeof(BasedeDatosDbContext))]
    [Migration("20250518200928_Inicial")]
    partial class Inicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProyectoAsignatura.Components.Data.Asignatura", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AulaId")
                        .HasColumnType("int");

                    b.Property<int>("Aula_Id")
                        .HasColumnType("int");

                    b.Property<string>("Horario")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("ProfesorId")
                        .HasColumnType("int");

                    b.Property<int>("Profesor_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AulaId");

                    b.HasIndex("ProfesorId");

                    b.ToTable("Asignaturas");
                });

            modelBuilder.Entity("ProyectoAsignatura.Components.Data.Aula", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Capacidad")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Aula");
                });

            modelBuilder.Entity("ProyectoAsignatura.Components.Data.Profesor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Teléfono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Profesor");
                });

            modelBuilder.Entity("ProyectoAsignatura.Components.Data.Asignatura", b =>
                {
                    b.HasOne("ProyectoAsignatura.Components.Data.Aula", "Aula")
                        .WithMany()
                        .HasForeignKey("AulaId");

                    b.HasOne("ProyectoAsignatura.Components.Data.Profesor", "Profesor")
                        .WithMany()
                        .HasForeignKey("ProfesorId");

                    b.Navigation("Aula");

                    b.Navigation("Profesor");
                });
#pragma warning restore 612, 618
        }
    }
}
