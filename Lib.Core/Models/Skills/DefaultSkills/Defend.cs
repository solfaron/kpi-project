using Lib.Core.Interfaces;
using Lib.Core.Models.StatesAndEffects;

namespace Lib.Core.Models.Skills.DefaultSkills;

public class Defend : ISkill
{
    public string Name => "Defend";

    public void Execute(IBattleUnit caster, IBattleUnit target)
    {
        var defendExists =  target.CurrentEffects.Find(e => e.BattleState == BattleState.Defensive);
        if (defendExists != null)
        {
            return;
        }
        
        target.CurrentEffects.Add(new ActiveEffect(BattleState.Defensive, 1));
    }
}