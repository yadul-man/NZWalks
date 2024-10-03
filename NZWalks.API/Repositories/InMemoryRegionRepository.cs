using NZWalks.API.Models.Domain;

namespace NZWalks.API.Repositories
{
    public class InMemoryRegionRepository : IRegionRepository
    {
        public Task<Region> Create(Region region)
        {
            throw new NotImplementedException();
        }

        public Task<Region?> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Region>> GetAll()
        {
            return new List<Region>
            {
                new Region
                {
                    Id = Guid.NewGuid(),
                    Code = "TST",
                    Name = "Test Region",
                    RegionImageUrl = "https://test.com"
                }
            };
        }

        public Task<Region?> GetByID(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Region?> Update(Guid id, Region region)
        {
            throw new NotImplementedException();
        }
    }
}
