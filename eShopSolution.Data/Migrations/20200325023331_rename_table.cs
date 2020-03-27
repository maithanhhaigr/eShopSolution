using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class rename_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_IdentityUserTokens",
                table: "IdentityUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IdentityUserRoles",
                table: "IdentityUserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IdentityUserLogins",
                table: "IdentityUserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IdentityUserClaims",
                table: "IdentityUserClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IdentityRoleClaims",
                table: "IdentityRoleClaims");

            migrationBuilder.RenameTable(
                name: "IdentityUserTokens",
                newName: "AppUserTokens");

            migrationBuilder.RenameTable(
                name: "IdentityUserRoles",
                newName: "AppUserRoles");

            migrationBuilder.RenameTable(
                name: "IdentityUserLogins",
                newName: "AppUserLogins");

            migrationBuilder.RenameTable(
                name: "IdentityUserClaims",
                newName: "AppUserClaims");

            migrationBuilder.RenameTable(
                name: "IdentityRoleClaims",
                newName: "AppRoleClaims");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppUserTokens",
                table: "AppUserTokens",
                column: "UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppUserRoles",
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppUserLogins",
                table: "AppUserLogins",
                column: "UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppUserClaims",
                table: "AppUserClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppRoleClaims",
                table: "AppRoleClaims",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "a5b5d566-650e-40d3-ba62-e70bd4ddb8f7");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash" },
                values: new object[] { "1ee26f92-4a96-4105-94aa-ca69d45f22bc", "tedu.international@gmail.com", "AQAAAAEAACcQAAAAEBcUfG1i8GHVT8VzJcChNiHNMjG8AhUyrH72hchLMwyqG4Sy4+A3ecdDISlZkF/mvw==" });

            migrationBuilder.UpdateData(
                table: "Categoties",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categoties",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2020, 3, 25, 9, 33, 31, 116, DateTimeKind.Local).AddTicks(9223));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2020, 3, 25, 9, 33, 31, 117, DateTimeKind.Local).AddTicks(3815));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AppUserTokens",
                table: "AppUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppUserRoles",
                table: "AppUserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppUserLogins",
                table: "AppUserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppUserClaims",
                table: "AppUserClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppRoleClaims",
                table: "AppRoleClaims");

            migrationBuilder.RenameTable(
                name: "AppUserTokens",
                newName: "IdentityUserTokens");

            migrationBuilder.RenameTable(
                name: "AppUserRoles",
                newName: "IdentityUserRoles");

            migrationBuilder.RenameTable(
                name: "AppUserLogins",
                newName: "IdentityUserLogins");

            migrationBuilder.RenameTable(
                name: "AppUserClaims",
                newName: "IdentityUserClaims");

            migrationBuilder.RenameTable(
                name: "AppRoleClaims",
                newName: "IdentityRoleClaims");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IdentityUserTokens",
                table: "IdentityUserTokens",
                column: "UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IdentityUserRoles",
                table: "IdentityUserRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_IdentityUserLogins",
                table: "IdentityUserLogins",
                column: "UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IdentityUserClaims",
                table: "IdentityUserClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IdentityRoleClaims",
                table: "IdentityRoleClaims",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "f8eb4e7d-62a1-4fe3-96e9-9e3a8ff5c6d3");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash" },
                values: new object[] { "0cd1251b-003b-4dd3-974f-f696e4fe9b04", null, "AQAAAAEAACcQAAAAECi5dzIMQX0XA6GLhPAhQl7MmGurXU+m09rgqSZ8r262GJZz4rKDVPM3dKh0g92BpQ==" });

            migrationBuilder.UpdateData(
                table: "Categoties",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categoties",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreate",
                value: new DateTime(2020, 3, 22, 0, 46, 4, 670, DateTimeKind.Local).AddTicks(4799));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreate",
                value: new DateTime(2020, 3, 22, 0, 46, 4, 670, DateTimeKind.Local).AddTicks(9277));
        }
    }
}
