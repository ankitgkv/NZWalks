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

        public async Task<Region> AddAsync(Region region)
        {
            region.Id = Guid.NewGuid();
            await nZWalksDbContext.AddAsync(region);
           await nZWalksDbContext.SaveChangesAsync();
            return region;  
        }

        public async Task<Region> DeleteAsync(Guid id)
        {
            var region = await nZWalksDbContext.Regions.FirstOrDefaultAsync(x => x.Id == id);
                if(region==null)
            {
                return null;
            }
                nZWalksDbContext.Regions.Remove(region);
          await  nZWalksDbContext.SaveChangesAsync();
            return region;


        }

        public async Task <IEnumerable<Region>> GetAllAsyc()
        {
            return await nZWalksDbContext.Regions.ToListAsync(); 
        }

        public async Task<Region> GetAsync(Guid id)
        {
            return await nZWalksDbContext.Regions.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Region> UpdateAsync(Guid id, Region region)
        {
         var existRegion = await   nZWalksDbContext.Regions.FirstOrDefaultAsync(x=>x.Id==id);
            if(existRegion==null)
            {
                return null;
            }
            existRegion.Code = region.Code;
            existRegion.Name = region.Name;
            existRegion.Lat = region.Lat;
            existRegion.Area = region.Area;
            existRegion.Long = region.Long;
            existRegion.Population = region.Population;

            await nZWalksDbContext.SaveChangesAsync();
            return existRegion;              

           
        }
    }
}
