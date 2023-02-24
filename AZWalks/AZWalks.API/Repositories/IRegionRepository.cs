using AZWalks.API.Models.Domain;

namespace AZWalks.API.Repositories
{
    public interface IRegionRepository
    {
        Task<IEnumerable<Region>> GetAll();
    }
}
