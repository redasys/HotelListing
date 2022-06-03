using System.ComponentModel.DataAnnotations;

namespace HotelListingApi.Models.Users
{
    public class ApiUserDto:ApiLoginDto
    {
        [Required]
        public string FirstName { get; set; }
        [Required] 
        public string LastName { get; set; }        
        public bool IsAdmin { get; set; }
        
    }
}
