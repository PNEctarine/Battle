using System.Collections.Generic;
using UnityEngine;

namespace Kuhpik
{
    /// <summary>
    /// Used to store game data. Change it the way you want.
    /// </summary>
    public class GameData
    {
        public LevelComponent Level;

        public List<GameObject> PlayerCharacters = new List<GameObject>();
        public List<GameObject> EnemyCharacters = new List<GameObject>();

        public int BattleTimer;
        // Example (I use public fields for data, but u free to use properties\methods etc)
        // public float LevelProgress;
        // public Enemy[] Enemies;
    }
}