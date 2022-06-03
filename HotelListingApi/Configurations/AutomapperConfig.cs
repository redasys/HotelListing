using AutoMapper;
using HotelListingApi.Data;
using HotelListingApi.Models.Country;
using HotelListingApi.Models.Hotel;
using HotelListingApi.Models.Users;

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
            CreateMap<Hotel, BaseHotel>().ReverseMap();
            CreateMap<Hotel, HotelDetailsDto>().ReverseMap();
            CreateMap<ApiUserDto, ApiUser>().ReverseMap();
        }
    }
}
