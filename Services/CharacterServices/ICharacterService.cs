using System.Collections.Generic;
using rolePlayingGame.Models;

namespace rolePlayingGame.Services.CharacterServices
{
    public interface ICharacterService
    {
         List<Character> GetAll();
         Character GetSingle(int id);

        List<Character> AddCharacter(Character newCharacter);

    }
}