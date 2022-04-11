using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace PhoenixServer.BackEnd.Migrations
{
    public partial class addedDataTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accelerations",
                columns: table => new
                {
                    acceleration_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    acceleration_x = table.Column<float>(type: "real", nullable: false),
                    acceleration_y = table.Column<float>(type: "real", nullable: false),
                    acceleration_z = table.Column<float>(type: "real", nullable: false),
                    acceleration_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accelerations", x => x.acceleration_id);
                });

            migrationBuilder.CreateTable(
                name: "Altitudes",
                columns: table => new
                {
                    altitude_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    altitude_altitude = table.Column<float>(type: "real", nullable: false),
                    altitude_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Altitudes", x => x.altitude_id);
                });

            migrationBuilder.CreateTable(
                name: "AngularVelocities",
                columns: table => new
                {
                    angularVelocity_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    angularVelocity_x = table.Column<float>(type: "real", nullable: false),
                    angularVelocity_y = table.Column<float>(type: "real", nullable: false),
                    angularVelocity_z = table.Column<float>(type: "real", nullable: false),
                    angularVelocity_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AngularVelocities", x => x.angularVelocity_id);
                });

            migrationBuilder.CreateTable(
                name: "Gravities",
                columns: table => new
                {
                    gravity_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    gravity_x = table.Column<float>(type: "real", nullable: false),
                    gravity_y = table.Column<float>(type: "real", nullable: false),
                    gravity_z = table.Column<float>(type: "real", nullable: false),
                    gravity_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gravities", x => x.gravity_id);
                });

            migrationBuilder.CreateTable(
                name: "Humidities",
                columns: table => new
                {
                    humidity_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    humidity_humidity = table.Column<float>(type: "real", nullable: false),
                    humidity_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Humidities", x => x.humidity_id);
                });

            migrationBuilder.CreateTable(
                name: "MagneticFields",
                columns: table => new
                {
                    magneticField_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    magneticField_x = table.Column<float>(type: "real", nullable: false),
                    magneticField_y = table.Column<float>(type: "real", nullable: false),
                    magneticField_z = table.Column<float>(type: "real", nullable: false),
                    magneticField_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MagneticFields", x => x.magneticField_id);
                });

            migrationBuilder.CreateTable(
                name: "Orientations",
                columns: table => new
                {
                    orientation_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    orientation_x = table.Column<float>(type: "real", nullable: false),
                    orientation_y = table.Column<float>(type: "real", nullable: false),
                    orientation_z = table.Column<float>(type: "real", nullable: false),
                    orientation_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orientations", x => x.orientation_id);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    position_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    position_longitude = table.Column<float>(type: "real", nullable: false),
                    position_latitude = table.Column<float>(type: "real", nullable: false),
                    position_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.position_id);
                });

            migrationBuilder.CreateTable(
                name: "Pressures",
                columns: table => new
                {
                    pressure_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    pressure_pressure = table.Column<float>(type: "real", nullable: false),
                    pressure_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pressures", x => x.pressure_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accelerations");

            migrationBuilder.DropTable(
                name: "Altitudes");

            migrationBuilder.DropTable(
                name: "AngularVelocities");

            migrationBuilder.DropTable(
                name: "Gravities");

            migrationBuilder.DropTable(
                name: "Humidities");

            migrationBuilder.DropTable(
                name: "MagneticFields");

            migrationBuilder.DropTable(
                name: "Orientations");

            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropTable(
                name: "Pressures");
        }
    }
}
