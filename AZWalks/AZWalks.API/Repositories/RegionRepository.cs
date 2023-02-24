using AZWalks.API.Data;
using AZWalks.API.Models.Domain;

namespace AZWalks.API.Repositories
{
    public class RegionRepository : IRegionRepository
    {
        private readonly AZWalksDBcontext aZWalksDBcontext;

        public RegionRepository(AZWalksDBcontext aZWalksDBcontext)
        {
            this.aZWalksDBcontext = aZWalksDBcontext;
        }


        public IEnumerable<Region> GetAll()
        {
           return aZWalksDBcontext.Regions.ToList();   
        }
    }
}
