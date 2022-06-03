using HotelListingApi.Models.Hotel;

namespace HotelListingApi.Models.Country
{
    public class CountryDetailDto : CountryDto
    {
        public List<HotelDto> Hotels { get; set; }
    }

   
}
