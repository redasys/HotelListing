using AutoMapper;
using HotelListingApi.Data;
using HotelListingApi.Models.Country;
using HotelListingApi.Models.Hotel;

namespace HotelListingApi.Configurations
{
    public class AutomapperConfig:Profile
    {
        public AutomapperConfig()
        {
            CreateMap<Country, CreateCountryDto>().ReverseMap();
            CreateMap<Country, CountryDto>().ReverseMap();
            CreateMap<Country, UpdateCountryDto>().ReverseMap();
            CreateMap<Country, CountryDetailDto>().ReverseMap();
            CreateMap<Hotel, HotelDto>().ReverseMap();
        }
    }
}
