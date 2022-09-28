using AMKTest.Data;
using AMKTest.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace AMKTest.Repositories
{
    public class RegionRepository : IRegionRepository
    {
        private readonly AMKDbContext aMK;

        public RegionRepository(AMKDbContext aMK )
        {
            this.aMK = aMK;
        }
        public async Task<IEnumerable<Region>> GetAllAsync()
        {
            return await aMK.TblRegion.ToListAsync();
        }
    }
}
