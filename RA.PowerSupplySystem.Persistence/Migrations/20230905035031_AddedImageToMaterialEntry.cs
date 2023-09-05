using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RA.PowerSupplySystem.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddedImageToMaterialEntry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "ImageData",
                table: "MaterialEntries",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "MaterialEntries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EntryDate", "ImageData" },
                values: new object[] { new DateTime(2023, 9, 4, 20, 50, 31, 166, DateTimeKind.Local).AddTicks(5055), null });

            migrationBuilder.UpdateData(
                table: "MaterialEntries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EntryDate", "ImageData" },
                values: new object[] { new DateTime(2023, 9, 4, 20, 50, 31, 166, DateTimeKind.Local).AddTicks(5104), null });

            migrationBuilder.UpdateData(
                table: "MaterialEntries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EntryDate", "ImageData" },
                values: new object[] { new DateTime(2023, 9, 4, 20, 50, 31, 166, DateTimeKind.Local).AddTicks(5107), null });

            migrationBuilder.UpdateData(
                table: "MaterialEntries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EntryDate", "ImageData" },
                values: new object[] { new DateTime(2023, 9, 4, 20, 50, 31, 166, DateTimeKind.Local).AddTicks(5109), null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageData",
                table: "MaterialEntries");

            migrationBuilder.UpdateData(
                table: "MaterialEntries",
                keyColumn: "Id",
                keyValue: 1,
                column: "EntryDate",
                value: new DateTime(2023, 8, 27, 16, 49, 30, 541, DateTimeKind.Local).AddTicks(9813));

            migrationBuilder.UpdateData(
                table: "MaterialEntries",
                keyColumn: "Id",
                keyValue: 2,
                column: "EntryDate",
                value: new DateTime(2023, 8, 27, 16, 49, 30, 541, DateTimeKind.Local).AddTicks(9861));

            migrationBuilder.UpdateData(
                table: "MaterialEntries",
                keyColumn: "Id",
                keyValue: 3,
                column: "EntryDate",
                value: new DateTime(2023, 8, 27, 16, 49, 30, 541, DateTimeKind.Local).AddTicks(9864));

            migrationBuilder.UpdateData(
                table: "MaterialEntries",
                keyColumn: "Id",
                keyValue: 4,
                column: "EntryDate",
                value: new DateTime(2023, 8, 27, 16, 49, 30, 541, DateTimeKind.Local).AddTicks(9865));
        }
    }
}
