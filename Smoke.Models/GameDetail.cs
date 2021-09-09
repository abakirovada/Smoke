using Smoke.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smoke.Models
{
    public class GameDetail
    {
        public int GameId { get; set; }

        public string Name { get; set; }

        public string GameStore { get; set; }

        public Platform platform { get; set; }

        public Genre genre { get; set; }

        public MaturityRating Maturity_Rating { get; set; }

        public bool HasModSupport { get; set; }
    }
}
