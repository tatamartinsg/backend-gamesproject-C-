using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace games_api.Models
{
    public class Image
    {
        [Key]
		public int idImage{ get; set; }
		public string imageBg { get; set; }
		public string imageCard { get; set; }

        public int gameId{ get; set; }
    }
}