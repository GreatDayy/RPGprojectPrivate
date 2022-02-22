using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using rolePlayingGame.Models;

namespace rolePlayingGame.Services.CharacterServices
{
    public class CharacterService : ICharacterService
    {
        private static  List<Character> characters = new List<Character> {
          new Character(), 
          new Character {Id = 1, Name = "Herman"}
        };
        public async Task<List<Character>> GetAll()
        {
             return characters;
        }

        public async Task<Character> GetSingle(int id)
        {
            var foundCharacter = characters.FirstOrDefault(c => c.Id == id);
            return foundCharacter;
            
        }

        public async Task<List<Character>> AddCharacter(Character newCharacter) {
                 characters.Add(newCharacter);
               return characters;
        }

       
    }
}