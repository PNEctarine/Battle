using Kuhpik;
using UnityEngine;
using UnityEngine.UI;

public class TapToStartUI : UIScreen
{
    [SerializeField] private Button _startButton;

    private void Start()
    {
        _startButton.onClick.AddListener(() => Bootstrap.ChangeGameState(EGamestate.Game));
    }
}
