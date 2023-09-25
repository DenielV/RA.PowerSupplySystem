using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RA.PowerSupplySystem.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddedPreviousStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PreviousStatusId",
                table: "OrderStatuses",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "MaterialEntries",
                keyColumn: "Id",
                keyValue: 1,
                column: "EntryDate",
                value: new DateTime(2023, 9, 24, 17, 47, 47, 154, DateTimeKind.Local).AddTicks(7638));

            migrationBuilder.UpdateData(
                table: "MaterialEntries",
                keyColumn: "Id",
                keyValue: 2,
                column: "EntryDate",
                value: new DateTime(2023, 9, 24, 17, 47, 47, 154, DateTimeKind.Local).AddTicks(7689));

            migrationBuilder.UpdateData(
                table: "MaterialEntries",
                keyColumn: "Id",
                keyValue: 3,
                column: "EntryDate",
                value: new DateTime(2023, 9, 24, 17, 47, 47, 154, DateTimeKind.Local).AddTicks(7692));

            migrationBuilder.UpdateData(
                table: "MaterialEntries",
                keyColumn: "Id",
                keyValue: 4,
                column: "EntryDate",
                value: new DateTime(2023, 9, 24, 17, 47, 47, 154, DateTimeKind.Local).AddTicks(7694));

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "PreviousStatusId",
                value: null);

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 2,
                column: "PreviousStatusId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 3,
                column: "PreviousStatusId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 4,
                column: "PreviousStatusId",
                value: 3);

            migrationBuilder.CreateIndex(
                name: "IX_OrderStatuses_PreviousStatusId",
                table: "OrderStatuses",
                column: "PreviousStatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderStatuses_OrderStatuses_PreviousStatusId",
                table: "OrderStatuses",
                column: "PreviousStatusId",
                principalTable: "OrderStatuses",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderStatuses_OrderStatuses_PreviousStatusId",
                table: "OrderStatuses");

            migrationBuilder.DropIndex(
                name: "IX_OrderStatuses_PreviousStatusId",
                table: "OrderStatuses");

            migrationBuilder.DropColumn(
                name: "PreviousStatusId",
                table: "OrderStatuses");

            migrationBuilder.UpdateData(
                table: "MaterialEntries",
                keyColumn: "Id",
                keyValue: 1,
                column: "EntryDate",
                value: new DateTime(2023, 9, 24, 17, 42, 53, 895, DateTimeKind.Local).AddTicks(8220));

            migrationBuilder.UpdateData(
                table: "MaterialEntries",
                keyColumn: "Id",
                keyValue: 2,
                column: "EntryDate",
                value: new DateTime(2023, 9, 24, 17, 42, 53, 895, DateTimeKind.Local).AddTicks(8272));

            migrationBuilder.UpdateData(
                table: "MaterialEntries",
                keyColumn: "Id",
                keyValue: 3,
                column: "EntryDate",
                value: new DateTime(2023, 9, 24, 17, 42, 53, 895, DateTimeKind.Local).AddTicks(8275));

            migrationBuilder.UpdateData(
                table: "MaterialEntries",
                keyColumn: "Id",
                keyValue: 4,
                column: "EntryDate",
                value: new DateTime(2023, 9, 24, 17, 42, 53, 895, DateTimeKind.Local).AddTicks(8277));
        }
    }
}
