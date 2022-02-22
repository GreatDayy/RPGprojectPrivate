using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using rolePlayingGame.Models;
using rolePlayingGame.Services.CharacterServices;

namespace rolePlayingGame.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
       
        private readonly ICharacterService _characterService; //Injecting the characters to the controller. 

        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;
        }

        [HttpGet("GetAll")] 
      

        //List of Characters
        public async Task<ActionResult<List<Character>>> GetAll() {
            return Ok(await _characterService.GetAll());
        }

        [HttpGet("{id}")]
       //A Single Character
        public async Task<ActionResult<Character>> GetSingle(int id) {

            return Ok(await _characterService.GetSingle(id));
        }


        [HttpPost]
        public async Task<ActionResult<List<Character>>> AddCharacter(Character newCharacter) {
            return Ok(await _characterService.AddCharacter(newCharacter));
        }






        
    }
}