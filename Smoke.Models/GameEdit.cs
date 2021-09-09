using Smoke.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smoke.Models
{
    public class GameEdit
    {
        public int GameId { get; set; }
        public Platform platform { get; set; }
        public string GameStore { get; set; }
        public bool HasModSupport { get; set; }
    }
}
