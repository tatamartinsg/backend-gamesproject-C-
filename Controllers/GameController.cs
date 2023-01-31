using System.Data.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using games_api.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using games_api.Models;

namespace games_api.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class GameController : ControllerBase
    {
        private DataContext _dataContext;

        public GameController(DataContext dataContext){
            this._dataContext = dataContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<Game>>> getAllGames(){
            // var teste = await (
            //     from g in _dataContext.game 
            //     join i in _dataContext.image
            //     on g.idGame equals i.idGame
            //     select new)
            //     .ToListAsync();
            // return Ok(teste);

            // foreach(var obj in teste){
            //     Console.WriteLine($"Model {obj}");
            // }

            var data = await _dataContext.Game
                            .Include(i => i.Images)
                            .ToListAsync();

            return Ok(data);
        }

    }
}