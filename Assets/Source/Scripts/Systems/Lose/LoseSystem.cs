using Kuhpik;

public class LoseSystem : GameSystemWithScreen<LoseUI>, IIniting
{
    void IIniting.OnInit()
    {
        screen.SetBattleTime(game.BattleTimer);
    }
}
