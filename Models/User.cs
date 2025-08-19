using System.ComponentModel.DataAnnotations;

namespace Avancerad_Backend_Lektion_2.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<UserMovies> UserMovies{ get; set; }
    }
}
