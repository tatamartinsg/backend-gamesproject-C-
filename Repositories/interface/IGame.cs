using games_code.Model;

namespace games_code.Repositories.Interfaces
{
    public interface IGame
    {
        IEnumerable<GameModel> getAllGames();
        // Task<List<GameModel>> getAllGames();
        //Task<List<GameModel>> getGamesByCategory(string category);

    }
}
