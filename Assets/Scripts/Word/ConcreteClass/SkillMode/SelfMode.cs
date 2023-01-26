using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 自身（均自己写）
/// </summary>
class SelfMode : AbstractSkillMode
{
    public void Awake()
    {
        skillModeID = 2;
        skillModeName = "自身";
    }


    public override void UseMode(AbstractCharacter useCharacter, float value, AbstractCharacter aimCharacter)
    {
        
    }
    public override AbstractCharacter[] CalculateAgain(int attackDistance, AbstractCharacter character)
    {
        return new AbstractCharacter[] { character };
    }
}
