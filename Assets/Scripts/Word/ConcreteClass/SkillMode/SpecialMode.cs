using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 特殊效果
/// </summary>
class SpecialMode : AbstractSkillMode
{
    public void Awake()
    {
        skillModeID = 4;
        skillModeName = "赋予特殊状态";
    }
    public override void UseMode(AbstractCharacter useCharacter, float value, AbstractCharacter aimCharacter)
    {
    }
}
