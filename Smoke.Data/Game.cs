using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smoke.Data
{
    public class Game
    {
        [Key]
        public int GameId { get; set; }

        [Required]
        public string Name { get; set; }

        public string GameStore { get; set; }

        [Required]
        public Platform platform { get; set; }

        [Required]
        public List<Genre> genre { get; set; }

        [Required]
        public MaturityRating Maturity_Rating { get; set; }

        public bool HasModSupport { get; set; }
    }
}
