using Kuhpik;
using UnityEngine;

public class PlayerMovementSystem : GameSystem, IIniting, IUpdating
{
    private Transform _target;

    public void OnInit()
    {
        int targetIndex = Random.Range(0, game.EnemyCharacters.Count);
        _target = game.EnemyCharacters[targetIndex].transform;

        TargetSet();
    }

    void IUpdating.OnUpdate()
    {
        if (_target.gameObject.activeInHierarchy == false)
        {
            int targetIndex = Random.Range(0, game.EnemyCharacters.Count);
            _target = game.EnemyCharacters[targetIndex].transform;

            TargetSet();
        }
    }

    private void TargetSet()
    {
        for (int i = 0; i < game.PlayerCharacters.Count; i++)
        {
            game.PlayerCharacters[i].GetComponent<CharacterComponent>().enabled = true;
            game.PlayerCharacters[i].GetComponent<CharacterComponent>().TargetSet(_target);
        }
    }
}
