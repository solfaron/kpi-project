using Lib.Core.Interfaces;
using Lib.Core.Models.StatesAndEffects;

namespace KPI_PROJECT.Models.EnemySkills;

public class ThunderStrikeSkill : ISkill
{
    public string Name => "Thunderstrike";
    public int TotalDmg { get; set; }
    public int Multiplier { get; set; }
    
    public ThunderStrikeSkill(int totalDmg)
    {
        TotalDmg = totalDmg;
        Multiplier = 2;
    }

    public void Execute(IBattleUnit caster, IBattleUnit target)
    {
        var existCharm = target.CurrentEffects.Find(e => e.BattleStateEnum == BattleStateEnum.Charmed); ; 
        if (existCharm != null)
        {
            TotalDmg *= Multiplier;
        }

        target.Hp = Math.Max(0, target.Hp - TotalDmg);
    }
}