// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PhoenixServer.BackEnd.Data;

#nullable disable

namespace PhoenixServer.BackEnd.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20220205080058_addedDataTypes")]
    partial class addedDataTypes
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("PhoenixServer.Core.Entities.Acceleration", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("acceleration_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("Datetime")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("acceleration_date");

                    b.Property<float>("xAxis")
                        .HasColumnType("real")
                        .HasColumnName("acceleration_x");

                    b.Property<float>("yAxis")
                        .HasColumnType("real")
                        .HasColumnName("acceleration_y");

                    b.Property<float>("zAxis")
                        .HasColumnType("real")
                        .HasColumnName("acceleration_z");

                    b.HasKey("ID");

                    b.ToTable("Accelerations");
                });

            modelBuilder.Entity("PhoenixServer.Core.Entities.Altitude", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("altitude_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("Datetime")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("altitude_date");

                    b.Property<float>("Value")
                        .HasColumnType("real")
                        .HasColumnName("altitude_altitude");

                    b.HasKey("ID");

                    b.ToTable("Altitudes");
                });

            modelBuilder.Entity("PhoenixServer.Core.Entities.AngularVelocity", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("angularVelocity_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("Datetime")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("angularVelocity_date");

                    b.Property<float>("xAxis")
                        .HasColumnType("real")
                        .HasColumnName("angularVelocity_x");

                    b.Property<float>("yAxis")
                        .HasColumnType("real")
                        .HasColumnName("angularVelocity_y");

                    b.Property<float>("zAxis")
                        .HasColumnType("real")
                        .HasColumnName("angularVelocity_z");

                    b.HasKey("ID");

                    b.ToTable("AngularVelocities");
                });

            modelBuilder.Entity("PhoenixServer.Core.Entities.Gravity", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("gravity_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("Datetime")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("gravity_date");

                    b.Property<float>("xAxis")
                        .HasColumnType("real")
                        .HasColumnName("gravity_x");

                    b.Property<float>("yAxis")
                        .HasColumnType("real")
                        .HasColumnName("gravity_y");

                    b.Property<float>("zAxis")
                        .HasColumnType("real")
                        .HasColumnName("gravity_z");

                    b.HasKey("ID");

                    b.ToTable("Gravities");
                });

            modelBuilder.Entity("PhoenixServer.Core.Entities.Humidity", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("humidity_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("Datetime")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("humidity_date");

                    b.Property<float>("Value")
                        .HasColumnType("real")
                        .HasColumnName("humidity_humidity");

                    b.HasKey("ID");

                    b.ToTable("Humidities");
                });

            modelBuilder.Entity("PhoenixServer.Core.Entities.MagneticField", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("magneticField_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("Datetime")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("magneticField_date");

                    b.Property<float>("xAxis")
                        .HasColumnType("real")
                        .HasColumnName("magneticField_x");

                    b.Property<float>("yAxis")
                        .HasColumnType("real")
                        .HasColumnName("magneticField_y");

                    b.Property<float>("zAxis")
                        .HasColumnType("real")
                        .HasColumnName("magneticField_z");

                    b.HasKey("ID");

                    b.ToTable("MagneticFields");
                });

            modelBuilder.Entity("PhoenixServer.Core.Entities.Orientation", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("orientation_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("Datetime")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("orientation_date");

                    b.Property<float>("xAxis")
                        .HasColumnType("real")
                        .HasColumnName("orientation_x");

                    b.Property<float>("yAxis")
                        .HasColumnType("real")
                        .HasColumnName("orientation_y");

                    b.Property<float>("zAxis")
                        .HasColumnType("real")
                        .HasColumnName("orientation_z");

                    b.HasKey("ID");

                    b.ToTable("Orientations");
                });

            modelBuilder.Entity("PhoenixServer.Core.Entities.Position", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("position_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("Datetime")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("position_date");

                    b.Property<float>("Latitude")
                        .HasColumnType("real")
                        .HasColumnName("position_latitude");

                    b.Property<float>("Longitude")
                        .HasColumnType("real")
                        .HasColumnName("position_longitude");

                    b.HasKey("ID");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("PhoenixServer.Core.Entities.Pressure", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("pressure_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("Datetime")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("pressure_date");

                    b.Property<float>("Value")
                        .HasColumnType("real")
                        .HasColumnName("pressure_pressure");

                    b.HasKey("ID");

                    b.ToTable("Pressures");
                });

            modelBuilder.Entity("PhoenixServer.Core.Entities.Temperature", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("temperature_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("Datetime")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("temperature_date");

                    b.Property<float>("Value")
                        .HasColumnType("real")
                        .HasColumnName("temperature_temperature");

                    b.HasKey("ID");

                    b.ToTable("Temperatures");
                });
#pragma warning restore 612, 618
        }
    }
}
