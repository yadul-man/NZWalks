using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NZWalks.API.Migrations
{
    /// <inheritdoc />
    public partial class SeedModifiedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("75f98dac-8892-4586-a7da-78a545d1c40b"));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("1b27e9b2-5c2b-49db-9b12-5a36dbd2b789"),
                columns: new[] { "Name", "RegionImageUrl" },
                values: new object[] { "Invercargill City", "https://test.com/images/invercargill.jpg" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("31c1a2d2-21bc-4b4d-b71b-41f30353aecd"),
                columns: new[] { "Name", "RegionImageUrl" },
                values: new object[] { "New Plymouth City", "https://test.com/images/newplymouth.jpg" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("5a8ef127-82b4-4721-8d65-6f769eef2b56"),
                columns: new[] { "Name", "RegionImageUrl" },
                values: new object[] { "Dunedin City", "https://test.com/images/dunedin.jpg" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("8d5e786b-cc43-4b6f-9a6f-c49a4fdfd223"),
                columns: new[] { "Name", "RegionImageUrl" },
                values: new object[] { "Palmerston North City", "https://test.com/images/palmerstonnorth.jpg" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("93f7a19c-2e65-4db8-8c6e-0dd25c7bf93d"),
                columns: new[] { "Name", "RegionImageUrl" },
                values: new object[] { "Napier-Hastings", "https://test.com/images/napier.jpg" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("9a5b58c1-d91a-47e3-8101-c03c2f839adf"),
                columns: new[] { "Name", "RegionImageUrl" },
                values: new object[] { "Christchurch City", "https://test.com/images/christchurch.jpg" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("a4e65b12-c0c3-4bb4-bb4d-1fd61ef6358f"),
                columns: new[] { "Name", "RegionImageUrl" },
                values: new object[] { "Hamilton City", "https://test.com/images/hamilton.jpg" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("b27e9b54-6893-4f5d-83e8-4ad6b4cfae7c"),
                columns: new[] { "Name", "RegionImageUrl" },
                values: new object[] { "Nelson City", "https://test.com/images/nelson.jpg" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("c0f1f364-65d6-4f87-96a4-0a2a9783b6c4"),
                columns: new[] { "Name", "RegionImageUrl" },
                values: new object[] { "Whangarei City", "https://test.com/images/whangarei.jpg" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("cfb8f37c-4a45-4cbf-a8ba-11fefdfdfedd"),
                columns: new[] { "Name", "RegionImageUrl" },
                values: new object[] { "Rotorua Lakes", "https://test.com/images/rotorua.jpg" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("d4f7db27-8d6e-4502-912f-f9a61b5d5894"),
                columns: new[] { "Name", "RegionImageUrl" },
                values: new object[] { "Gisborne City", "https://test.com/images/gisborne.jpg" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("dd6f96c3-fbc6-4b43-b89b-8f626d0e18f6"),
                columns: new[] { "Name", "RegionImageUrl" },
                values: new object[] { "Queenstown Town", "https://test.com/images/queenstown.jpg" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("e6c4e032-6a19-432b-9466-cc342a7558de"),
                columns: new[] { "Name", "RegionImageUrl" },
                values: new object[] { "Tauranga Bay", "https://test.com/images/tauranga.jpg" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("f7bfb5cf-7919-4c90-9b4d-91de354b4c11"),
                columns: new[] { "Name", "RegionImageUrl" },
                values: new object[] { "Auckland City", "https://test.com/images/auckland.jpg" });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Code", "Name", "RegionImageUrl" },
                values: new object[] { new Guid("75f98dfc-8892-4586-a7da-78a545d1c40b"), "WGN", "Wellington City", "https://test.com/images/wellington.jpg" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("75f98dfc-8892-4586-a7da-78a545d1c40b"));

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("1b27e9b2-5c2b-49db-9b12-5a36dbd2b789"),
                columns: new[] { "Name", "RegionImageUrl" },
                values: new object[] { "Invercargill", "https://test.com/invercargill.jpg" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("31c1a2d2-21bc-4b4d-b71b-41f30353aecd"),
                columns: new[] { "Name", "RegionImageUrl" },
                values: new object[] { "New Plymouth", "https://test.com/newplymouth.jpg" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("5a8ef127-82b4-4721-8d65-6f769eef2b56"),
                columns: new[] { "Name", "RegionImageUrl" },
                values: new object[] { "Dunedin", "https://test.com/dunedin.jpg" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("8d5e786b-cc43-4b6f-9a6f-c49a4fdfd223"),
                columns: new[] { "Name", "RegionImageUrl" },
                values: new object[] { "Palmerston North", "https://test.com/palmerstonnorth.jpg" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("93f7a19c-2e65-4db8-8c6e-0dd25c7bf93d"),
                columns: new[] { "Name", "RegionImageUrl" },
                values: new object[] { "Napier", "https://test.com/napier.jpg" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("9a5b58c1-d91a-47e3-8101-c03c2f839adf"),
                columns: new[] { "Name", "RegionImageUrl" },
                values: new object[] { "Christchurch", "https://test.com/christchurch.jpg" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("a4e65b12-c0c3-4bb4-bb4d-1fd61ef6358f"),
                columns: new[] { "Name", "RegionImageUrl" },
                values: new object[] { "Hamilton", "https://test.com/hamilton.jpg" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("b27e9b54-6893-4f5d-83e8-4ad6b4cfae7c"),
                columns: new[] { "Name", "RegionImageUrl" },
                values: new object[] { "Nelson", "https://test.com/nelson.jpg" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("c0f1f364-65d6-4f87-96a4-0a2a9783b6c4"),
                columns: new[] { "Name", "RegionImageUrl" },
                values: new object[] { "Whangarei", "https://test.com/whangarei.jpg" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("cfb8f37c-4a45-4cbf-a8ba-11fefdfdfedd"),
                columns: new[] { "Name", "RegionImageUrl" },
                values: new object[] { "Rotorua", "https://test.com/rotorua.jpg" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("d4f7db27-8d6e-4502-912f-f9a61b5d5894"),
                columns: new[] { "Name", "RegionImageUrl" },
                values: new object[] { "Gisborne", "https://test.com/gisborne.jpg" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("dd6f96c3-fbc6-4b43-b89b-8f626d0e18f6"),
                columns: new[] { "Name", "RegionImageUrl" },
                values: new object[] { "Queenstown", "https://test.com/queenstown.jpg" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("e6c4e032-6a19-432b-9466-cc342a7558de"),
                columns: new[] { "Name", "RegionImageUrl" },
                values: new object[] { "Tauranga", "https://test.com/tauranga.jpg" });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("f7bfb5cf-7919-4c90-9b4d-91de354b4c11"),
                columns: new[] { "Name", "RegionImageUrl" },
                values: new object[] { "Auckland", "https://test.com/auckland.jpg" });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Code", "Name", "RegionImageUrl" },
                values: new object[] { new Guid("75f98dac-8892-4586-a7da-78a545d1c40b"), "WGN", "Wellington", "https://test.com/wellington.jpg" });
        }
    }
}
