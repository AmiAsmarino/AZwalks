using AutoMapper;
using AZWalks.API.Models.Domain;
using AZWalks.API.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AZWalks.API.Controllers
{
    [ApiController]
    [Route("Regions")]
    public class RegionsController : Controller
    {
        private readonly IRegionRepository regionRepository;
        private readonly IMapper mapper;

        public RegionsController(IRegionRepository regionRepository, IMapper mapper)
        {
            this.regionRepository = regionRepository;
            this.mapper = mapper;
        }
        [HttpGet]
        public IActionResult GetAllRegions()
        {
          var regions = regionRepository.GetAll();

        /*var regionsDTo = new List<Models.DTo.Region>();
        //return DTo regions
        regions.ToList().ForEach(region =>
        {
            var regionDTO = new Models.DTo.Region() 
            { 
                Id = region.Id, 
                Code= region.Code,
                Name= region.Name,
                Area= region.Area,  
                Lat= region.Lat,    
                Long= region.Long,  
                Population= region.Population,
            };
            regionsDTo.Add(regionDTO);

        });
        */
        var regionsDTo = mapper.Map<List<Models.DTo.Region>>(regions);
        return Ok(regionsDTo);       
        }
    }
}
