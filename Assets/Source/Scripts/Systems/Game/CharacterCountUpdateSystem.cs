using Kuhpik;
using UnityEngine;

public class CharacterCountUpdateSystem : GameSystem, IIniting
{
    void IIniting.OnInit()
    {
        GameEvents.RemoveCharacter_E += CharactersUpdate;
    }

    private void CharactersUpdate(GameObject character, bool isPlayer)
    {
        if (isPlayer)
        {
            game.PlayerCharacters.Remove(character);

            if (game.PlayerCharacters.Count <= 0)
            {
                Bootstrap.ChangeGameState(EGamestate.Lose);
                GameEvents.RemoveCharacter_E = null;
            }
        }

        else
        {
            game.EnemyCharacters.Remove(character);

            if (game.EnemyCharacters.Count <= 0)
            {
                Bootstrap.ChangeGameState(EGamestate.Victory);
                GameEvents.RemoveCharacter_E = null;
            }
        }
    }
}
