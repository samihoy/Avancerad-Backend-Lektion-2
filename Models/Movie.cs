using System.ComponentModel.DataAnnotations;

namespace Avancerad_Backend_Lektion_2.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(200)]
        public string Titel { get; set; }
        [Required]
        public int ReleseYear { get; set; }


    }
}
