using HotelListingApi.Data;
using HotelListingApi.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HotelListingApi.Repository
{
    public class HotelsRepository : GenericRepository<Hotel>, IHotelsRepository
    {
        public HotelsRepository(HotelListingDbContext ctx) : base(ctx)
        {
        }

        public async Task<Hotel> GetDetailsAsync(int id)
        {
            return await _ctx.Hotels.Include(x => x.Country).FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
