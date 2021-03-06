using System.ComponentModel.DataAnnotations;

namespace HotelListingApi.Models.Country
{
    public class BaseCountryDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string ShortName { get; set; }
    }
}
