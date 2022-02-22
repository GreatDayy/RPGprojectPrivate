using System.Collections.Generic;
using System.Threading.Tasks;
using rolePlayingGame.Models;

namespace rolePlayingGame.Services.CharacterServices
{
    public interface ICharacterService
    {
         Task<List<Character>> GetAll();
         Task<Character> GetSingle(int id);

        Task<List<Character>> AddCharacter(Character newCharacter);

    }
}