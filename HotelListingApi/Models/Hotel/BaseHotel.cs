using System.ComponentModel.DataAnnotations;

namespace HotelListingApi.Models.Hotel
{
    public class BaseHotel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public double Rating { get; set; }
        [Required]
        public int CountryId { get; set; }
    }
}
