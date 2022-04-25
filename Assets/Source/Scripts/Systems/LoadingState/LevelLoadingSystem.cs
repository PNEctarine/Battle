using Kuhpik;
using UnityEngine;

public class LevelLoadingSystem : GameSystem, IIniting
{
    /// <summary>
    /// This logic can be extended if it will be necessary to load different levels.
    /// </summary>
 
    [SerializeField] private GameObject _level;

    void IIniting.OnInit()
    {
        game.Level = _level.GetComponent<LevelComponent>();
    }
}
