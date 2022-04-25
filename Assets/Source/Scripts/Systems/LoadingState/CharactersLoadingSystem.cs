using Kuhpik;

public class CharactersLoadingSystem : GameSystem, IIniting
{
    void IIniting.OnInit()
    {
        int playerCharectersCount = game.Level.PlayerCharacters.Length;
        int enemiesCharectersCount = game.Level.EnemiesCharacters.Length;

        for (int i = 0; i < playerCharectersCount; i++)
        {
            game.PlayerCharacters.Add(game.Level.PlayerCharacters[i]);
        }

        for (int i = 0; i < enemiesCharectersCount; i++)
        {
            game.EnemyCharacters.Add(game.Level.EnemiesCharacters[i]);
        }
    }
}
