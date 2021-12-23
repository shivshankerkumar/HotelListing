using HotelListing.Data;
using Microsoft.EntityFrameworkCore;

namespace HotelListing
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options): base(options)
        {}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "India",
                    ShortName= "IN"
                },
                new Country
                {
                    Id = 2,
                    Name = "Sri Lanka",
                    ShortName = "SL"
                },
                new Country
                {
                    Id = 3,
                    Name = "Nepal",
                    ShortName = "NP"
                }
            );

            builder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Taj",
                    Address = "Mumbai",
                    CountryId = 1,
                    Rating = 5
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Hotel 2",
                    Address = "Sri Lanka",
                    CountryId = 2,
                    Rating = 4
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Hotel 3",
                    Address = "Nepal",
                    CountryId = 3,
                    Rating = 5
                },
                new Hotel
                {
                    Id = 4,
                    Name = "Hotel 4",
                    Address = "India",
                    CountryId = 1,
                    Rating = 3.9
                }
            );
        }

        public DbSet<Country>? Countries { get; set; }
        public DbSet<Hotel>? Hotels { get; set; }
    }
}
