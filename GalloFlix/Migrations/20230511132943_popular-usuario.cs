using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GalloFlix.Migrations
{
    public partial class popularusuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "36b7cfd6-fb5d-4939-918c-39a58cdc2835", "4307a9f5-3c80-44dc-ba54-46df24b15463", "Moderador", "MODERADOR" },
                    { "aacfa692-8a8e-4fe4-88cf-74119cfa3ac0", "5037aeb1-e40d-41a7-9d35-6bb93975f371", "Administrador", "ADMINISTRADOR" },
                    { "bb2ae0cb-3ae5-44da-b369-211003677f9d", "7cf2df97-16bf-40b1-b8e9-6bdd255250a3", "Usuário", "USUÁRIO" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e5fa17de-840a-4730-8081-bef2436f721b", 0, "57add409-d9fd-4cb1-90b7-e4daf43acd65", new DateTime(1981, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "AppUser", "gallojunior@gmail.com", true, false, null, "José Antonio Gallo Junior", "GALLOJUNIOR@GMAIL.COM", "GALLOJUNIOR", "AQAAAAEAACcQAAAAEJMm4cnyptE/9MS9UadZGB3qvb+JxSCkSW15JRu0OeulVk8PDyINuaE1gy5TcHrZ2A==", "1440028922", true, "img/users/avatar.png", "67acad9a-c0a8-43d4-97fb-88278e932350", false, "GalloJunior" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "aacfa692-8a8e-4fe4-88cf-74119cfa3ac0", "e5fa17de-840a-4730-8081-bef2436f721b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "36b7cfd6-fb5d-4939-918c-39a58cdc2835");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "bb2ae0cb-3ae5-44da-b369-211003677f9d");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "aacfa692-8a8e-4fe4-88cf-74119cfa3ac0", "e5fa17de-840a-4730-8081-bef2436f721b" });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "aacfa692-8a8e-4fe4-88cf-74119cfa3ac0");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "e5fa17de-840a-4730-8081-bef2436f721b");
        }
    }
}
