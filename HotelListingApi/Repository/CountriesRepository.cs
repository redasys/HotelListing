using HotelListingApi.Data;
using HotelListingApi.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HotelListingApi.Repository
{
    public class CountriesRepository : GenericRepository<Country>, ICountriesRepository
    {
        public CountriesRepository(HotelListingDbContext ctx) : base(ctx)
        {            
        }

        public async Task<Country> GetDetails(int id)
        {
            return await _ctx.Countries.Include(q => q.Hotels).FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
