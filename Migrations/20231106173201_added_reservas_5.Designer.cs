﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using reservasedufoscal.Data;

#nullable disable

namespace reservasedufoscal.Migrations
{
    [DbContext(typeof(firstDbcontext))]
    [Migration("20231106173201_added_reservas_5")]
    partial class added_reservas_5
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("reservasedufoscal.Data.models.espacios", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<bool>("activo")
                        .HasColumnType("bit");

                    b.Property<int>("capacidad")
                        .HasColumnType("int");

                    b.Property<DateTime>("horafin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("horainicio")
                        .HasColumnType("datetime2");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tipologia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("espacios");
                });

            modelBuilder.Entity("reservasedufoscal.Data.models.reserva", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("espacioid")
                        .HasColumnType("int");

                    b.Property<DateTime>("fechafin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("fechainicio")
                        .HasColumnType("datetime2");

                    b.Property<int>("npersonas")
                        .HasColumnType("int");

                    b.Property<string>("observacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("statusid")
                        .HasColumnType("int");

                    b.Property<int>("usuarioid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("espacioid");

                    b.HasIndex("statusid");

                    b.HasIndex("usuarioid");

                    b.ToTable("reserva");
                });

            modelBuilder.Entity("reservasedufoscal.Data.models.roles", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("roles");
                });

            modelBuilder.Entity("reservasedufoscal.Data.models.status", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("status");
                });

            modelBuilder.Entity("reservasedufoscal.Data.models.tipoUsuario", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("rolid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("rolid");

                    b.ToTable("tipoUsuarios");
                });

            modelBuilder.Entity("reservasedufoscal.Data.models.usuario", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("TipoUsuarioid")
                        .HasColumnType("int");

                    b.Property<string>("apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("celular")
                        .HasColumnType("int");

                    b.Property<string>("correo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("identificacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("numeroEmpleado")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("TipoUsuarioid");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("reservasedufoscal.Data.models.reserva", b =>
                {
                    b.HasOne("reservasedufoscal.Data.models.espacios", "espacio")
                        .WithMany()
                        .HasForeignKey("espacioid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("reservasedufoscal.Data.models.status", "status")
                        .WithMany()
                        .HasForeignKey("statusid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("reservasedufoscal.Data.models.usuario", "usuario")
                        .WithMany()
                        .HasForeignKey("usuarioid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("espacio");

                    b.Navigation("status");

                    b.Navigation("usuario");
                });

            modelBuilder.Entity("reservasedufoscal.Data.models.tipoUsuario", b =>
                {
                    b.HasOne("reservasedufoscal.Data.models.roles", "rol")
                        .WithMany()
                        .HasForeignKey("rolid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("rol");
                });

            modelBuilder.Entity("reservasedufoscal.Data.models.usuario", b =>
                {
                    b.HasOne("reservasedufoscal.Data.models.tipoUsuario", "TipoUsuario")
                        .WithMany()
                        .HasForeignKey("TipoUsuarioid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TipoUsuario");
                });
#pragma warning restore 612, 618
        }
    }
}
