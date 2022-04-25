using UnityEngine;

public class LevelComponent : MonoBehaviour
{
    [field: SerializeField] public GameObject[] PlayerCharacters { get; private set; }
    [field: SerializeField] public GameObject[] EnemiesCharacters { get; private set; }
}
