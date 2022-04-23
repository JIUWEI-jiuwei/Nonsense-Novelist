using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 回血
/// </summary>
class PlatformMode : AbstractSkillMode
{
    public void Awake()
    {
        skillModeID = 6;
        skillModeName = "场地魔法";
    }
    public override void UseMode(int value, AbstractCharacter character)
    {
       
    }
}
