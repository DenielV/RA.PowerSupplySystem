using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RA.PowerSupplySystem.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddedOrderStatusesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OrderStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderStatuses", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "MaterialEntries",
                keyColumn: "Id",
                keyValue: 1,
                column: "EntryDate",
                value: new DateTime(2023, 9, 24, 17, 42, 9, 745, DateTimeKind.Local).AddTicks(3739));

            migrationBuilder.UpdateData(
                table: "MaterialEntries",
                keyColumn: "Id",
                keyValue: 2,
                column: "EntryDate",
                value: new DateTime(2023, 9, 24, 17, 42, 9, 745, DateTimeKind.Local).AddTicks(3792));

            migrationBuilder.UpdateData(
                table: "MaterialEntries",
                keyColumn: "Id",
                keyValue: 3,
                column: "EntryDate",
                value: new DateTime(2023, 9, 24, 17, 42, 9, 745, DateTimeKind.Local).AddTicks(3795));

            migrationBuilder.UpdateData(
                table: "MaterialEntries",
                keyColumn: "Id",
                keyValue: 4,
                column: "EntryDate",
                value: new DateTime(2023, 9, 24, 17, 42, 9, 745, DateTimeKind.Local).AddTicks(3797));

            migrationBuilder.InsertData(
                table: "OrderStatuses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Pendiente" },
                    { 2, "En almacén" },
                    { 3, "Enviado" },
                    { 4, "Entregado" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderStatuses");

            migrationBuilder.UpdateData(
                table: "MaterialEntries",
                keyColumn: "Id",
                keyValue: 1,
                column: "EntryDate",
                value: new DateTime(2023, 9, 24, 17, 41, 3, 793, DateTimeKind.Local).AddTicks(1724));

            migrationBuilder.UpdateData(
                table: "MaterialEntries",
                keyColumn: "Id",
                keyValue: 2,
                column: "EntryDate",
                value: new DateTime(2023, 9, 24, 17, 41, 3, 793, DateTimeKind.Local).AddTicks(1774));

            migrationBuilder.UpdateData(
                table: "MaterialEntries",
                keyColumn: "Id",
                keyValue: 3,
                column: "EntryDate",
                value: new DateTime(2023, 9, 24, 17, 41, 3, 793, DateTimeKind.Local).AddTicks(1777));

            migrationBuilder.UpdateData(
                table: "MaterialEntries",
                keyColumn: "Id",
                keyValue: 4,
                column: "EntryDate",
                value: new DateTime(2023, 9, 24, 17, 41, 3, 793, DateTimeKind.Local).AddTicks(1779));
        }
    }
}
