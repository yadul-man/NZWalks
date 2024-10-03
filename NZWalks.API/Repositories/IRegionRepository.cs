using NZWalks.API.Models.Domain;

namespace NZWalks.API.Repositories
{
    public interface IRegionRepository
    {
        public Task<List<Region>> GetAll();
        public Task<Region?> GetByID(Guid id);
        public Task<Region> Create(Region region);
        public Task<Region?> Update(Guid id, Region region);
        public Task<Region?> Delete(Guid id);
    }
}
