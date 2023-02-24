using AutoMapper;

namespace AZWalks.API.Profiles
{
    public class RegionsProfile:Profile
    {
        public RegionsProfile()
        {
            CreateMap<Models.Domain.Region, Models.DTo.Region>();
        }
    }
}
