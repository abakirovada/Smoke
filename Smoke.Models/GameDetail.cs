using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smoke.Models
{
    public class GameDetail
    {
        public Guid GameId { get; set; }

        public string Name { get; set; }

        public string GameStore { get; set; }

        public Platform Platform { get; set; }

        public Genre Genre { get; set; }

        public MaturityRating MaturityRating { get; set; }

        public bool HasModSupport { get; set; }
    }
}
