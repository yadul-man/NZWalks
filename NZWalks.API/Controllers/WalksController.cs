﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NZWalks.API.CustomActionFilters;
using NZWalks.API.Models.Domain;
using NZWalks.API.Models.DTO;
using NZWalks.API.Repositories;

namespace NZWalks.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WalksController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IWalkRepository walkRepository;

        public WalksController(IMapper mapper, IWalkRepository walkRepository)
        {
            this.mapper = mapper;
            this.walkRepository = walkRepository;
        }

        [HttpPost]
        [ValidateModel]
        public async Task<IActionResult> Create([FromBody] AddWalkDTO addWalkDTO)
        {
            // Map DTO to walk domain model
            var walkDomainModel = mapper.Map<Walk>(addWalkDTO);

            await walkRepository.Create(walkDomainModel);

            // Map domain to DTO
            var walkDTO = mapper.Map<WalkDTO>(walkDomainModel);
            
            return Ok(walkDTO);
        }

        [HttpGet]
        // GET: /api/Walks?filterOn=Name&filterQuery=Track&sortBy=Name&isAscending=true&pageNumber=1&pageSize=10 (user may add filtering query params to the url where filterOn is the column to filter and filterQuery is the query string)
        public async Task<IActionResult> GetAll([FromQuery] string? filterOn, [FromQuery] string? filterQuery, [FromQuery] string? sortBy, [FromQuery] bool? isAscending, [FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 1000)
        {
            var walksDomainModel = await walkRepository.GetAll(filterOn, filterQuery, sortBy, isAscending ?? true, pageNumber, pageSize);

            // Map domain model to DTO
            return Ok(mapper.Map<List<WalkDTO>>(walksDomainModel));
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            var walkDomainModel = await walkRepository.GetById(id);
            if (walkDomainModel == null)
            {
                return NotFound();
            }

            // Map domain model to DTO
            return Ok(mapper.Map<WalkDTO>(walkDomainModel));
        }

        [HttpPut]
        [Route("{id:Guid}")]
        [ValidateModel]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] UpdateWalkDTO updateWalkDTO)
        {
            // Map DTO to domain model
            var walkDomainModel = mapper.Map<Walk>(updateWalkDTO);
            walkDomainModel = await walkRepository.Update(id, walkDomainModel);
            
            if (walkDomainModel == null)
            { return NotFound(); }

            // Map domain model to DTO
            return Ok(mapper.Map<WalkDTO>(walkDomainModel));
        }

        [HttpDelete]
        [Route("{id:Guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var deletedWalkDomainModel = await walkRepository.Delete(id);

            if (deletedWalkDomainModel == null)
            { return NotFound(); }

            // Map domain model to DTO
            return Ok(mapper.Map<WalkDTO>(deletedWalkDomainModel));
        }
    }
}
