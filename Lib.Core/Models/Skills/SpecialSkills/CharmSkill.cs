using KPI_PROJECT.Models;
using Lib.Core.Interfaces;
using Lib.Core.Models.StatesAndEffects;

namespace KPI_PROJECT.Models.EnemySkills;

public class CharmSkill : ISkill
{
    public string Name => "Charming";
    
    
    public void Execute(IBattleUnit caster, IBattleUnit target)
    {
        var existCharm = target.CurrentEffects.Find(e => e.BattleState == BattleState.Charmed);
        if (existCharm != null)
        {
            existCharm.TurnsLeft = 3;
        }

        else
        {
            target.CurrentEffects.Add(new ActiveEffect(BattleState.Charmed, 3));
            target.PhisDefense = Math.Max(0, target.PhisDefense - 3);
        }
    }
}