using HotelListingApi.Models.Country;

namespace HotelListingApi.Models.Hotel
{
    public class HotelDetailsDto:HotelDto
    {
        public CountryDto Country { get; set; }
    }
}
