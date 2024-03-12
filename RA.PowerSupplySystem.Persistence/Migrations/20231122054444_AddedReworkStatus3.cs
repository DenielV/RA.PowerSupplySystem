using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RA.PowerSupplySystem.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddedReworkStatus3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MaterialEntries",
                keyColumn: "Id",
                keyValue: 1,
                column: "EntryDate",
                value: new DateTime(2023, 11, 21, 22, 44, 44, 844, DateTimeKind.Local).AddTicks(3952));

            migrationBuilder.UpdateData(
                table: "MaterialEntries",
                keyColumn: "Id",
                keyValue: 2,
                column: "EntryDate",
                value: new DateTime(2023, 11, 21, 22, 44, 44, 844, DateTimeKind.Local).AddTicks(3968));

            migrationBuilder.UpdateData(
                table: "MaterialEntries",
                keyColumn: "Id",
                keyValue: 3,
                column: "EntryDate",
                value: new DateTime(2023, 11, 21, 22, 44, 44, 844, DateTimeKind.Local).AddTicks(3969));

            migrationBuilder.UpdateData(
                table: "MaterialEntries",
                keyColumn: "Id",
                keyValue: 4,
                column: "EntryDate",
                value: new DateTime(2023, 11, 21, 22, 44, 44, 844, DateTimeKind.Local).AddTicks(3970));

            migrationBuilder.InsertData(
                table: "OrderStatuses",
                columns: new[] { "Id", "Action", "ActionGifLink", "Name", "NextStatusId", "PreviousStatusId" },
                values: new object[] { 6, "Retrabajar", "https://i.makeagif.com/media/12-04-2020/UrVrI_.gif", "En retrabajo", 2, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
