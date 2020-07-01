using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TransportOrdering.Data.Migrations
{
    public partial class TransportOrderingDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(fixedLength: true, maxLength: 50, nullable: false),
                    Password = table.Column<string>(fixedLength: true, maxLength: 50, nullable: false),
                    IsActive = table.Column<bool>(fixedLength: true, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VehicleType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(fixedLength: true, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime", unicode: false, maxLength: 50, nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime", unicode: false, maxLength: 50, nullable: false),
                    VehicleTypeId = table.Column<int>(unicode: false, nullable: false),
                    VehicleCapacity = table.Column<string>(fixedLength: true, maxLength: 50, nullable: false),
                    StartAddress = table.Column<string>(fixedLength: true, nullable: false),
                    EndAddress = table.Column<string>(fixedLength: true, nullable: false),
                    FullName = table.Column<string>(fixedLength: true, maxLength: 50, nullable: false),
                    Email = table.Column<string>(fixedLength: true, maxLength: 50, nullable: false),
                    MobileNumber = table.Column<string>(fixedLength: true, maxLength: 50, nullable: false),
                    ReferenceNumber = table.Column<string>(fixedLength: true, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_VehicleTypes",
                        column: x => x.VehicleTypeId,
                        principalTable: "VehicleType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Order_VehicleTypeId",
                table: "Order",
                column: "VehicleTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "VehicleType");
        }
    }
}
