using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NZWalks.API.CustomActionFilters;
using NZWalks.API.Data;
using NZWalks.API.Models.Domain;
using NZWalks.API.Models.DTO;
using NZWalks.API.Repositories;
using System.Text.Json;

namespace NZWalks.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        private readonly NZWalksDbContext dbContext;
        private readonly IRegionRepository regionRepository;
        private readonly IMapper mapper;
        private readonly ILogger<RegionsController> logger;

        public RegionsController(NZWalksDbContext dbContext, IRegionRepository regionRepository, IMapper mapper, ILogger<RegionsController> logger)
        {
            this.dbContext = dbContext;
            this.regionRepository = regionRepository;
            this.mapper = mapper;
            this.logger = logger;
        }

        // Get all regions
        [HttpGet]
        // [Authorize(Roles = "Reader")]
        public async Task<IActionResult> GetAll()
        {
            // Testing log
            logger.LogInformation("GetAllRegions action method invoked.");

            // Testing global exception handler
            // throw new Exception();

            // Get data from database - Domain models
            var regionsDomain = await regionRepository.GetAll();

            // Map Region domain model to Region DTO
            var regionsDTO = mapper.Map<List<RegionDTO>>(regionsDomain);

            logger.LogInformation("Finished request: " + JsonSerializer.Serialize(regionsDTO));

            // Return DTO
            return Ok(regionsDTO);
        }        
        
        // Get region by ID
        [HttpGet]
        [Route("{id:Guid}")]
        [Authorize(Roles = "Reader")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            //var regions = dbContext.Regions.Find(id);
            
            // Get Region domain model from database
            var regionDomain = await regionRepository.GetByID(id);
            if (regionDomain == null)
            {
                return NotFound();
            }

            // Map Region domain model to Region DTO
            var regionDTO = mapper.Map<RegionDTO>(regionDomain);   

            // Return DTO
            return Ok(regionDTO);
        }

        // Create a new region
        [HttpPost]
        [ValidateModel]
        [Authorize(Roles = "Writer")]
        public async Task<IActionResult> Create([FromBody] AddRegionDTO addRegionDTO)
        {
            // Map DTO to domain model
            var regionDomainModel = mapper.Map<Region>(addRegionDTO);

            regionDomainModel = await regionRepository.Create(regionDomainModel);

            // Map domain model back to DTO to send it as response after resource is created
            var regionDTO = mapper.Map<RegionDTO>(regionDomainModel);

            return CreatedAtAction(nameof(GetById), new { id = regionDTO.Id }, regionDTO);
        }

        // Update a region
        [HttpPut]
        [Route("{id:Guid}")]
        [ValidateModel]
        [Authorize(Roles = "Writer")]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] UpdateRegionDTO updateRegionDTO)
        {
            // Map DTO to domain model
            var regionDomainModel = mapper.Map<Region>(updateRegionDTO);

            // Check if region exists
            regionDomainModel = await regionRepository.Update(id, regionDomainModel);

            if (regionDomainModel == null)
            {
                return NotFound();
            }

            // Convert domain model to DTO to send the response to client
            var regionDTO = mapper.Map<RegionDTO>(regionDomainModel);

            return Ok(regionDTO);
        }

        // Delete a region
        [HttpDelete]
        [Route("{id:Guid}")]
        [Authorize(Roles = "Writer")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            // Check if region exists
            var regionDomainModel = await regionRepository.Delete(id);

            if (regionDomainModel == null)
            {
                return NotFound();
            }

            // Convert domain model to DTO to send the response to client
            var regionDTO = mapper.Map<RegionDTO>(regionDomainModel);

            return Ok(regionDTO);
        }
    }
}
