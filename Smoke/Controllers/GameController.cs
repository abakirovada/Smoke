using Smoke.Data;
using Smoke.Models;
using Smoke.Services;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Smoke.Controllers
{
    public class GameController : ApiController
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        //post
        [HttpPost]
        public async Task<IHttpActionResult> PostGame(Game game)
        {
            if (ModelState.IsValid)
            {
                _context.Games.Add(game);
                await _context.SaveChangesAsync();
                return Ok();
            }
            return BadRequest(ModelState);
        }


        //get
        [HttpGet]
        public async Task<IHttpActionResult> Get()
        {
            List<GameListItem> games =
                await _context.Games.Select(r => new GameListItem
                {
                    GameId = r.GameId,
                    Name = r.Name
                }).ToListAsync();

            return Ok(games);
        }
        [HttpGet]
        public async Task<IHttpActionResult> GetById(int id)
        {
            Game game = await _context.Games.FindAsync(id);
            if (game != null)
            {
                var gameDetail = new GameDetail
                {
                    GameId = game.GameId,
                    Name = game.Name,
                    GameStore = game.GameStore,
                    platform = game.platform,
                    genre = game.genre,
                    Maturity_Rating = game.Maturity_Rating,
                    HasModSupport = game.HasModSupport
                };
                return Ok(gameDetail);
            }
            return NotFound();
        }

        //put
        [HttpPut]
        public async Task<IHttpActionResult> UpdateGame([FromUri] int id, [FromBody] GameEdit updatedGame)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Game game = await _context.Games.FindAsync(id);

            if (game == null)
            {
                return NotFound();
            }

            game.platform = updatedGame.platform;
            game.GameStore = updatedGame.GameStore;
            game.HasModSupport = updatedGame.HasModSupport;

            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
