using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// �˺�����
/// </summary>
class DamageMode : AbstractSkillMode
{
   public DamageMode()
    {
        skillModeID = 2;
        skillModeName = "�˺�����";
    }
    public override void UseMode(int value, AbstractCharacter character)
    {
        character.hp-=value-(int)(character.def*0.6f);
        
    }
}
