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
        public Guid GameId { get; set; }

        [Required]
        public string Name { get; set; }

        public string GameStore { get; set; }

        [Required]
        public Platform Platform { get; set; }

        [Required]
        public Genre Genre { get; set; }

        [Required]
        public MaturityRating MaturityRating { get; set; }

        public Modding Modding { get; set; }
    }
}
