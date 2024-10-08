using Microsoft.EntityFrameworkCore;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Data
{
    public class NZWalksDbContext : DbContext
    {
        public NZWalksDbContext(DbContextOptions<NZWalksDbContext> dbContextOptions) : base(dbContextOptions) 
        {
            
        }

        public DbSet<Difficulty> Difficulties { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
        public DbSet<Image> Images { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var difficulties = new List<Difficulty>()
            {
                new Difficulty()
                {
                    Id = Guid.Parse("a5d22f24-d5c4-4b65-8b8e-16447bfa4381"),
                    Name = "Easy"
                },
                new Difficulty()
                {
                    Id = Guid.Parse("cc6c55d7-6d9f-40a1-9c9e-8e94e1e5e9bc"),
                    Name = "Medium"
                },
                new Difficulty()
                {
                    Id = Guid.Parse("b9b1dabc-dcdc-4b06-b594-b0c4301a5e8d"),
                    Name = "Hard"
                }
            };

            modelBuilder.Entity<Difficulty>().HasData(difficulties);

            var regions = new List<Region>()
            {
                new Region()
                {
                    Id = Guid.Parse("d7e98812-a5bc-4c97-8d1a-61f8d4a9f6ef"),
                    Name = "Wellington",
                    Code = "WGN",
                    RegionImageUrl = "https://test.com/images/wellington.jpg"
                },
                new Region()
                {
                    Id = Guid.Parse("e97a3b1e-fc2a-4739-91a3-6c04f09d26b2"),
                    Name = "Auckland",
                    Code = "AKL",
                    RegionImageUrl = "https://test.com/images/auckland.jpg"
                },
                new Region()
                {
                    Id = Guid.Parse("8c9a74c6-9c90-4b3a-97d5-88a9d70d22f1"),
                    Name = "Christchurch",
                    Code = "CHC",
                    RegionImageUrl = "https://test.com/images/christchurch.jpg"
                },
                new Region()
                {
                    Id = Guid.Parse("c6f1e32c-7a32-4b2e-b7e5-9bcbf7efcb4a"),
                    Name = "Hamilton",
                    Code = "HAM",
                    RegionImageUrl = "https://test.com/images/hamilton.jpg"
                },
                new Region()
                {
                    Id = Guid.Parse("58e5d0f1-659f-42b4-8b69-bfdcb4708fa5"),
                    Name = "Dunedin",
                    Code = "DUD",
                    RegionImageUrl = "https://test.com/images/dunedin.jpg"
                },
                new Region()
                {
                    Id = Guid.Parse("6c0fda6e-555e-4c2d-9d34-412342b74bc2"),
                    Name = "Queenstown",
                    Code = "QTN",
                    RegionImageUrl = "https://test.com/images/queenstown.jpg"
                },
                new Region()
                {
                    Id = Guid.Parse("b61bbcb7-5f43-4e38-9050-15f178e8d4a5"),
                    Name = "Rotorua",
                    Code = "RTR",
                    RegionImageUrl = "https://test.com/images/rotorua.jpg"
                },
                new Region()
                {
                    Id = Guid.Parse("ec0f60a1-63f8-4901-a63c-0075f812dbf3"),
                    Name = "Napier-Hastings",
                    Code = "NPR",
                    RegionImageUrl = "https://test.com/images/napier.jpg"
                },
                new Region()
                {
                    Id = Guid.Parse("16cf9c45-1004-4f04-85bb-bd3ff9a317c3"),
                    Name = "Tauranga",
                    Code = "TRG",
                    RegionImageUrl = "https://test.com/images/tauranga.jpg"
                },
                new Region()
                {
                    Id = Guid.Parse("b69b69c3-8243-4b66-b3c5-4e2dfd0a8cc6"),
                    Name = "Invercargill",
                    Code = "IVC",
                    RegionImageUrl = "https://test.com/images/invercargill.jpg"
                },
                new Region()
                {
                    Id = Guid.Parse("fe0b0053-5a7d-49a1-8a38-ea37d4b00725"),
                    Name = "Nelson",
                    Code = "NSN",
                    RegionImageUrl = "https://test.com/images/nelson.jpg"
                },
                new Region()
                {
                    Id = Guid.Parse("a30dbd93-1e53-46b4-9c63-f0eabf9cfed2"),
                    Name = "Palmerston North",
                    Code = "PMR",
                    RegionImageUrl = "https://test.com/images/palmerstonnorth.jpg"
                },
                new Region()
                {
                    Id = Guid.Parse("d0c7f3d2-0370-479f-9c09-98f4e09a2b62"),
                    Name = "New Plymouth",
                    Code = "NPL",
                    RegionImageUrl = "https://test.com/images/newplymouth.jpg"
                },
                new Region()
                {
                    Id = Guid.Parse("d55c0882-2436-4b93-9e48-16f6c8df73bb"),
                    Name = "Whangarei",
                    Code = "WHG",
                    RegionImageUrl = "https://test.com/images/whangarei.jpg"
                },
                new Region()
                {
                    Id = Guid.Parse("5ee09c8b-8f41-4c9f-bf99-6cf37426e0aa"),
                    Name = "Gisborne",
                    Code = "GIS",
                    RegionImageUrl = "https://test.com/images/gisborne.jpg"
                }
            };

            modelBuilder.Entity<Region>().HasData(regions);
        }
    }
}
