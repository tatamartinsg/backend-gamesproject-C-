using System;
using System.ComponentModel.DataAnnotations;

namespace games_code.Model
{
	public class ImageModel
	{
        [Key]
        public int idImage { get; set; }
		public string imageBg { get; set; }
		public string imageCard { get; set; }

	}
}