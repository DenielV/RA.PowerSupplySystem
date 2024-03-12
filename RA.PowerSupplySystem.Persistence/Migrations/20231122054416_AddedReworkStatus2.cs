using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RA.PowerSupplySystem.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddedReworkStatus2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "MaterialEntries",
                keyColumn: "Id",
                keyValue: 1,
                column: "EntryDate",
                value: new DateTime(2023, 11, 21, 22, 44, 16, 625, DateTimeKind.Local).AddTicks(8588));

            migrationBuilder.UpdateData(
                table: "MaterialEntries",
                keyColumn: "Id",
                keyValue: 2,
                column: "EntryDate",
                value: new DateTime(2023, 11, 21, 22, 44, 16, 625, DateTimeKind.Local).AddTicks(8607));

            migrationBuilder.UpdateData(
                table: "MaterialEntries",
                keyColumn: "Id",
                keyValue: 3,
                column: "EntryDate",
                value: new DateTime(2023, 11, 21, 22, 44, 16, 625, DateTimeKind.Local).AddTicks(8608));

            migrationBuilder.UpdateData(
                table: "MaterialEntries",
                keyColumn: "Id",
                keyValue: 4,
                column: "EntryDate",
                value: new DateTime(2023, 11, 21, 22, 44, 16, 625, DateTimeKind.Local).AddTicks(8610));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MaterialEntries",
                keyColumn: "Id",
                keyValue: 1,
                column: "EntryDate",
                value: new DateTime(2023, 11, 21, 22, 40, 35, 385, DateTimeKind.Local).AddTicks(4689));

            migrationBuilder.UpdateData(
                table: "MaterialEntries",
                keyColumn: "Id",
                keyValue: 2,
                column: "EntryDate",
                value: new DateTime(2023, 11, 21, 22, 40, 35, 385, DateTimeKind.Local).AddTicks(4704));

            migrationBuilder.UpdateData(
                table: "MaterialEntries",
                keyColumn: "Id",
                keyValue: 3,
                column: "EntryDate",
                value: new DateTime(2023, 11, 21, 22, 40, 35, 385, DateTimeKind.Local).AddTicks(4706));

            migrationBuilder.UpdateData(
                table: "MaterialEntries",
                keyColumn: "Id",
                keyValue: 4,
                column: "EntryDate",
                value: new DateTime(2023, 11, 21, 22, 40, 35, 385, DateTimeKind.Local).AddTicks(4707));

            migrationBuilder.InsertData(
                table: "OrderStatuses",
                columns: new[] { "Id", "Action", "ActionGifLink", "Name", "NextStatusId", "PreviousStatusId" },
                values: new object[] { 6, "Retrabajar", "https://i.makeagif.com/media/12-04-2020/UrVrI_.gif", "En retrabajo", 2, null });
        }
    }
}
