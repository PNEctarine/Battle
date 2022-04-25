using Kuhpik;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class VictoryUI : UIScreen
{
    [SerializeField] private TextMeshProUGUI _battleTimeTMP;
    [SerializeField] private Button _nextButton;

    private void Start()
    {
        _nextButton.onClick.AddListener(() => Bootstrap.GameRestart(0));
    }

    public void SetBattleTime(int time)
    {
        _battleTimeTMP.text = $"you won for {time} seconds";
    }
}
