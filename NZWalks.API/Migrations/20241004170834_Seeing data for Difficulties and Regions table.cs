using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NZWalks.API.Migrations
{
    /// <inheritdoc />
    public partial class SeeingdataforDifficultiesandRegionstable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Difficulties",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1fe4ea12-a184-45de-9db5-dc93b19fb886"), "Easy" },
                    { new Guid("290aa1b6-4d23-44cd-94a7-0a5c5d18dbbb"), "Hard" },
                    { new Guid("f2537da4-04ce-4b4f-805a-24f7862ac43e"), "Medium" }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Code", "Name", "RegionImageUrl" },
                values: new object[,]
                {
                    { new Guid("1b27e9b2-5c2b-49db-9b12-5a36dbd2b789"), "IVC", "Invercargill", "https://test.com/invercargill.jpg" },
                    { new Guid("31c1a2d2-21bc-4b4d-b71b-41f30353aecd"), "NPL", "New Plymouth", "https://test.com/newplymouth.jpg" },
                    { new Guid("5a8ef127-82b4-4721-8d65-6f769eef2b56"), "DUD", "Dunedin", "https://test.com/dunedin.jpg" },
                    { new Guid("75f98dfc-8892-4586-a7da-78a545d1c40b"), "WGN", "Wellington", "https://test.com/wellington.jpg" },
                    { new Guid("8d5e786b-cc43-4b6f-9a6f-c49a4fdfd223"), "PMR", "Palmerston North", "https://test.com/palmerstonnorth.jpg" },
                    { new Guid("93f7a19c-2e65-4db8-8c6e-0dd25c7bf93d"), "NPR", "Napier", "https://test.com/napier.jpg" },
                    { new Guid("9a5b58c1-d91a-47e3-8101-c03c2f839adf"), "CHC", "Christchurch", "https://test.com/christchurch.jpg" },
                    { new Guid("a4e65b12-c0c3-4bb4-bb4d-1fd61ef6358f"), "HAM", "Hamilton", "https://test.com/hamilton.jpg" },
                    { new Guid("b27e9b54-6893-4f5d-83e8-4ad6b4cfae7c"), "NSN", "Nelson", "https://test.com/nelson.jpg" },
                    { new Guid("c0f1f364-65d6-4f87-96a4-0a2a9783b6c4"), "WHG", "Whangarei", "https://test.com/whangarei.jpg" },
                    { new Guid("cfb8f37c-4a45-4cbf-a8ba-11fefdfdfedd"), "RTR", "Rotorua", "https://test.com/rotorua.jpg" },
                    { new Guid("d4f7db27-8d6e-4502-912f-f9a61b5d5894"), "GIS", "Gisborne", "https://test.com/gisborne.jpg" },
                    { new Guid("dd6f96c3-fbc6-4b43-b89b-8f626d0e18f6"), "QTN", "Queenstown", "https://test.com/queenstown.jpg" },
                    { new Guid("e6c4e032-6a19-432b-9466-cc342a7558de"), "TRG", "Tauranga", "https://test.com/tauranga.jpg" },
                    { new Guid("f7bfb5cf-7919-4c90-9b4d-91de354b4c11"), "AKL", "Auckland", "https://test.com/auckland.jpg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("1fe4ea12-a184-45de-9db5-dc93b19fb886"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("290aa1b6-4d23-44cd-94a7-0a5c5d18dbbb"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("f2537da4-04ce-4b4f-805a-24f7862ac43e"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("1b27e9b2-5c2b-49db-9b12-5a36dbd2b789"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("31c1a2d2-21bc-4b4d-b71b-41f30353aecd"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("5a8ef127-82b4-4721-8d65-6f769eef2b56"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("75f98dfc-8892-4586-a7da-78a545d1c40b"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("8d5e786b-cc43-4b6f-9a6f-c49a4fdfd223"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("93f7a19c-2e65-4db8-8c6e-0dd25c7bf93d"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("9a5b58c1-d91a-47e3-8101-c03c2f839adf"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("a4e65b12-c0c3-4bb4-bb4d-1fd61ef6358f"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("b27e9b54-6893-4f5d-83e8-4ad6b4cfae7c"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("c0f1f364-65d6-4f87-96a4-0a2a9783b6c4"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("cfb8f37c-4a45-4cbf-a8ba-11fefdfdfedd"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("d4f7db27-8d6e-4502-912f-f9a61b5d5894"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("dd6f96c3-fbc6-4b43-b89b-8f626d0e18f6"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("e6c4e032-6a19-432b-9466-cc342a7558de"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("f7bfb5cf-7919-4c90-9b4d-91de354b4c11"));
        }
    }
}
