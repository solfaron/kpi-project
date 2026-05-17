using KPI_PROJECT.Models.EnemySkills;
using Lib.Core.BaseClasses;
using Lib.Core.Interfaces;

namespace Lib.Core.Models.Enemies.FirstLevel;

public class WiseMagician : EnemyBase, IBattleUnit
{
    public WiseMagician()
    {
        Hp = 35;
        MaxHp = 35;
        HandDmg = 6;
        Name = "Wise Magician";
        PhisDefense = 2;
        CurrentSkills.Add(new FireballSkill(10));
        CurrentSkills.Add(new CharmSkill());
        CurrentSkills.Add(new ThunderStrikeSkill(4));
    }
    
    public override void CastSkill(ISkill chosenSkill, IBattleUnit target)
    {
        chosenSkill.Execute(this, target);
    }
}