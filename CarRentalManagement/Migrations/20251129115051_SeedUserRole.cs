using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "4d03709e-8c3b-4d34-8ffa-d206225321b6", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEOBTskCcP8G/nDMSNOO5xpKEJSInYasfD0g2gI2C4IiPl1808CQDdaqJftB2F+vDJw==", null, false, "f98e885c-6051-4638-8217-32084ab23892", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 29, 19, 50, 49, 715, DateTimeKind.Local).AddTicks(5662), new DateTime(2025, 11, 29, 19, 50, 49, 715, DateTimeKind.Local).AddTicks(5699) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 29, 19, 50, 49, 715, DateTimeKind.Local).AddTicks(5707), new DateTime(2025, 11, 29, 19, 50, 49, 715, DateTimeKind.Local).AddTicks(5709) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 29, 19, 50, 49, 715, DateTimeKind.Local).AddTicks(6876), new DateTime(2025, 11, 29, 19, 50, 49, 715, DateTimeKind.Local).AddTicks(6883) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 29, 19, 50, 49, 715, DateTimeKind.Local).AddTicks(6888), new DateTime(2025, 11, 29, 19, 50, 49, 715, DateTimeKind.Local).AddTicks(6890) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 29, 19, 50, 49, 715, DateTimeKind.Local).AddTicks(7361), new DateTime(2025, 11, 29, 19, 50, 49, 715, DateTimeKind.Local).AddTicks(7366) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 29, 19, 50, 49, 715, DateTimeKind.Local).AddTicks(7370), new DateTime(2025, 11, 29, 19, 50, 49, 715, DateTimeKind.Local).AddTicks(7372) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 29, 19, 50, 49, 715, DateTimeKind.Local).AddTicks(7377), new DateTime(2025, 11, 29, 19, 50, 49, 715, DateTimeKind.Local).AddTicks(7379) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 29, 19, 50, 49, 715, DateTimeKind.Local).AddTicks(7382), new DateTime(2025, 11, 29, 19, 50, 49, 715, DateTimeKind.Local).AddTicks(7384) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 29, 19, 44, 9, 270, DateTimeKind.Local).AddTicks(5115), new DateTime(2025, 11, 29, 19, 44, 9, 270, DateTimeKind.Local).AddTicks(5129) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 29, 19, 44, 9, 270, DateTimeKind.Local).AddTicks(5131), new DateTime(2025, 11, 29, 19, 44, 9, 270, DateTimeKind.Local).AddTicks(5132) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 29, 19, 44, 9, 270, DateTimeKind.Local).AddTicks(5624), new DateTime(2025, 11, 29, 19, 44, 9, 270, DateTimeKind.Local).AddTicks(5628) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 29, 19, 44, 9, 270, DateTimeKind.Local).AddTicks(5629), new DateTime(2025, 11, 29, 19, 44, 9, 270, DateTimeKind.Local).AddTicks(5630) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 29, 19, 44, 9, 270, DateTimeKind.Local).AddTicks(5770), new DateTime(2025, 11, 29, 19, 44, 9, 270, DateTimeKind.Local).AddTicks(5772) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 29, 19, 44, 9, 270, DateTimeKind.Local).AddTicks(5773), new DateTime(2025, 11, 29, 19, 44, 9, 270, DateTimeKind.Local).AddTicks(5774) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 29, 19, 44, 9, 270, DateTimeKind.Local).AddTicks(5775), new DateTime(2025, 11, 29, 19, 44, 9, 270, DateTimeKind.Local).AddTicks(5776) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 29, 19, 44, 9, 270, DateTimeKind.Local).AddTicks(5777), new DateTime(2025, 11, 29, 19, 44, 9, 270, DateTimeKind.Local).AddTicks(5778) });
        }
    }
}
