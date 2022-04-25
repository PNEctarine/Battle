using System.Collections;
using Kuhpik;
using UnityEngine;

public class BattleTimerSystem : GameSystem, IIniting
{
    void IIniting.OnInit()
    {
        StartCoroutine(StartTimer());
    }

    private IEnumerator StartTimer()
    {
        while (Bootstrap.GetCurrentGamestate() != EGamestate.Lose && Bootstrap.GetCurrentGamestate() != EGamestate.Victory)
        {
            game.BattleTimer++;
            yield return new WaitForSeconds(1f);
        }
    }
}
