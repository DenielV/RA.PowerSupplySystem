using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RA.PowerSupplySystem.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class RemovedOrderStatusess : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MaterialEntries",
                keyColumn: "Id",
                keyValue: 1,
                column: "EntryDate",
                value: new DateTime(2023, 9, 24, 17, 40, 17, 616, DateTimeKind.Local).AddTicks(8697));

            migrationBuilder.UpdateData(
                table: "MaterialEntries",
                keyColumn: "Id",
                keyValue: 2,
                column: "EntryDate",
                value: new DateTime(2023, 9, 24, 17, 40, 17, 616, DateTimeKind.Local).AddTicks(8747));

            migrationBuilder.UpdateData(
                table: "MaterialEntries",
                keyColumn: "Id",
                keyValue: 3,
                column: "EntryDate",
                value: new DateTime(2023, 9, 24, 17, 40, 17, 616, DateTimeKind.Local).AddTicks(8750));

            migrationBuilder.UpdateData(
                table: "MaterialEntries",
                keyColumn: "Id",
                keyValue: 4,
                column: "EntryDate",
                value: new DateTime(2023, 9, 24, 17, 40, 17, 616, DateTimeKind.Local).AddTicks(8752));
        }
    }
}
