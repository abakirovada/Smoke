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
        private readonly int _userId;
        public GameService(int userId)
        {
            _userId = userId;
        }

        public bool CreateGame(GameCreate model)
        {
            var entity = new Game()
            {
                GameId = _userId,
                Name = model.Name,
                GameStore = model.GameStore,
                Platform = model.Platform,
                Genre = model.Genre,
                MaturityRating = model.MaturityRating,
                HasModSupport = model.HasModSupport
            };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Games.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<GameListItem> GetGames()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .Games
                    .Where(e => e.GameId == _userId)
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
                    .Single(e => e.GameId == id && e.GameId == _userId);
                return new GameDetail
                {
                    GameId = _userId,
                    Name = entity.Name,
                    GameStore = entity.GameStore,
                    Platform = entity.Platform,
                    Genre = entity.Genre,
                    MaturityRating = entity.MaturityRating,
                    HasModSupport = entity.HasModSupport
                };
            }
        }
    }
}
