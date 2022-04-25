using Kuhpik;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LoseUI : UIScreen
{
    [SerializeField] private TextMeshProUGUI _battleTimeTMP;
    [SerializeField] private Button _restartButton;

    private void Start()
    {
        _restartButton.onClick.AddListener(() => Bootstrap.GameRestart(0));
    }

    public void SetBattleTime(int time)
    {
        _battleTimeTMP.text = $"you lost for {time} seconds";
    }
}
