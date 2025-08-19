using Avancerad_Backend_Lektion_2.Models;
using Microsoft.EntityFrameworkCore;

namespace Avancerad_Backend_Lektion_2.Data
{
    public class MovieRentalDBContext : DbContext
    {
        public MovieRentalDBContext(DbContextOptions<MovieRentalDBContext> options) : base (options)
        {
            
        }

        DbSet<User> Users { get; set; }
        DbSet<Movie> Movies { get; set; }
        DbSet<UserMovies> Loan { get; set; }

    }
}
