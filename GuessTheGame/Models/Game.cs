using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace GuessTheGame.Models
{
    public class Game
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        [DisplayName("Launch Year")]
        public string LaunchYear { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        public string Company { get; set; }
    }
}
