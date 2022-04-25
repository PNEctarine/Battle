using Kuhpik;

public class VictorySystem : GameSystemWithScreen<VictoryUI>, IIniting
{
    void IIniting.OnInit()
    {
        screen.SetBattleTime(game.BattleTimer);
    }
}
