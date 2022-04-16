using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 伤害技能
/// </summary>
class DamageMode : AbstractSkillMode
{
   public DamageMode()
    {
        skillModeID = 2;
        skillModeName = "伤害技能";
    }
    public override void UseMode(int value, AbstractCharacter character)
    {
        character.hp-=value-(int)(character.def*0.6f);
        
    }
}
