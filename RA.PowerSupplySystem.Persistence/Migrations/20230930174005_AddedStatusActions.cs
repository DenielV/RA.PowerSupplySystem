using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RA.PowerSupplySystem.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddedStatusActions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Action",
                table: "OrderStatuses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ActionGifLink",
                table: "OrderStatuses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NextStatusId",
                table: "OrderStatuses",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "MaterialEntries",
                keyColumn: "Id",
                keyValue: 1,
                column: "EntryDate",
                value: new DateTime(2023, 9, 30, 10, 40, 5, 237, DateTimeKind.Local).AddTicks(9935));

            migrationBuilder.UpdateData(
                table: "MaterialEntries",
                keyColumn: "Id",
                keyValue: 2,
                column: "EntryDate",
                value: new DateTime(2023, 9, 30, 10, 40, 5, 237, DateTimeKind.Local).AddTicks(9989));

            migrationBuilder.UpdateData(
                table: "MaterialEntries",
                keyColumn: "Id",
                keyValue: 3,
                column: "EntryDate",
                value: new DateTime(2023, 9, 30, 10, 40, 5, 237, DateTimeKind.Local).AddTicks(9991));

            migrationBuilder.UpdateData(
                table: "MaterialEntries",
                keyColumn: "Id",
                keyValue: 4,
                column: "EntryDate",
                value: new DateTime(2023, 9, 30, 10, 40, 5, 237, DateTimeKind.Local).AddTicks(9994));

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Action", "ActionGifLink", "Name", "NextStatusId" },
                values: new object[] { "Producir", "https://i.makeagif.com/media/12-04-2020/UrVrI_.gif", "En producción", 2 });

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Action", "ActionGifLink", "Name", "NextStatusId" },
                values: new object[] { null, null, "En pruebas", 3 });

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Action", "ActionGifLink", "Name", "NextStatusId" },
                values: new object[] { "Enviar", "https://media2.giphy.com/media/TIeTxUeyPeFI771jTF/giphy.gif?cid=ecf05e47nif00spqsshis5n7nfiy6t0cgyjkhn13nvdt2n33&ep=v1_gifs_search&rid=giphy.gif&ct=g", "En almacén", 4 });

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Action", "ActionGifLink", "Name", "NextStatusId" },
                values: new object[] { "Entregar", "https://cdn.dribbble.com/users/5173832/screenshots/19756669/media/63c78c15a14a043b8a9ff2c8981e4fde.gif", "En camino", 5 });

            migrationBuilder.InsertData(
                table: "OrderStatuses",
                columns: new[] { "Id", "Action", "ActionGifLink", "Name", "NextStatusId", "PreviousStatusId" },
                values: new object[] { 5, null, null, "Entregado", null, 4 });

            migrationBuilder.CreateIndex(
                name: "IX_OrderStatuses_NextStatusId",
                table: "OrderStatuses",
                column: "NextStatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderStatuses_OrderStatuses_NextStatusId",
                table: "OrderStatuses",
                column: "NextStatusId",
                principalTable: "OrderStatuses",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderStatuses_OrderStatuses_NextStatusId",
                table: "OrderStatuses");

            migrationBuilder.DropIndex(
                name: "IX_OrderStatuses_NextStatusId",
                table: "OrderStatuses");

            migrationBuilder.DeleteData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "Action",
                table: "OrderStatuses");

            migrationBuilder.DropColumn(
                name: "ActionGifLink",
                table: "OrderStatuses");

            migrationBuilder.DropColumn(
                name: "NextStatusId",
                table: "OrderStatuses");

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
                column: "Name",
                value: "Pendiente");

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "En almacén");

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Enviado");

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Entregado");
        }
    }
}
