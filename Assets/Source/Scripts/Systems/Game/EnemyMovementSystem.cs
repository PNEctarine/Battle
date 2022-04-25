using Kuhpik;
using UnityEngine;

public class EnemyMovementSystem : GameSystem, IIniting, IUpdating
{
    private Transform _target;

    public void OnInit()
    {
        int targetIndex = Random.Range(0, game.PlayerCharacters.Count);
        _target = game.PlayerCharacters[targetIndex].transform;

        TargetSet();
    }

    void IUpdating.OnUpdate()
    {
        if (_target.gameObject.activeInHierarchy == false)
        {
            int targetIndex = Random.Range(0, game.PlayerCharacters.Count);
            _target = game.PlayerCharacters[targetIndex].transform;

            TargetSet();
        }
    }

    private void TargetSet()
    {
        for (int i = 0; i < game.EnemyCharacters.Count; i++)
        {
            game.EnemyCharacters[i].GetComponent<CharacterComponent>().enabled = true;
            game.EnemyCharacters[i].GetComponent<CharacterComponent>().TargetSet(_target);
        }
    }
}
