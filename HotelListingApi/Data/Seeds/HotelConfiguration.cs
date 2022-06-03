using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListingApi.Data.Seeds
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Sandals Resort and Spa",
                    Address = "Negril",
                    CountryId = 1,
                    Rating = 4.5
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Comfort Suites",
                    Address = "Nassau",
                    CountryId = 2,
                    Rating = 4.3
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Gtand Palladium",
                    Address = "Grand Cayman",
                    CountryId = 3,
                    Rating = 3.8
                }
                );
        }
    }
}
