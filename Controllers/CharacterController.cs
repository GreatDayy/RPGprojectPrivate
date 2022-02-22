using System.Collections.Generic;
using System.Linq;
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
        public ActionResult<List<Character>> GetAll() {
            return Ok(_characterService.GetAll());
        }

        [HttpGet("{id}")]
       //A Single Character
        public ActionResult<Character> GetSingle(int id) {

            return Ok(_characterService.GetSingle(id));
        }


        [HttpPost]
        public ActionResult<List<Character>> AddCharacter(Character newCharacter) {
            return Ok(_characterService.AddCharacter(newCharacter));
        }






        
    }
}