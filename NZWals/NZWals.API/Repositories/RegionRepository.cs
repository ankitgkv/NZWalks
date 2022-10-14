using Microsoft.EntityFrameworkCore;
using NZWals.API.Data;
using NZWals.API.Model.Domain;

namespace NZWalks.API.Repositories
{
    public class RegionRepository : IRegionRepository
    {
        private readonly NZWalksDbContext nZWalksDbContext;
        public RegionRepository(NZWalksDbContext nZWalksDbContext)
        {
            this.nZWalksDbContext = nZWalksDbContext;

        }
        public async Task <IEnumerable<Region>> GetAllAsyc()
        {
            return await nZWalksDbContext.Regions.ToListAsync(); 
        }
    }
}
