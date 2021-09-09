using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smoke.Data
{
    public class Genre
    {
        [Key]
        public int GenreId { get; set; }

        [Required]
        public string GenreName { get; set; }


    }
    //public enum Genres {Shooter, Fighting, Stealth, Survival, Rhythm, BattleRoyale, Horror, Adventure, ActionRPG, MMORPG, Roguelike, RogueLite, JRPG, Simulation, FourX, MOBA, RealTimeStrategy, TowerDefense, TurnBasedStrategy, GrandStrategy, Sports, Racing, MMO, Idle, Board, Educatonal, Sandbox, OpenWorld, SoulsLike}
}
