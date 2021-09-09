using Smoke.Data;
using Smoke.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smoke.Services
{
    public class GameService
    {
        public bool CreateGame(GameCreate model)
        {
            var entity = new Game()
            {
                GameId = model.GameId,
                Name = model.Name,
                GameStore = model.GameStore,
                platform = model.platform,
                genre = model.genre,
                Maturity_Rating = model.Maturity_Rating,
                HasModSupport = model.HasModSupport
            };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Games.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<GameListItem> GetGames(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .Games
                    .Where(e => e.GameId == id)
                    .Select(
                        e =>
                        new GameListItem
                        {
                            GameId = e.GameId,
                            Name = e.Name
                        }
                        );
                return query.ToArray();
            }
        }
        public GameDetail GetGameById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx.Games
                    .Single(e => e.GameId == id);
                return new GameDetail
                {
                    GameId = entity.,
                    GameId = id,
                    Name = entity.Name,
                    GameStore = entity.GameStore,
                    platform = entity.platform,
                    genre = entity.genre,
                    Maturity_Rating = entity.Maturity_Rating,
                    HasModSupport = entity.HasModSupport
                };
            }
        }

        public bool UpdateGame(GameEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Games
                        .Single(e => e.GameId == model.GameId);

                entity.Platform = model.Platform;
                entity.GameStore = model.GameStore;
                entity.HasModSupport = model.HasModSupport;

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
