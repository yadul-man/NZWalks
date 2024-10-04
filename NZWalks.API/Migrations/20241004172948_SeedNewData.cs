using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NZWalks.API.Migrations
{
    /// <inheritdoc />
    public partial class SeedNewData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Difficulties",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("a5d22f24-d5c4-4b65-8b8e-16447bfa4381"), "Easy" },
                    { new Guid("b9b1dabc-dcdc-4b06-b594-b0c4301a5e8d"), "Hard" },
                    { new Guid("cc6c55d7-6d9f-40a1-9c9e-8e94e1e5e9bc"), "Medium" }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Code", "Name", "RegionImageUrl" },
                values: new object[,]
                {
                    { new Guid("16cf9c45-1004-4f04-85bb-bd3ff9a317c3"), "TRG", "Tauranga", "https://test.com/images/tauranga.jpg" },
                    { new Guid("58e5d0f1-659f-42b4-8b69-bfdcb4708fa5"), "DUD", "Dunedin", "https://test.com/images/dunedin.jpg" },
                    { new Guid("5ee09c8b-8f41-4c9f-bf99-6cf37426e0aa"), "GIS", "Gisborne", "https://test.com/images/gisborne.jpg" },
                    { new Guid("6c0fda6e-555e-4c2d-9d34-412342b74bc2"), "QTN", "Queenstown", "https://test.com/images/queenstown.jpg" },
                    { new Guid("8c9a74c6-9c90-4b3a-97d5-88a9d70d22f1"), "CHC", "Christchurch", "https://test.com/images/christchurch.jpg" },
                    { new Guid("a30dbd93-1e53-46b4-9c63-f0eabf9cfed2"), "PMR", "Palmerston North", "https://test.com/images/palmerstonnorth.jpg" },
                    { new Guid("b61bbcb7-5f43-4e38-9050-15f178e8d4a5"), "RTR", "Rotorua", "https://test.com/images/rotorua.jpg" },
                    { new Guid("b69b69c3-8243-4b66-b3c5-4e2dfd0a8cc6"), "IVC", "Invercargill", "https://test.com/images/invercargill.jpg" },
                    { new Guid("c6f1e32c-7a32-4b2e-b7e5-9bcbf7efcb4a"), "HAM", "Hamilton", "https://test.com/images/hamilton.jpg" },
                    { new Guid("d0c7f3d2-0370-479f-9c09-98f4e09a2b62"), "NPL", "New Plymouth", "https://test.com/images/newplymouth.jpg" },
                    { new Guid("d55c0882-2436-4b93-9e48-16f6c8df73bb"), "WHG", "Whangarei", "https://test.com/images/whangarei.jpg" },
                    { new Guid("d7e98812-a5bc-4c97-8d1a-61f8d4a9f6ef"), "WGN", "Wellington", "https://test.com/images/wellington.jpg" },
                    { new Guid("e97a3b1e-fc2a-4739-91a3-6c04f09d26b2"), "AKL", "Auckland", "https://test.com/images/auckland.jpg" },
                    { new Guid("ec0f60a1-63f8-4901-a63c-0075f812dbf3"), "NPR", "Napier-Hastings", "https://test.com/images/napier.jpg" },
                    { new Guid("fe0b0053-5a7d-49a1-8a38-ea37d4b00725"), "NSN", "Nelson", "https://test.com/images/nelson.jpg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("a5d22f24-d5c4-4b65-8b8e-16447bfa4381"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("b9b1dabc-dcdc-4b06-b594-b0c4301a5e8d"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("cc6c55d7-6d9f-40a1-9c9e-8e94e1e5e9bc"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("16cf9c45-1004-4f04-85bb-bd3ff9a317c3"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("58e5d0f1-659f-42b4-8b69-bfdcb4708fa5"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("5ee09c8b-8f41-4c9f-bf99-6cf37426e0aa"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("6c0fda6e-555e-4c2d-9d34-412342b74bc2"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("8c9a74c6-9c90-4b3a-97d5-88a9d70d22f1"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("a30dbd93-1e53-46b4-9c63-f0eabf9cfed2"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("b61bbcb7-5f43-4e38-9050-15f178e8d4a5"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("b69b69c3-8243-4b66-b3c5-4e2dfd0a8cc6"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("c6f1e32c-7a32-4b2e-b7e5-9bcbf7efcb4a"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("d0c7f3d2-0370-479f-9c09-98f4e09a2b62"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("d55c0882-2436-4b93-9e48-16f6c8df73bb"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("d7e98812-a5bc-4c97-8d1a-61f8d4a9f6ef"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("e97a3b1e-fc2a-4739-91a3-6c04f09d26b2"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("ec0f60a1-63f8-4901-a63c-0075f812dbf3"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("fe0b0053-5a7d-49a1-8a38-ea37d4b00725"));

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
                    { new Guid("1b27e9b2-5c2b-49db-9b12-5a36dbd2b789"), "IVC", "Invercargill City", "https://test.com/images/invercargill.jpg" },
                    { new Guid("31c1a2d2-21bc-4b4d-b71b-41f30353aecd"), "NPL", "New Plymouth City", "https://test.com/images/newplymouth.jpg" },
                    { new Guid("5a8ef127-82b4-4721-8d65-6f769eef2b56"), "DUD", "Dunedin City", "https://test.com/images/dunedin.jpg" },
                    { new Guid("75f98dfc-8892-4586-a7da-78a545d1c40b"), "WGN", "Wellington City", "https://test.com/images/wellington.jpg" },
                    { new Guid("8d5e786b-cc43-4b6f-9a6f-c49a4fdfd223"), "PMR", "Palmerston North City", "https://test.com/images/palmerstonnorth.jpg" },
                    { new Guid("93f7a19c-2e65-4db8-8c6e-0dd25c7bf93d"), "NPR", "Napier-Hastings", "https://test.com/images/napier.jpg" },
                    { new Guid("9a5b58c1-d91a-47e3-8101-c03c2f839adf"), "CHC", "Christchurch City", "https://test.com/images/christchurch.jpg" },
                    { new Guid("a4e65b12-c0c3-4bb4-bb4d-1fd61ef6358f"), "HAM", "Hamilton City", "https://test.com/images/hamilton.jpg" },
                    { new Guid("b27e9b54-6893-4f5d-83e8-4ad6b4cfae7c"), "NSN", "Nelson City", "https://test.com/images/nelson.jpg" },
                    { new Guid("c0f1f364-65d6-4f87-96a4-0a2a9783b6c4"), "WHG", "Whangarei City", "https://test.com/images/whangarei.jpg" },
                    { new Guid("cfb8f37c-4a45-4cbf-a8ba-11fefdfdfedd"), "RTR", "Rotorua Lakes", "https://test.com/images/rotorua.jpg" },
                    { new Guid("d4f7db27-8d6e-4502-912f-f9a61b5d5894"), "GIS", "Gisborne City", "https://test.com/images/gisborne.jpg" },
                    { new Guid("dd6f96c3-fbc6-4b43-b89b-8f626d0e18f6"), "QTN", "Queenstown Town", "https://test.com/images/queenstown.jpg" },
                    { new Guid("e6c4e032-6a19-432b-9466-cc342a7558de"), "TRG", "Tauranga Bay", "https://test.com/images/tauranga.jpg" },
                    { new Guid("f7bfb5cf-7919-4c90-9b4d-91de354b4c11"), "AKL", "Auckland City", "https://test.com/images/auckland.jpg" }
                });
        }
    }
}
