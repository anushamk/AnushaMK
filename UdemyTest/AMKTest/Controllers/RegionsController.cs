using AMKTest.Models.Domain;
using AMKTest.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace AMKTest.Controllers
{
    [ApiController]
    [Route ("[controller]")]
    public class RegionsController : Controller
    {
        private readonly IRegionRepository regionRepository;
        private readonly IMapper mapper;

        public RegionsController(IRegionRepository regionRepository,IMapper mapper)
        {
            this.regionRepository = regionRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllRegions()
        {
            var regions = await regionRepository.GetAllAsync();

            //Navigate to DTO
            //var regionsDTO = new List<Models.DTO.Region>();

            //regions.ToList().ForEach(region =>
            //    {
            //        var regionDTO = new Models.DTO.Region()
            //        {

            //            ID = region.ID,
            //            CodeTest = region.Code,
            //            Name = region.Name,
            //            Area = region.Area,
            //            Lat = region.Lat,
            //            Long = region.Long,
            //            Population = region.Population,
            //        };

            //        regionsDTO.Add(regionDTO);
            //    });

            var regionsDTO = mapper.Map<List<Models.DTO.Region>>(regions);


            return Ok(regionsDTO);
        }
    }
}
