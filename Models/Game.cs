using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace games_api.Models
{
    public class Game
    {
        [Key]
        public int idGame { get; set; }
        public string name { get; set; }
        public string releaseDate { get; set; }
        public string synopsis { get; set; }

        public string ?video { get; set; }
        public string ?keyWord { get; set; }
        public string ?classification {  get; set; }

        public  List<Image> ?Images { get; set; } = new List<Image>();
    }
}