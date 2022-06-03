using HotelListingApi.Data;

namespace HotelListingApi.Interfaces
{
    public interface ICountriesRepository : IGenericRepository<Country>
    {
        public Task<Country> GetDetails(int id);
    }
}
