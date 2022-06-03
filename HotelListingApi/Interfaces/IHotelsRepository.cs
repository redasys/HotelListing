using HotelListingApi.Data;

namespace HotelListingApi.Interfaces
{
    public interface IHotelsRepository:IGenericRepository<Hotel>
    {
        Task<Hotel> GetDetailsAsync(int id);
    }
}
