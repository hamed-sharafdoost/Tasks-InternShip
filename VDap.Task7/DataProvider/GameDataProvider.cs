using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VDap.Task7.Model;

namespace VDap.Task7.DataProvider
{
    public interface IGameDataProvider
    {
        IEnumerable<Game> GetGames();
    }
    public class GameDataProvider : IGameDataProvider
    {
        private static GameDataProvider instance;
        public static GameDataProvider GetInstance()
        {
            instance = instance ?? new GameDataProvider();
            return instance;
        }
        IList<Game> games = new List<Game>()
        {
            new Game() {Name = "NeedForSpeed",Description = "It is a sport game.It is designed for windows OS"},
            new Game() {Name ="Call of duty",Description = "One of the most popular game in history.It is available for all platforms"},
            new Game() {Name = "Fifa2022",Description = "Very exciting game which is suitable for all group ages"}
        };
        public IEnumerable<Game> GetGames()
        {
            return games;
        }
    }
}
