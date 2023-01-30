using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace games_code.Model
{
    public class GameModel
    {
        [Required]
        public int idGame { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        public string releaseDate { get; set; }

        [Required]
        public string synopsis { get; set; }

        [Required]

        public string video { get; set; }

        [Required]
        public string keyWord { get; set; }

        [Required]
        public string classification {  get; set; }


    }
}
