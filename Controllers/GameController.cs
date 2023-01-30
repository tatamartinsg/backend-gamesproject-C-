using games_code.Model;
using games_code.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace games_code.Controllers;

[ApiController]
[Route("[controller]")]
public class GameController : ControllerBase
{
    private readonly IGame _gameRepository;

    public GameController(IGame gameRepository)
    {
        _gameRepository = gameRepository;
    }

    [HttpGet()]
    public IActionResult getAllGames()
    {
        var games = _gameRepository.getAllGames();

        if(games.Count() == 0){
             return NoContent();
        }
    
        return Ok(games);
    }
}
