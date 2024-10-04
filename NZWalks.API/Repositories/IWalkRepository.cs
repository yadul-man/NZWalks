﻿using NZWalks.API.Models.Domain;

namespace NZWalks.API.Repositories
{
    public interface IWalkRepository
    {
        Task<Walk> Create(Walk walk);
        Task<List<Walk>> GetAll();
        Task<Walk?> GetById(Guid id);
        Task<Walk?> Update(Guid id, Walk walk);
        Task<Walk?> Delete(Guid id);
    }
}
