using AMKTest.Models.Domain;

namespace AMKTest.Repositories
{
    public interface IRegionRepository
    {
        Task<IEnumerable<Region>> GetAllAsync();
    }
}
