using AutoMapper;
using NZWals.API.Model.Domain;

namespace NZWalks.API.Model.Profiles
{
    public class RegionsProfile : Profile
    {
        public RegionsProfile()
        {
            CreateMap<Region, Model.DTO.Region>();
        }
    }
}
