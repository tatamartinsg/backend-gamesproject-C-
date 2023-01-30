using Dapper;
using games_code.Model;
using games_code.Repositories.Interfaces;
using MySqlConnector;

namespace games_code.Repositories
{
    public class GameRepository : IGame
    {
        private readonly string _connectionString;

        public GameRepository(string connectionString) { 
            _connectionString = connectionString;
        }

        public IEnumerable<GameModel> getAllGames()
        {
            var sql = "SELECT * FROM game;";
            using (MySqlConnection connection = new MySqlConnection(_connectionString)){
                return connection.Query<GameModel>(sql);
            }
        }

    }
}
