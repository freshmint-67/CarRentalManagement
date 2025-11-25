using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 25, 16, 12, 1, 29, DateTimeKind.Local).AddTicks(4404), new DateTime(2025, 11, 25, 16, 12, 1, 29, DateTimeKind.Local).AddTicks(4438) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 25, 16, 12, 1, 29, DateTimeKind.Local).AddTicks(4445), new DateTime(2025, 11, 25, 16, 12, 1, 29, DateTimeKind.Local).AddTicks(4447) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 25, 16, 12, 1, 29, DateTimeKind.Local).AddTicks(4986), new DateTime(2025, 11, 25, 16, 12, 1, 29, DateTimeKind.Local).AddTicks(4988) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 25, 16, 12, 1, 29, DateTimeKind.Local).AddTicks(4994), new DateTime(2025, 11, 25, 16, 12, 1, 29, DateTimeKind.Local).AddTicks(4995) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 25, 16, 12, 1, 29, DateTimeKind.Local).AddTicks(5197), new DateTime(2025, 11, 25, 16, 12, 1, 29, DateTimeKind.Local).AddTicks(5199) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 25, 16, 12, 1, 29, DateTimeKind.Local).AddTicks(5205), new DateTime(2025, 11, 25, 16, 12, 1, 29, DateTimeKind.Local).AddTicks(5206) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 25, 16, 12, 1, 29, DateTimeKind.Local).AddTicks(5210), new DateTime(2025, 11, 25, 16, 12, 1, 29, DateTimeKind.Local).AddTicks(5212) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 25, 16, 12, 1, 29, DateTimeKind.Local).AddTicks(5216), new DateTime(2025, 11, 25, 16, 12, 1, 29, DateTimeKind.Local).AddTicks(5218) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 25, 16, 3, 36, 721, DateTimeKind.Local).AddTicks(4646), new DateTime(2025, 11, 25, 16, 3, 36, 721, DateTimeKind.Local).AddTicks(4662) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 25, 16, 3, 36, 721, DateTimeKind.Local).AddTicks(4665), new DateTime(2025, 11, 25, 16, 3, 36, 721, DateTimeKind.Local).AddTicks(4666) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 25, 16, 3, 36, 721, DateTimeKind.Local).AddTicks(4912), new DateTime(2025, 11, 25, 16, 3, 36, 721, DateTimeKind.Local).AddTicks(4913) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 25, 16, 3, 36, 721, DateTimeKind.Local).AddTicks(4916), new DateTime(2025, 11, 25, 16, 3, 36, 721, DateTimeKind.Local).AddTicks(4916) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 25, 16, 3, 36, 721, DateTimeKind.Local).AddTicks(5011), new DateTime(2025, 11, 25, 16, 3, 36, 721, DateTimeKind.Local).AddTicks(5011) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 25, 16, 3, 36, 721, DateTimeKind.Local).AddTicks(5014), new DateTime(2025, 11, 25, 16, 3, 36, 721, DateTimeKind.Local).AddTicks(5015) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 25, 16, 3, 36, 721, DateTimeKind.Local).AddTicks(5016), new DateTime(2025, 11, 25, 16, 3, 36, 721, DateTimeKind.Local).AddTicks(5017) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 25, 16, 3, 36, 721, DateTimeKind.Local).AddTicks(5019), new DateTime(2025, 11, 25, 16, 3, 36, 721, DateTimeKind.Local).AddTicks(5020) });
        }
    }
}
