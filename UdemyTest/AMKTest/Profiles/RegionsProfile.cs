using AutoMapper;

namespace AMKTest.Profiles
{
    public class RegionsProfile : Profile
    {

        public RegionsProfile()
        {
            CreateMap<Models.Domain.Region, Models.DTO.Region>().ReverseMap();
        }
    }
}
